using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
        public struct MyFrac
        {
            public long nom { get; set; }
            public long denom { get; set; }

            public MyFrac(long _nom, long _denom)
            {
            if (_nom!= 0)
            {
                long a = _nom;
                long b = _denom;
                while (b != 0)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }

                nom = (_denom > 0) ? _nom / a : -(_nom / a);
                denom = (_denom > 0) ? _denom / a : Math.Abs(_denom) / a;
            }
            else
            {
                nom = 0; denom=_denom;
            }
            }

            public override string ToString()
            {
                return nom + "/" + denom;
            }
        }
    
}
