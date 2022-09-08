using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Header : IEntity
    {
        [Key]
        public int HeaderID { get; set; }

        public string HeaderImageUrl { get; set; }

        public string HeaderDescription { get; set; }
    }
}
