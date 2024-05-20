using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agri_Connect_Platform.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public int FarmerID { get; set; }

        [ForeignKey("FarmerID")]
        public Farmer Farmer { get; set; }

        [Required]
        public string Name { get; set; }

        public string Category { get; set; }

        [Display(Name = "Production Date")]
        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }
    }
}
