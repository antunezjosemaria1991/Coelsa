using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiCoelsa.Models;

namespace WebApiCoelsa.Interfaces
{
	public interface IContactRepository
	{
		Task<List<Contact>> GetAllContacts();
		Contact GetContactById(int ContactId);
		Task<Contact> CreateContact(Contact contact);
	}
}
