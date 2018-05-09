using System.ComponentModel.DataAnnotations;

namespace tryCoreOnce.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }
        public int UserAge { get; set; }
    }
}