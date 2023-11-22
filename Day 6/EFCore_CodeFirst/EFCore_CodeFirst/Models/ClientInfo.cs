using System.ComponentModel.DataAnnotations;

namespace EFCore_CodeFirst.Models
{
    public class ClientInfo
    {
        [Key]
        public int clientId { get; set; }
        public string clientName { get; set; }

        public string clientLocation { get; set; }

        public string clientProjectName { get; set; }
    }
}
