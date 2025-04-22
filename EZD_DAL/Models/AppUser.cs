using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZD_DAL.Models
{
    public class AppUser : IdentityUser
    {
        [Required]

        private string? _name;
        public string Name
        {
            get => string.IsNullOrEmpty(_name) ? FirstName + " " + LastName : _name;
            set => _name = value;
        }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string JobLocation { get; set; } = string.Empty;
        public string Licensure { get; set; } = string.Empty;
        public string QuestionFirst { get; set; } = string.Empty;
        public string QuestionSecond { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
    }
}
