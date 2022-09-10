using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Skill : IEntity
    {
        public int SkillID { get; set; }

        public string SkillName { get; set; }
    }
}
