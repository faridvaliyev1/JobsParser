using System;
using System.Collections.Generic;

namespace JobsParser.Models
{
    public class Site
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public DateTime Create_Date { get; set; }

        public string Title_Template { get; set; }

        public string Description_Template { get; set; }
        public string Url_Template { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
