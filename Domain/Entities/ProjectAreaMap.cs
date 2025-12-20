

namespace Domain.Entities
{
    public class ProjectAreaMap
    {
        public int Id { get; set; }


        // ProjectAreaMap is the child in the one-to-many relationship
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;


        // ProjectAreaMap is the child in the one-to-many relationship
        public int AreaId { get; set; }
        public Area Area { get; set; } = null!;

        public ProjectAreaMap() { }
        public ProjectAreaMap(int projectId, int areaId)
        {
            ProjectId = projectId;
            AreaId = areaId;
        }
    }
}
