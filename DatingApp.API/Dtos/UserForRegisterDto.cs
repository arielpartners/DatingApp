using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get;set;}

        [Required]
        [StringLength(9, MinimumLength=4, ErrorMessage="You must specify a password between 4 and 8 characters")]
        public string Password {get;set;}
        public string Gender { get;set;}
        public string KnownAs { get;set;}
        public DateTime DateOfBirth { get;set;}
        public string City { get;set;}
        public string Country { get;set;}
        public DateTime Created { get;set; }
        public DateTime LastActive { get;set; }

        public UserForRegisterDto() 
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}