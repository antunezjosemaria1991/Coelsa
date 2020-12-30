using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiCoelsa.Interfaces;
using WebApiCoelsa.Models;

namespace WebApiCoelsa.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : Controller
	{		
		private readonly IContactRepository _contactRepository;

		public ContactController(IContactRepository contactRepository)
		{
			_contactRepository = contactRepository;
		}

		[HttpGet]		
		public async Task<ActionResult> GetContacts()
		{			
			var result = await _contactRepository.GetAllContacts();

			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Contact>> GetContact(int id)
		{			
			return _contactRepository.GetContactById(id);
		}
						
		[HttpPost]
		public async Task<ActionResult<Contact>> CreateContact(Contact contact)
		{
			return Ok(await _contactRepository.CreateContact(contact));
		}				
	}
}
