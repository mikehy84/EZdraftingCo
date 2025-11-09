

namespace Domain.Entities
{
    public class CompanyCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;



        // CompanyCategory is the parent in the
        // one-to-many relationship
        public ICollection<Company> Companies { get; set; } = [];
    }
}
