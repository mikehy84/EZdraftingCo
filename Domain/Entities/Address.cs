namespace Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }


        // Foreign key to the State
        public int StateId { get; set; }
        public State State { get; set; }


        public string StreetNumber { get; set; } = string.Empty;
        public string StreetName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public bool IsPrimary { get; set; }


        // Foreign key to the Person
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}