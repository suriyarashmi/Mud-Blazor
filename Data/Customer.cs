using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mud_Blazor.Data
{
	public class Customer
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
			public int CustomerID { get; set; } = 0;
			public string Name { get; set; }
		    public string Role { get; set; }

	}
}
