using MyPersonalCollection.Api.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPersonalCollection.Api.Models
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Title;
        [Required]
        public string Author;
        public int Edition;
        public int? NumberOfPages;
        public DateTime PublishedDate;
    }
}
