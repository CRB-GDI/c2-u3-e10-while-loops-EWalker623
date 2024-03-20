namespace exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;

            while (choice != 4)
            { 
            //print menu
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options:");
            Console.WriteLine("4 - Quit:");
            Console.WriteLine("**************:");
            Console.WriteLine();

            //ask the user for a choice 
            Console.WriteLine("please choose a number from the menu (1,2,3,or 4) ");
            choice = int.Parse(Console.ReadLine());
                //Console.WriteLine(choice);

                //print message using if statements 
                if (choice == 1)
                {
                    Console.WriteLine("creating a new game");

                }



                else if (choice == 2)
                {
                    Console.WriteLine("loading game");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("here are your options");
                }
                else if (choice > 4 || choice < 1)
                {
                    Console.WriteLine("please type in 1, 2, 3, or 4");
                }


            }


            
          
        }
    }
}