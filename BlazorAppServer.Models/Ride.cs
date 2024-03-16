using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppServer.Models
{
    [Table(nameof(Ride))]
    public class Ride
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RideId { get; set; }        
        public string DepartureLocation { get; set; }
        public string Destination { get; set; }
        public DateTime? DepartureTime { get; set; } 

        public string VehicleType { get; set; }
        public string RideDetails { get; set; } 
        public decimal EstimatedFare { get; set; } 
        public bool IsSmokingAllowed { get; set; } 

        [ForeignKey(nameof(User.UserId))]
        public int UserId { get; set; }
        public User? User { get; set; }
    }

    
}
