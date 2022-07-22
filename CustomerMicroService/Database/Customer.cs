using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerMicroService.Database
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerMiddleName { get; set; }
        public string CustomerLastName { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
