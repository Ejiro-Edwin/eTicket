using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(255)]
        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage = "Profile picture is required!")]
        public string ProfilePictureUrl { get; set; }


        [MaxLength(100)]
        [Display(Name = "Producer Full Name")]
        [Required(ErrorMessage = "Producer name is required!")]
        public string FullName { get; set; }


        [MaxLength(255)]
        [Required(ErrorMessage = "Biography is required!")]
        [Display(Name = "Producer Full Biography")]
        public string Bio { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
