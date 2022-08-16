using System;//base class library--- parent


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0,j=0,k=0,userchoice;
            char ch='+';
            Console.WriteLine("Menu \n 1.Add \n 2.Subtract \n 3.Exit");
            userchoice = Convert.ToInt32(Console.ReadLine());
            if (userchoice!=3)
            {
                Console.WriteLine("Enter value for i");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value for j");
                j = Convert.ToInt32(Console.ReadLine());
            }
            
            switch (userchoice)
            {
                case 1:
                    ch = '+';
                    k = i + j;
                    break;
                case 2:
                    ch = '-';
                    k = i - j;
                    break;
                case 3:
                    Environment.Exit(1);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
            Console.WriteLine("The answer of {0} {1} {2}={3}",i,ch,j,k);

            Console.ReadLine();//Read()/ ReadKey()
            //comment


        }
    }
}
