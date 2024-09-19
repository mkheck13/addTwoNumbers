
Console.Clear();
bool playAgain = true;
int num1;
int num2;

Console.WriteLine("We're going to add some number's today, so let's get started!");
while(playAgain){
    Console.WriteLine("Enter number 1");
    bool success = Int32.TryParse(Console.ReadLine(), out num1);

    while(true){
        if(!success){
            Console.WriteLine("That is not a number. Please enter a number.");
            success = int.TryParse(Console.ReadLine(), out num1);
        }else{
            Console.WriteLine($"Your first number is {num1}");
            break;
        }
    }
    Console.WriteLine("Enter number 2");
    bool success2 = Int32.TryParse(Console.ReadLine(), out num2);
    while(true){
        if(!success2){
            Console.WriteLine("That is not a number. Please enter a number.");
            success2 = int.TryParse(Console.ReadLine(), out num2);            
        }else{
            Console.WriteLine($"Your second number is {num2}");
            break;
        }
    }
    int sum = num1 + num2;
    Console.Clear();
    Console.WriteLine($"So {num1} plus {num2} equals {sum}");

    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("Type 'yes' to play again or 'no' to exit");

    bool yesNo = true;

    while (yesNo == true)
    {
        string userPlay = Console.ReadLine()!.Trim().ToLower();
        if (userPlay == "yes" || userPlay == "y")
        {
            Console.WriteLine("Let's go again!");
            yesNo = false;
        }
        else if (userPlay == "no" || userPlay == "n")
        {
            Console.WriteLine("See you next time.");
            yesNo = false;
            playAgain = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("That was not a yes or no. Try again.");
        }
    }
}
