namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] Passwordhash { get; set; }
        
        public byte[] Passwordsalt { get; set; }
    }
}