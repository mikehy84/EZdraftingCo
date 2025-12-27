

namespace Domain.Entities
{
    public class Job
    {
        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        // Job is the parent in the one-to-many relationship
        // Job (parent / principal) = one job can belong to many people
        // Person (child / dependent) = each person optionally has one job
        // Persons that hold this Job
        public ICollection<Person> Persons { get; set; } = [];
    }
}
