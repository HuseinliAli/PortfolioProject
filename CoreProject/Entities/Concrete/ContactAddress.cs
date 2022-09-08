using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ContactAddress : IEntity
    {
        [Key]
        public int ContactAddressID { get; set; }

        public string ContactAddressTitle { get; set; }

        public string ContactAddressDescription { get; set; }

        public string ContactAddressEmail { get; set; }
    }
}
