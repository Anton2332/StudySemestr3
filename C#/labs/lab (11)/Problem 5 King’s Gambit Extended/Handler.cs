using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_5_King_s_Gambit_Extended;

namespace Problem_2_King_s_Gambit
{
    internal static class Handler
    {
        
        public static void KingEvent(object sender, NameEventArgs args)
        {
            Console.WriteLine("King " + args.Name + " is under attack!");
        }

        public static void RoyalGuardEvent(object sender, NameEventArgs args)
        {
            Console.WriteLine("Royal Guard " + args.Name + " is defending!");
        }

        public static void FootmanEvent(object sender, NameEventArgs args)
        {
            Console.WriteLine("Footman " + args.Name + " is panicking!");
        }

        public static bool HitsEvent(object sender, HitsEventArgs args)
        {
            if (args.Hits <= 0)
                return true;
            else
                return false;
        }
    }
    
}
