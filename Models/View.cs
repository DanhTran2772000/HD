﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using HD.Models;

namespace HD.Models
{
    public class View
    {
        [Key]
        public int Id { get; set; }

        public int IdeaId { get; set; }

        public string UserId { get; set; }

        public View()
        { }
    }
}
