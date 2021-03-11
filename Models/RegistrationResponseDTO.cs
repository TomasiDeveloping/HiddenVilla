using System.Collections.Generic;

namespace Models
{
    public class RegistrationResponseDTO
    {
        public bool RegistrationSuccessful { get; set; }
        public IEnumerable<string> Errors { get; set; }
        
    }
}