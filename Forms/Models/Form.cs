using System;
using System.ComponentModel.DataAnnotations;

namespace Forms.Models
{
    public class Form
    {
        public int FormId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }

    }
}

