using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_DET_2022
{
    internal class companymanager
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }

        public string Print()

        {
            return $"Name={Name}, Surname={Surname},Phone={Phone}";
        }
    }
}
