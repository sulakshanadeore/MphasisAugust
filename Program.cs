using System;//base class library--- parent


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=10;
            Int32 j=20;
            int k = i + j;
            Console.WriteLine(k);
            Console.WriteLine("--------------------------");
            Console.WriteLine("enter i for multiplication");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter j for multiplication");
            j = Convert.ToInt32(Console.ReadLine());
            k = i * j;

            Console.WriteLine("The multiplication of i and j=" +  k);
            Console.WriteLine("The multiplication of {0} and {1}={2}",i,j,k );
               

            Console.WriteLine("Hello");
            Console.Write(DateTime.Now);

            Console.ReadLine();//Read()/ ReadKey()
            //comment


        }
    }
}
