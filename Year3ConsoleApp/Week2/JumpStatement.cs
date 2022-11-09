namespace MainApp.Week2
{
    public class JumpStatement
    {
        public static void SwitchCase()
        {
            Console.WriteLine("Press 1 for Apple");
            Console.WriteLine("Press 2 for Orange");

            var a = Console.ReadLine(); //get input from user

            switch (a)
            {
                case "1":
                    Console.WriteLine("Apple");
                    break;

                case "2":
                    Console.WriteLine("Orange");
                    break;

                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }

        public static void IfElse(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than  {num2}");
                goto Apple;
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} is less than  {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} equals to  {num2}");
            }

        Apple: Console.WriteLine("Apple Apple");
        }








    }
}