using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakiaroCalculator.Src
{
    internal class Helper
    {
        public void findForm1(Control cPTmp)
        {
            Console.WriteLine(cPTmp.GetType());
            while (true)
            {
                if (cPTmp != null)
                {
                    Console.WriteLine(cPTmp);
                    cPTmp = cPTmp.Parent;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
