using Saberin_Test.Data.Context;
using Microsoft.EntityFrameworkCore;
using Saberin_Test.Data.Models;

namespace Saberin_Test.Data.Repository
{
	public class ApiRepository : IApiRepository
	{
		public ApiRepository()
		{
			AddData();
		}
		public List<Contact> GetContacts()
		{
			using (var context = new ApiContext())
			{
				var list = context.Contacts
				.Include(a => a.Addresses)
				.ToList();
				return list;
			}
		}
		private void AddData()
		{
			using (var _context = new ApiContext())
			{

				var contacts = new List<Contact>
				{
					new Contact
					{
						FirstName ="Andre",
						LastName ="Bogojevic",
						Addresses = new List<Address>()
						{
							new Address(){
								Street = "88 W Industry Ct",
								City = "Deer Park",
								State = "NY",
								ZipCode = "11729"
							}
						}
					},
					new Contact
					{
						FirstName ="Jay",
						LastName ="Muccione",
						Addresses = new List<Address>()
						{
							new Address(){
								Street = "606 Kings Cv",
								City = "Brandon",
								State = "FL",
								ZipCode = "33511"
							},
							new Address(){
								Street = "9826 NW 65th PL",
								City = "Tamarac",
								State = "FL",
								ZipCode = "33321"
							}
						}
					}
				};
				_context.Contacts.AddRange(contacts);
				_context.SaveChanges();
			}
		}
	}
}