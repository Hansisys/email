using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emal.DB
{
   public class user
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Familia { get; set; }

        public List<email> emails { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
