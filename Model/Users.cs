using System.ComponentModel.DataAnnotations;

namespace WS.DataServices.Model
{
    public class Users
    {
        [Key]
        private int Id { get; set; }
        private string UserName { get; set; }
        private string Email { get; set; }
        private string password { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
    }
}
