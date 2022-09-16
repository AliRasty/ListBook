using System;
using System.ComponentModel.DataAnnotations;

namespace ListBook.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Name { get; set; }


        [MaxLength(400)]
        public string Auther { get; set; }


        [Required]
        public DateTime CraeteDate { get; set; }

        [MaxLength(400)] 
        public string ISBN { get; set; }
    }
}
