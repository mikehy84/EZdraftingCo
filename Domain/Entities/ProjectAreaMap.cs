using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProjectAreaMap
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

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
