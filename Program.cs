using System.Globalization;

namespace IEnumeralble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stk = new Stack<int>();
            
            for(int i =0; i< 10; i++)
            {
                stk.Push(i);
            }

            foreach (int i in stk)
            {
                Console.WriteLine(i);
            }
        }
    }
}