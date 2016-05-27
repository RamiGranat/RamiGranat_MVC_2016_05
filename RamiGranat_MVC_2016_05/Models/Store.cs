using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RamiGranat_MVC_2016_05.Models
{
    public class Store
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public Product Products { get; set; }
    }
}