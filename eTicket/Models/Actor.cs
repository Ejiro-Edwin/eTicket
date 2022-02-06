using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Profile picture is required!")]
        [MaxLength(255)]
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureUrl { get; set; }

        [Required(ErrorMessage = "Full name is required!")]
        [MaxLength(100)]
        [Display(Name = "Actor Fullname")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Fullname must be between 3 and 50 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Biogragphy is required!")]
        [MaxLength(255)]
        [Display(Name = "Full Biography")]
        public string Bio { get; set; }

        //Relationships

        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
