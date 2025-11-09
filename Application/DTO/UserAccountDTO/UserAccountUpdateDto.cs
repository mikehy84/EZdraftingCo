using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.UserAccountDTO
{
    public class UserAccountUpdateDto
    {
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
        public string? JobTitle { get; set; } = string.Empty;
        public string? JobLocation { get; set; } = string.Empty;
        public string? Licensure { get; set; } = string.Empty;
        public string? QuestionFirst { get; set; } = string.Empty;
        public string? AnswerFirst { get; set; } = string.Empty;
        public string? QuestionSecond { get; set; } = string.Empty;
        public string? AnswerSecond { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string? StreetAddress { get; set; } = string.Empty;
        public string? City { get; set; } = string.Empty;
        public string? State { get; set; } = string.Empty;
        public string? PostalCode { get; set; } = string.Empty;
    }
}
