using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace TheatreCMS3.Areas.Blog.Models
{
    public class BlogAuthor
    {
        // Primary Key
        public int BlogAuthorId { get; set; }

        // Author first name
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        // Author last name
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        // Short biography
        [DataType(DataType.MultilineText)]
        public string Bio { get; set; }

        // Date the author was added
        [Display(Name = "Joined Date")]
        public DateTime Joined { get; set; }

        public DateTime? Left { get; set; }
    }
}