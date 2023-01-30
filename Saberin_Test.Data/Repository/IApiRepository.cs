using Saberin_Test.Data.Models;

namespace Saberin_Test.Data.Repository
{
	public interface IApiRepository
	{
		public List<Contact> GetContacts();
    }
}
