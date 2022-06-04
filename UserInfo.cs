using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microboinc_GUI
{
    internal class UserInfo
    {
        public string Name { get; set; }
        public long discordid { get; set; }
        public UserInfo(string Name, long discordid)
        {
            this.Name = Name;
            this.discordid = discordid;
        }
    }
}
