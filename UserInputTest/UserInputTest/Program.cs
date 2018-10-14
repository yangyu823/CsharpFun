using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputTest
{


    public class TextInput
    {
        public IList<char> list = new List<char>();

        public virtual void Add(char c)
        {
            list.Add(c);
        }

        public string GetValue()
        {
            string r = "";
            foreach (char l in list)
            {
                r = r + l;
            }
            return r;
        }
    }
    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if (c < '0' || c > '9')
            {
                return;
            }
            else
                list.Add(c);
        }
    }

        public class UserInput
    {
        public static void Main(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('8');
            Console.WriteLine(input.GetValue());
            Console.ReadKey();
        }
    }


}
