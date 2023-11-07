using System.ComponentModel.DataAnnotations;

namespace Project_03.Models
{
    public class AddressModel
    {
        [Key]
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
}
