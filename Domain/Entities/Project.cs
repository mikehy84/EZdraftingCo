using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


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

        public string[]? ImageUrls { get; set; }
    }
}
