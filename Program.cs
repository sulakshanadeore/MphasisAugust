using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 10;
            ans += 10;
            Console.WriteLine(ans);//20
            ans *= 2;
            //== comparision
            //= assign
            ans = 10 % 3; //(mod)
            //ans=1

            //int no = 6666;
            //string myname = no.ToString();
            //string s=myname.ToString();
            //Console.WriteLine(s);
            //string newstr=string.Empty;
            //s=newstr.ToString();
            //Console.WriteLine(s);

            //#region AllAboutObjectClass
            ////Everything inherits from object, all types will have these methods
            ////in common

            //int i = 100;
            //Type t1 = i.GetType();
            //Console.WriteLine(t1.Name);
            //Console.WriteLine(t1.FullName);
            //Console.WriteLine("----------");
            //t1 = t1.BaseType;
            //Console.WriteLine(t1.Name);
            //Console.WriteLine(t1.FullName);
            //Console.WriteLine(t1.Namespace);
            //Console.WriteLine("--------------For string type--------");
            //string s1 = "Greetings";
            //t1 = s1.GetType();
            //Console.WriteLine(t1.Name);
            //Console.WriteLine(t1.FullName);
            //t1 = t1.BaseType;
            //Console.WriteLine(t1.Name);
            //Console.WriteLine(t1.FullName);
            //Console.WriteLine(t1.Namespace);
            //Console.WriteLine("--------------Working with Object Class------");
            //object obj = new object();
            //t1 = obj.GetType();
            //Console.WriteLine(t1.Name);
            //Console.WriteLine(t1.FullName);
            //Console.WriteLine(t1.Namespace);
            //Console.WriteLine("=======************========********========");

            //int num1 = 100;

            //double num3 = 100.0d;
            //object num2 = 100.0;
            //bool ans = num3.Equals(num2);
            //Console.WriteLine(ans);

            //Console.WriteLine("--------*****To string()********----------------");
            //int value1 = 444;
            //string str = value1.ToString();
            //string s3 = value1.ToString();
            //string s2 = "444";

            ////ans=str.Equals(value1);
            //ans = s3.Equals(s2);

            //Console.WriteLine(ans);

            //#endregion
            Console.ReadLine();
            
            

        }

        
    }
}
