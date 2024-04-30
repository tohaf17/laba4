using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra3
{
    internal class Zodiak
    {
        public List<(string, DateTime[])> Main()
        {
            List<(string, DateTime[])> Zodiaks = new List<(string, DateTime[])>();
            DateTime[] Aries = new DateTime[2] { new DateTime(2024, 3, 21), new DateTime(2024, 4, 19) };
            Zodiaks.Add(("Aries", Aries));
            DateTime[] Taurus = new DateTime[2] { new DateTime(2024, 4, 20), new DateTime(2024, 5, 20) };
            Zodiaks.Add(("Taurus", Taurus));
            DateTime[] Gemini = new DateTime[2] { new DateTime(2024, 5, 21), new DateTime(2024, 6, 21) };
            Zodiaks.Add(("Gemini", Gemini));
            DateTime[] Cancer = new DateTime[2] { new DateTime(2024, 6, 22), new DateTime(2024, 7, 22) };
            Zodiaks.Add(("Cancer", Cancer));
            DateTime[] Leo = new DateTime[2] { new DateTime(2024, 7, 23), new DateTime(2024, 8, 22) };
            Zodiaks.Add(("Leo", Leo));
            DateTime[] Virgo = new DateTime[2] { new DateTime(2024, 8, 23), new DateTime(2024, 9, 22) };
            Zodiaks.Add(("Virgo", Virgo));
            DateTime[] Libra = new DateTime[2] { new DateTime(2024, 9, 23), new DateTime(2024, 10, 23) };
            Zodiaks.Add(("Libra", Libra));
            DateTime[] Scorpius = new DateTime[2] { new DateTime(2024, 10, 24), new DateTime(2024, 11, 21) };
            Zodiaks.Add(("Scorpius", Scorpius));
            DateTime[] Sagittarius = new DateTime[2] { new DateTime(2024, 11, 22), new DateTime(2024, 12, 21) };
            Zodiaks.Add(("Sagittarius", Sagittarius));
            DateTime[] Capricornus = new DateTime[2] { new DateTime(2024, 12, 22), new DateTime(2024, 1, 19) };
            Zodiaks.Add(("Capricornus", Capricornus));
            DateTime[] Aquarius = new DateTime[2] { new DateTime(2024, 1, 20), new DateTime(2024, 2, 18) };
            Zodiaks.Add(("Aquarius", Aquarius));
            DateTime[] Pisces = new DateTime[2] { new DateTime(2024, 2, 19), new DateTime(2024, 3, 20) };
            Zodiaks.Add(("Pisces", Pisces));
            return Zodiaks;
        }

        
    }
    
}
