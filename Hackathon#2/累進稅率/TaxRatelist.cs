using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon003
{
    public class TaxRatelist
    {
        private List<TaxRate> list;
        public TaxRatelist()
        {
            list = new List<TaxRate>();
            list.Add(new TaxRate { StartRate = 0, EndRate = 540000, POWRate = 0.05m });
            list.Add(new TaxRate { StartRate = 540001, EndRate = 1210000, POWRate = 0.12m });
            list.Add(new TaxRate { StartRate = 1210001, EndRate = 2420000, POWRate = 0.2m });
            list.Add(new TaxRate { StartRate = 2420001, EndRate = 4530000, POWRate = 0.3m });
            list.Add(new TaxRate { StartRate = 4530001, EndRate = 10310000, POWRate = 0.4m });
            list.Add(new TaxRate { StartRate = 10310001, EndRate = int.MaxValue, POWRate = 0.5m });
        }

        public void Tax(decimal income)
        {
            if(income <= 540000)
            {
                Console.WriteLine(income * 0.05m);
            }
            if(income > 540000 && income <= 1210000)
            {
                Console.WriteLine(((income - 540000) * 0.12m) + 27000);
            }
            if (income > 1210000 && income <= 2420000)
            {
                Console.WriteLine(((income - 1210000) * 0.2m) + 27000 + 80400);
            }
            if (income > 2420000 && income <= 4530000)
            {
                Console.WriteLine(((income - 2420000) * 0.3m) + 27000 + 80400 + 242000);
            }
            if (income > 4530000 && income <= 10310000)
            {
                Console.WriteLine(((income - 4530000) * 0.4m) + 27000 + 80400 + 242000 + 633000);
            }
            if (income > 10310000 && income <= decimal.MaxValue)
            {
                Console.WriteLine(((income - 10310000) * 0.5m) + 27000 + 80400 + 242000 + 633000 + 2312000);
            }
        }
    }
}
