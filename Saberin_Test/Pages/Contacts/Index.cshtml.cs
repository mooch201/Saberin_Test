using Microsoft.AspNetCore.Mvc.RazorPages;
using Saberin_Test.Data.Models;
using Saberin_Test.Data.Repository;
using System.Diagnostics;

namespace Saberin_Test.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly IApiRepository _repository;
        public IList<Contact> Contact { get;set; } = default!;

		public IndexModel(IApiRepository apiRepository)
        {
			_repository = apiRepository;

            // should move this to an async method 
            Contact = _repository.GetContacts();
        }
    }
}
