using System;

namespace my_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1
                char[] chars = { ' ' };
                String s = "Jeg henter en kage";
                 Console.WriteLine("Det første mellemrum i {0} er fundet i position {1}\n", 
                s, s.IndexOfAny(chars) + 1); 

            //Opgave 2
            string word = "Hej med dig, håber du har en god dag";
            if (word.Length > 0)
            {
            int i = word.IndexOf(" ")+1;
            string str=word.Substring(i);
            Console.Write(str);
            Console.Write("\n Der skulle så ¨Hej med dig, håber du har en god dag¨\n");
            }

            //Opgave 3
            int ord = 0;
            string x = "Hej Med dig Lotte";

            for (int i = 0; i < x.Length; i++)
             { 
            if (x[i] == ' ')
                {
                ord++;
                }
            }
            Console.WriteLine("\nDu har skrevet: " + ord + " antal Mellemrum i Hej med dig Lotte\n");

            //Opgave 4
            string word2 = "måske skal vi i biografen i aften";
            if (word2.Length > 0)
            {
            int i2 = word2.IndexOf("måske")+5;
            string str2=word2.Substring(i2);
            Console.Write(str2);
            Console.Write("\n Der skulle så ¨måske skal vi i biografen i aften¨\n");

            //opgave 5
            var replacement = new[]{
            new{Find="måske",Replace=""},

            new{Find="Måske",Replace=""},
            };

            var SkiftMoske = "\nJa jeg test om den skriver måske og Måske";
            foreach(var set in replacement)
            {
            SkiftMoske = SkiftMoske.Replace(set.Find, set.Replace);
            }
            Console.WriteLine(SkiftMoske);
            }
            
            //opgave 6
            string string1, rev;
            string1 = "vær dog god ræv";
            char[] ch = string1.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            
            bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true) {
            Console.WriteLine("\n" + string1 + " er en palindrom!");
            } else {
            Console.WriteLine("\n" + string1 + " er ikke en palindrom!");
            }

            // opgave 7
            //ehhhhhh
        }
    }
}
