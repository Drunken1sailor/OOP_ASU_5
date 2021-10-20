using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASU_5.Domain
{
    class ContentLink
    {
        // Поля
        public Guid id { get; set; }
        public String type { get; set; }
         public String url { get; set; }

        // Свойства навигации
    }
}
