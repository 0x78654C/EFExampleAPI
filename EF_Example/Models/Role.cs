namespace EF_Example.Models
{
    public class Role
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<UseRole> UserRoles { get; set; } = new List<UseRole>();
    }
}
