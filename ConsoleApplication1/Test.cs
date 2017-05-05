using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Test
    {
        public void s()
        {
            string c = string.Empty;
            Console.WriteLine("Please input A ！");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input B ！");
            int b = Convert.ToInt32(Console.ReadLine());
            c = S(a, b);
            while (string.IsNullOrWhiteSpace(c) == false)
            {
                Console.WriteLine("Please input " + c + " again！");
                Console.WriteLine("Please input A ！");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input B ！");
                b = Convert.ToInt32(Console.ReadLine());
                c = S(a, b);
            }
            Console.WriteLine("OK~,A={0},B={1}",a,b);
            Console.ReadLine();
        }

        private string S(int a, int b)
        {
            var c = string.Empty;
            c += Comp("A", a);
            c += Comp("B", b);
            return c.Trim(',');
        }
        private string Comp(string name, int a)
        {
            return a > 10 ? name + "," : "";
        }
        public string Message(Dictionary<string, int> numbers)
        {
            string result = string.Empty;
            foreach (var number in numbers)
            {
                if (number.Value > 10)
                {
                    result += number.Key + ",";
                }
            }
            return result.Trim(',');
        }
    }
}
