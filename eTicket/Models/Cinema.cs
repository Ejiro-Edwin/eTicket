using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Logo is required!")]
        [MaxLength(255)]
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }

        [Required(ErrorMessage = "Cinema name is required!")]
        [MaxLength(100)]
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cinema description is required!")]
        [MaxLength(255)]
        [Display(Name = "Cinema Description")]
        public string Description { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
