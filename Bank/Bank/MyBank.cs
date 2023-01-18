using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class MyBank
    {
        public float deposit = 0;
        private int count = 0;
        public MyBank()
        {

        }
        public void CheckAccount()
        {

            count++;
            if (count <= 20)
            {
                deposit -= .1f;
            }
            else if (count > 20 && count <= 39)
            {
                deposit -= .08f;
            }
            else if (count >= 40 && count <= 59)
            {
                deposit -= 0.06f;
            }
            else
            {
                deposit -= 0.04f;
            }
        }


        public int getCount()
        {
            return count;
        }

    }

}
