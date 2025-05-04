namespace EZD_BLL.AppUserDir.Dto
{
    public class AppUserDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; } = string.Empty;
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
