namespace Domain.Entities
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;


        // Foreign key to the Country
        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;


        // Addresses within this state
        public ICollection<Address> Addresses { get; set; } = [];
    }
}