using System;
using System.ComponentModel.DataAnnotations;

namespace ShantiHospitalWeb.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime RegisteredOn { get; set; } = DateTime.Now;
    }
}
