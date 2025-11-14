namespace BeeBuzz.Data.Entities
{
    public class Organization : ApplicationUser
    {
        public List<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
