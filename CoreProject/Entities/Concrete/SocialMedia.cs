using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SocialMedia : IEntity
    {
        [Key]
        public int SocialMediaID { get; set; }

        public string SocialMediaName { get; set; }

        public string SocialMediaUrl { get; set; }

        public string SocialMediaIcon { get; set; }

        public bool SocialMediaStatus { get; set; }
    }
}
