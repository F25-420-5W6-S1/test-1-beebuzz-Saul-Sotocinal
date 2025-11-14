using System.ComponentModel.DataAnnotations.Schema;

namespace BeeBuzz.Data.Entities
{
    public class User : ApplicationUser
    {
        public List<Beehive> Beehives { get; set; } = new List<Beehive>();

        [ForeignKey("OrganizationId")]
        public Organization Organization { get; set; }
        public string OrganizatioId { get; set; }
    }
}
