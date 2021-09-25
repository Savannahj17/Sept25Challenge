using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept25Challenge
{
    class Sept25Challenge
    {
        static void Main(string[] args)
        {
            List<char> super = new List<char>();
            super.Add('s');
            super.Add('u');
            super.Add('P');
            super.Add('e');
            super.Add('r');
            super.Add('c');
            super.Add('a');
            super.Add('l');
            super.Add('i');
            super.Add('f');
            super.Add('r');
            super.Add('a');
            super.Add('g');
            super.Add('i');
            super.Add('l');
            super.Add('i');
            super.Add('s');
            super.Add('t');
            super.Add('i');
            super.Add('c');
            super.Add('e');
            super.Add('x');
            super.Add('p');
            super.Add('i');
            super.Add('a');
            super.Add('l');
            super.Add('i');
            super.Add('d');
            super.Add('o');
            super.Add('c');
            super.Add('i');
            super.Add('o');
            super.Add('u');
            super.Add('s');
            foreach(char x in super)
            {
                if (x != 'i')
                {
                    Console.WriteLine("Not an I");
                }
                else
                {
                    Console.WriteLine(x);
                }

            }

            {
                string a = "supercalifragilisticexpialidocious";
                int b = a.Length;
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }

       
    }
}
