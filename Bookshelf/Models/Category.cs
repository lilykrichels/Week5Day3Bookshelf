using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Category
    {
        [Key]
        public int  ID { get; set;  }
        [Display(Name = "Category Name")]

        //this tells the program to change display "Category Name" instead of name on the table

        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        //this is is a type of list that calls from the Book Class and is called "books"
    }
}