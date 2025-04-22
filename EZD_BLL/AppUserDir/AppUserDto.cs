namespace EZD_BLL.AppUserDtoDir
{
    public class AppUserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string JobLocation { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
