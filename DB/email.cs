using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emal.DB
{
    public class email
    {
        public int Id { get; set; }
        public string browser { get; set; }

        public int userId { get; set; }
        public user user { get; set; }
    }
}
