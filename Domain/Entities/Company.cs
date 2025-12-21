

namespace Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;


        // CompanyType that this Company belongs to
        public int CompanyTypeId { get; set; }
        public CompanyType CompanyType { get; set; }


        // Persons that belong to this Company
        public ICollection<Person> Persons { get; set; } = [];


        // ClientProjects that belong to this Company
        public ICollection<ClientProject> ClientProjects { get; set; } = [];



    }
}
