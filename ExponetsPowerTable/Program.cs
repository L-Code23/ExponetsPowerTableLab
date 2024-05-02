//---------------------------------------------Exponets Power Table----------------------------------------------------------------------------

internal class Program
{
    private static void Main(string[] args)
    {
        double number = 0;

        //Table
        string goAgain;

        Console.WriteLine("Learn your squares and cubes!");
        while (true)
        {
       
        Console.WriteLine("Enter a positive integer");
        number = double.Parse(Console.ReadLine());
            if (number > 0)
            {

                Console.WriteLine("Number    \tSquared \t  Cubed"); //moved outside of for loop 
                Console.WriteLine($"=======  \t======= \t  =======");
                {

            
                for (double i = 1; i <= number; i++)
            {

                

                Console.WriteLine($"{i}     \t        {SecondPower(i)}\t          {ThirdPower(i)}");

                }
                
            }
            
                Console.WriteLine("Would you like to run the program again?Enter y/n.");//run program again?
                goAgain = Console.ReadLine();
                if (goAgain == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid integer.");//validation
                continue;
            }

            /*To align string to the right or to the left use static method String.Format. To align string to the left
             * (spaces on the right) use the formatting patern with comma(,) followed by a negative number of charecters
             * String.Format("{0,-10}, text) to right align use a positive number*/


            //Methods
            //static int Adder(int x, int y) reference
            //{
            //  return x + y;
            static double SecondPower(double x)
            {
                return x * x;
            }

            static double ThirdPower(double y)
            {
                return y * y * y;
            }
        }
    }
}