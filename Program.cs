
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
    Console.WriteLine("Would you like to try again?");
    Console.WriteLine("Type yes to try again or hit any key to exit");
    string? userInput = Console.ReadLine();
    userInput = userInput?.ToLower();

    if(userInput == "yes"){
        Console.WriteLine("Let's GOOOOOOOO!!!");
    }else{
        playAgain = false;
        Console.WriteLine("Maybe next time.");
    }

}
