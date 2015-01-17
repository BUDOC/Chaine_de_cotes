using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Tablos
    {
        public cond[] TabCOnd = new cond[10];
        public cf[] TabCf = new cf[10];


        public void iniTabcf() //n'est pas appelable depuis Form1???
        {

            for (int i = 0; i <= 9; i++)
            {
                TabCf[i] = null;
            }
        }

    }
}
