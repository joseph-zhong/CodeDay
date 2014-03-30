using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _2013
{
    class Program
    {
        
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: permute.exe <str>");
                return;
            }
            /* RECURSIVE SIGMA
            Console.WriteLine(Sigma(5).ToString());
            //Console.Write(Sigma(1000).ToString());
            Console.WriteLine(Sigma(1000).ToString());
            Console.WriteLine(Sigma(10000).ToString());
            //Console.WriteLine(Sigma(100000).ToString());
            */
            /************* FOR LOOP SIGMA
            Console.WriteLine(SigmaLoop(5).ToString());
            DateTime start = DateTime.Now;
            Int64 [] N = {1000000, 2000000, 4000000};
            for (int i = 0; i < N.Length; i++)
            {
                Int64 s1 = SigmaLoop(N[i]);
                DateTime end = DateTime.Now;
                Console.WriteLine("{0} ms to compute Sigma({1})={2}", (end - start).Milliseconds, N[i], s1);
            }
             * 
             * */


            //------------- permutations-------------
            printList(permutations(args[0]));
            //Console.Write(remove('b', "abc"));
            /*
            List<string> l = new List<string>()
            {
                "ac", "ca" 
            };
            Console.Write(combine('b', l));
             * */
            //Console.Write(permutations("a").ToString());
            //Console.Write(permutations("ab"));
            //Console.Write(permutations("abc"));
        }

        static void printList(List<String> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i] + " ");
            }
        }

        static List<String> permutations(String str)
        {
            List<String> ret = new List<String>();
            if (str.Length == 1)
            {
                ret.Add(str);
            }
            else
            {
                foreach (char c in str)
                {
                    ret.AddRange(combine(c, permutations(remove(c, str))));                
                }
            }
            return ret;   
        }

        static List<String> combine(char c, List<String> p)
        {
            List<String> r = new List<String>();
            foreach (String str in p) // bc cb -> abc acb
            {
                String temp = c + str;
                r.Add(temp);
            }
            return r;
        }

        static String remove(char c, String str)
        {
            String s = str;
            s = s.Remove(s.IndexOf(c), 1);

            return s;
        }

        static Int64 SigmaLoop(Int64 n)
        {
            Int64 ans = 0;
            for (Int64 i = 0; i <= n; i++)
            {
                ans += i;
            }
            return ans;
        }

        static int Sigma(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Sigma(n - 1) + n;
            }
        }
    }
}
