using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCoelsa.Models
{
	public class Contact
	{
		[Key]
		public int ContactId { get; set; }
		[Column(TypeName ="nvarchar(100)")]
		public string FirstName { get; set; }
		[Column(TypeName = "nvarchar(100)")]
		public string LastName { get; set; }
		[Column(TypeName = "nvarchar(100)")]
		public string Company { get; set; }
		[Column(TypeName = "nvarchar(100)")]
		public string Email { get; set; }
		[Column(TypeName = "nvarchar(100)")]
		public string PhoneNumber { get; set; }
	}
}
