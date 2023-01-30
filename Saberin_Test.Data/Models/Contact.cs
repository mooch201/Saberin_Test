namespace Saberin_Test.Data.Models
{
	public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public List<Address>? Addresses { get; set; }

	}
}
