using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace BlazorAppServer.Models
{
    [Table("User")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

		[Required, NotNull]
		[StringLength(50, MinimumLength = 6)]
		public string Username { get; set; }       
        public string? Phone { get; set; }
        public ICollection<Ride> Rides { get; set; } = [];
    }
}
