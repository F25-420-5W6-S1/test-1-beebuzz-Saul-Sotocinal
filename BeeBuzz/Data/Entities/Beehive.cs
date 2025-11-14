using BeeBuzz.Data.Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeeBuzz.Data.Entities
{
    public class Beehive
    {
        [Key]
        public string Id { get; set; }
        public string Location { get; set; }
        public BeehiveStatus Status { get; set; }
        public DeactivationReason DeactivationReason { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser user { get; set; }
        public string UserId { get; set; }
    }
}
