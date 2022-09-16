using System;
using System.ComponentModel.DataAnnotations;

namespace ListBook.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(300)]
        public string Name { get; set; }


        [MaxLength(400)]
        public string Auther { get; set; }


        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime CraeteDate { get; set; } = DateTime.Now;

        [MaxLength(400)] 
        public string ISBN { get; set; }
    }
}
