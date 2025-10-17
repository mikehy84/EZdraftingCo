using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProjectDir.Dto
{
    public class CreateProjectDto
    {
        [Required]
        [StringLength(50)]
        public string ProjectName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string BuildingName { get; set; } = string.Empty;

        [Required]
        [MaxLength(300)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int Weight { get; set; }

        public List<IFormFile>? Photos { get; set; }
        public string[]? ImageUrls { get; set; }
    }

}
