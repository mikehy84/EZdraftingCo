

namespace Domain.Entities
{
    public class CompanyType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;



        // Companies that belong to this CompanyType
        public ICollection<Company> Companies { get; set; } = [];
    }
}
