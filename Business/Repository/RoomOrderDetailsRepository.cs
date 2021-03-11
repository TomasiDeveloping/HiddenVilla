﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using Common;
using DataAcess.Data;
using DataAcesss.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Business.Repository
{
    public class RoomOrderDetailsRepository : IRoomOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public RoomOrderDetailsRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<RoomOrderDetailsDTO> Create(RoomOrderDetailsDTO details)
        {
            try
            {
                details.CheckInDate = details.CheckInDate.Date;
                details.CheckOutDate = details.CheckOutDate.Date;
                var roomOrder = _mapper.Map<RoomOrderDetailsDTO, RoomOrderDetails>(details);
                roomOrder.Status = SD.Status_Pending;
                var result = await _db.RoomOrderDetails.AddAsync(roomOrder);
                await _db.SaveChangesAsync();
                return _mapper.Map<RoomOrderDetails, RoomOrderDetailsDTO>(result.Entity);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Task<RoomOrderDetailsDTO> MarkPaymentSuccessful(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<RoomOrderDetailsDTO> GetRoomOrderDetails(int roomOrderId)
        {
            try
            {
                RoomOrderDetails roomOrder = await _db.RoomOrderDetails.Include(u => u.HotelRoom)
                    .ThenInclude(x => x.HotelRoomImages).FirstOrDefaultAsync(u => u.Id == roomOrderId);

                RoomOrderDetailsDTO roomOrderDetailsDto = _mapper.Map<RoomOrderDetails, RoomOrderDetailsDTO>(roomOrder);
                roomOrderDetailsDto.HotelRoomDTO.TotalDays =
                    roomOrderDetailsDto.CheckOutDate.Subtract(roomOrderDetailsDto.CheckInDate).Days;

                return roomOrderDetailsDto;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<IEnumerable<RoomOrderDetailsDTO>> GetAllRoomOrderDetails()
        {
            try
            {
                IEnumerable<RoomOrderDetailsDTO> roomOrders =
                    _mapper.Map<IEnumerable<RoomOrderDetails>, IEnumerable<RoomOrderDetailsDTO>>(
                        _db.RoomOrderDetails.Include(u => u.HotelRoom));
                return roomOrders;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Task<bool> UpdateOrderStatus(int roomOrderId, string status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsRoomBooked(int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            var status = false;
            var existingBooking = await _db.RoomOrderDetails.Where(x => x.RoomId == roomId && x.IsPaymentSuccessful &&
                                                                        // check if chekin date that user want does not fall in between any dates for room that is booked
                                                                        (checkInDate < x.CheckOutDate &&
                                                                         checkInDate.Date > x.CheckInDate
                                                                         // check if checkout date that user wants does not fall in between any dates for room that is booked
                                                                         || checkOutDate.Date > x.CheckInDate.Date &&
                                                                         checkInDate.Date < x.CheckInDate.Date)).FirstOrDefaultAsync();
            if (existingBooking != null)
            {
                status = true;
            }

            return status;
        }
    }
}