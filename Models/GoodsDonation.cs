using System;
using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviationFoundation.Models
{
    public class GoodsDonation
    {
        [Key]
        public int GoodsDonationID { get; set; }

        [Required(ErrorMessage = "Donor Name is required")]
        [StringLength(100, ErrorMessage = "Donor Name cannot exceed 100 characters")]
        public string DonorName { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [StringLength(50, ErrorMessage = "Category cannot exceed 50 characters")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, 10000, ErrorMessage = "Quantity must be between 1 and 10,000")]
        public int Quantity { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DonationDate { get; set; } = DateTime.Now;
    }
}
