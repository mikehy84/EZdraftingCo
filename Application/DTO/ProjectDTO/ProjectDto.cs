namespace Application.DTO.ProjectDTO
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string BuildingName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Weight { get; set; }
        public string[]? ImageUrls { get; set; }
    }
}
