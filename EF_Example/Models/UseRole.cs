namespace EF_Example.Models
{
    public class UseRole
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public long UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public virtual Role? Role { get; set; }

        public virtual UserLogin? User { get; set; }
    }
}
