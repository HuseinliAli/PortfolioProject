using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contact : IEntity
    {
        [Key]
        public int ContactID { get; set; }

        public string ContactName { get; set; }

        public string ContactLastName { get; set; }

        public string ContactEmail { get; set; }

        public string ContactMessage { get; set; }

        public bool ContactStatus { get; set; }
    }
}
