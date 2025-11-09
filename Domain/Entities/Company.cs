

namespace Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;


        // Company is the cild in the
        // one-to-many relationship
        public int CategoryId { get; set; }
        public CompanyCategory CompanyCategory { get; set; }


        // Company is the parent in the
        // one-to-many relationship
        public ICollection<Person> Persons { get; set; } = [];


        // Company is the parent in the
        // one-to-many relationship
        public ICollection<ClientProject> ClientProjects { get; set; } = [];



    }
}
