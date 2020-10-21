namespace Assignment1.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Domain { get; set; }
        public string City { get; set; }
        public int BirthYear { get; set; }
        public string Role { get; set; }
        public int SecurityLevel { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public bool LoggedIn { get; set; }
    }
}