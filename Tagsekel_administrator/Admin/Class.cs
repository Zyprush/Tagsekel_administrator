using System.ComponentModel.DataAnnotations;
namespace Tagsekel_administrator.Admin
{
    public class Class
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string Subscription { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime Assigned { get; set; }
        [DataType(DataType.Date)]
        public DateTime Expired { get; set; }
    }
}
