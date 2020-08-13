using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemonickGeneral.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Max length is 20")]
        public string Name { get; set; }
    }
}
