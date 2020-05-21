using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFWServer.Models
{
    public class Profile
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long ServerId { get; set; }
        public string ProfileName { get; set; }
    }
}
