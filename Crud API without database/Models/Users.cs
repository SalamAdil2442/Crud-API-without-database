namespace Crud_API_without_database.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }= string.Empty;
        public double Password { get; set; }

        public string Place { get; set; } = string.Empty;
        public string GitHub { get; set; }  =string .Empty;






    }
}
