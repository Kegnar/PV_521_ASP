using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Direction
	{
		[Key]
		public int direction_id { get; set; }

		[Required]
		[StringLength(50, MinimumLength = 2)]
		public string direction_name { get; set; }
	}
}
