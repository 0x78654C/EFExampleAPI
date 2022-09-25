namespace EF_Example
{
    public class UserLogin
    { 
        public long id { get; set; }
        public string? User_name { get; set; }
        public string? Password { get; set; }
        public DateTime Login_date { get; set; } = DateTime.UtcNow;
    }
}
