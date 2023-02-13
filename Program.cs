namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int num1, num2, temp;
                Console.WriteLine("Enter the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Before swapping: ");
                Console.WriteLine("num1 = " + num1);
                Console.WriteLine("num2 = " + num2);
                temp = num1;
                num1 = num2;
                num2 = temp;
                Console.WriteLine("After swapping: ");
                Console.WriteLine("num1 = " + num1);
                Console.WriteLine("num2 = " + num2);
                Console.ReadLine();
           
        }
    }

}
    
