using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_DET_2022
{
    internal interface Interface2
    {
        public int GetPrice(string name)


        {
            if (name == "M3")
                return 1300000;
            else if (name == "x7")
                return 897000;
            else
                return 100000;
        }


            


    }
    

}




    

