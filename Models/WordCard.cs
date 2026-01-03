using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EnglishApp.Models
{
    public class WordCard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Word { get; set; } = string.Empty;
        public string Phonetic { get; set; } = string.Empty;
        public string Definition { get; set; } = string.Empty;
        public string ExampleSentence { get; set; } = string.Empty;
        public string AudioUrl { get; set; } = string.Empty; 

        public DateTime NextReviewDate { get; set; } = DateTime.Now; 
        public int ReviewStep { get; set; } = 0;
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}
