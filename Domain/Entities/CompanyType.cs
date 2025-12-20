

namespace Domain.Entities
{
    public class CompanyType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;



        // CompanyType is the parent in the one-to-many relationship
        public ICollection<Company> Companies { get; set; } = [];
    }
}
