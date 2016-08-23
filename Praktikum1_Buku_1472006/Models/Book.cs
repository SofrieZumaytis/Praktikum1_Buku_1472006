using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Praktikum1_Buku_1472006.Models
{
    public class Book
    {
        [Key, MaxLength(20)]
        public string ISBN { get; set; }
        = Guid.NewGuid().ToString();


        [Required,MaxLength(100)]
        public string Author { get; set; }


        [Required, MaxLength(100)]
        public string Title { get; set; }


        [Required, MaxLength(100)]
        public string Publisher { get; set; }


        [Required,Range(0,9999)]
        public int Year { get; set; }

        public bool Deleted { get; set; }


    }
}