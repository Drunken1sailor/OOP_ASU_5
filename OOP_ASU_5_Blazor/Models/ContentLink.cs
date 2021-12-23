using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASU_5_Blazor.Models
{
    public class ContentLink
    {
        // Properties
        public Guid Id { get; set; }
        public Guid DocId { get; set; }
        public string ContentType { get; set; }
        public string Url { get; set; }
    }
}
