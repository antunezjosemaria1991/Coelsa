using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCoelsa.Models;

namespace WebApiCoelsa.Interfaces
{
	public class ContactRepository : IContactRepository
	{
		private readonly CoelsaDbContext _ctx;

		public ContactRepository(CoelsaDbContext ctx)
		{
			_ctx = ctx;
		}
		public async Task<Contact> CreateContact(Contact contact)
		{
			_ctx.Contacts.Add(contact);
			await _ctx.SaveChangesAsync();

			return contact;
		}
		public async Task<List<Contact>> GetAllContacts()
		{
			return await _ctx.Contacts.ToListAsync();
		}
		public Contact GetContactById(int ContactId)
		{
			return  _ctx.Contacts.FirstOrDefault(x => x.ContactId == ContactId);
		}
	}
}
