using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Academy.Models
{
    public class Group
    {
        [Key]
        public int group_id { get; set; }

        [Required]
        public string group_name { get; set; }

        [ForeignKey("direction")]
        public short direction { get; set; }
        public Direction Direction { get; set; }

        public short weekdays { get; set; }
        public DateOnly start_date { get; set; }

    }
}