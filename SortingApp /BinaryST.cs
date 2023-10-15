using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApp
{
    class BinaryST
    {
        public void MainBST(int[] arr)
        {
            var set = new SortedSet<int>(arr);

            Console.WriteLine("Binary Search Tree : {0}", string.Join(", ", set));
            
        }
    }


    class OtherString
    {
        public void MainString()
        {
            String1("thisIsVariable");
            String2("this_is_variable");
            String3("geeksforgeeks");
        }

        public void String1(string str)
        {
            Console.WriteLine("Raw String : {0}", str);
            StringBuilder s= new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == str[i].ToString().ToUpper())
                {
                    // s = str.Replace("", "");
                    s.Append(" " + str[i].ToString().ToLower());
                }
                else
                {
                    s.Append(str[i].ToString());
                }
                
            }
            

            Console.WriteLine("Remove cap and add space String : {0}", s);
        }


        public void String2(string str)
        {
            Console.WriteLine("Raw String : {0}", str);

            str = str.Replace("_", " ");
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && (i+1) < str.Length)
                {
                    str = str.Replace(" "+ str[i+1], " "+ str[i + 1].ToString().ToUpper());
                }

            }

            Console.WriteLine("Remove underscore and add space with cap String : {0}", str);
        }

        public void String3(string str)
        {
            Console.WriteLine("Raw String : {0}", str);
            Dictionary<char, int> dr = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (dr.ContainsKey(str[i]))
                {
                    dr[str[i]]++;
                }
                else
                {
                    dr[str[i]] = 1;
                }
            }

            Console.WriteLine("get number of chars in String : {0}", string.Join(" ", dr).Replace("[","").Replace("]", "").Replace(", ", ""));
        }

    }
}
