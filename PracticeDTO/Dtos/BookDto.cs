using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeDTO.Dtos
{
    public class BookDto
    {
        public string Name { get; set; }
        public int? Pages { get; set; }
        public DateTime? Publish_Date { get; set; }
    }
}