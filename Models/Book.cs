using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    
        public class Book
        {
            public int Id { get; set; } 
            public string title { get; set; }
            public string Author { get; set; }
            public string description { get; set; }
            public string publisher { get; set; }
            public string status { get; set; }
            public string category { get; set; }
        }
    }