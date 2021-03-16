using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using DataAcess.Data;
using DataAcesss.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public HotelRoomRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoomDto)
        {
            var hotelRoom = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelRoomDto);
            hotelRoom.CreatedDate = DateTime.Now;
            hotelRoom.CreatedBy = "";
            var addedHotelRoom = await _db.HotelRooms.AddAsync(hotelRoom);
            await _db.SaveChangesAsync();
            return _mapper.Map<HotelRoom, HotelRoomDTO>(addedHotelRoom.Entity);
        }

        public async Task<HotelRoomDTO> UpdateHotelRoom(int roomId, HotelRoomDTO hotelRoomDto)
        {
            try
            {
                if (roomId == hotelRoomDto.Id)
                {
                    // valid
                    var roomDetails = await _db.HotelRooms.FindAsync(roomId);
                    var room = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelRoomDto, roomDetails);
                    room.UpdatedBy = "";
                    room.UpdatedDate = DateTime.Now;
                    var updatedRoom = _db.HotelRooms.Update(room);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<HotelRoom, HotelRoomDTO>(updatedRoom.Entity);
                }
                else
                {
                    //invalid
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
       
        }

        public async Task<HotelRoomDTO> GetHotelRoom(int roomId, string checkInDateStr, string checkOutDateStr)
        {
            try
            {
                HotelRoomDTO hotelRoomDto = _mapper.Map<HotelRoom, HotelRoomDTO>(await 
                    _db.HotelRooms.Include(x => x.HotelRoomImages).FirstOrDefaultAsync(x => x.Id == roomId));
                if (!string.IsNullOrEmpty(checkInDateStr) && !string.IsNullOrEmpty(checkOutDateStr))
                {
                    hotelRoomDto.IsBooked = await IsRoomBooked(roomId, checkInDateStr, checkOutDateStr);
                }
                return hotelRoomDto;

            }
            catch (Exception e)
            {
                return null;
            }
        }
        
        public async Task<bool> IsRoomBooked(int roomId, string checkInDatestr, string checkOutDatestr)
        {
            try
            {
                if (!string.IsNullOrEmpty(checkOutDatestr) && !string.IsNullOrEmpty(checkInDatestr))
                {
                    DateTime checkInDate = DateTime.ParseExact(checkInDatestr, "MM.dd.yyyy", null);
                    DateTime checkOutDate = DateTime.ParseExact(checkOutDatestr, "MM.dd.yyyy", null);
                    var existingBooking = await _db.RoomOrderDetails.Where(x => x.RoomId == roomId && x.IsPaymentSuccessful &&
                        // check if chekin date that user want does not fall in between any dates for room that is booked
                        ((checkInDate < x.CheckOutDate &&
                         checkInDate.Date >= x.CheckInDate)
                         // check if checkout date that user wants does not fall in between any dates for room that is booked
                         || (checkOutDate.Date > x.CheckInDate.Date &&
                         checkInDate.Date <= x.CheckInDate.Date))).FirstOrDefaultAsync();
                    if (existingBooking != null)
                    {
                        return true;
                    }

                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<int> DeleteHotelRoom(int roomId)
        {
            var roomDetails = await _db.HotelRooms.FindAsync(roomId);
            if (roomDetails != null)
            {
                var allImgaes = await _db.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();
                
                _db.HotelRoomImages.RemoveRange(allImgaes);
                _db.HotelRooms.Remove(roomDetails);
                return await _db.SaveChangesAsync();
            }

            return 0;
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetAllHotelRooms(string checkInDateStr, string checkOutDateStr)
        {
            try
            {
                IEnumerable<HotelRoomDTO> hotelRoomDtos =
                    _mapper.Map<IEnumerable<HotelRoom>, IEnumerable<HotelRoomDTO>>(_db.HotelRooms.Include(x => x.HotelRoomImages));
                if (!string.IsNullOrEmpty(checkInDateStr) && !string.IsNullOrEmpty(checkOutDateStr))
                {
                    foreach (var hotelRoom in hotelRoomDtos)
                    {
                        hotelRoom.IsBooked = await IsRoomBooked(hotelRoom.Id, checkInDateStr, checkOutDateStr);
                    }
                    
                }
                return hotelRoomDtos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        // if unique returns null else returns the room obj
        public async Task<HotelRoomDTO> IsRoomUnique(string name, int roomId = 0)
        {
            try
            {
                if (roomId == 0)
                {
                    HotelRoomDTO hotelRoomDto = _mapper.Map<HotelRoom, HotelRoomDTO>(await 
                        _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower()));
                    return hotelRoomDto;

                }
                else
                {
                    HotelRoomDTO hotelRoomDto = _mapper.Map<HotelRoom, HotelRoomDTO>(await 
                        _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower() && x.Id != roomId));
                    return hotelRoomDto;
                }
    
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}