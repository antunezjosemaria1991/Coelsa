using Moq;
using NUnit.Framework;
using System.Threading.Tasks;
using WebApiCoelsa.Controllers;
using WebApiCoelsa.Interfaces;
using WebApiCoelsa.Models;

namespace NUnitTestCoelsa
{
	public class ContactControllerTest
	{
		private Mock<IContactRepository> repository;
		private ContactController controller;

		[SetUp]
		public void SetUp()
		{
			repository = new Mock<IContactRepository>();
			controller = new ContactController(repository.Object);
		}

		[Test]
		public async Task GetContactByIdIsOk()
		{
			var contact = new Contact() { FirstName = "Jose Maria", ContactId = 1 };			
			repository.Setup(x => x.GetContactById(1)).Returns(contact);
			var result = await controller.GetContact(1);
			Assert.AreEqual(result.Value.FirstName, contact.FirstName);
		}	
	}
}