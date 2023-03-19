namespace EF_Example.Models
{
    public class Role
    {
        public int? Id { get; set; }
        public string? Role_Name { get; set; }
        public virtual ICollection<UseRole> UserRoles { get; set; } = new List<UseRole>();
    }
}
