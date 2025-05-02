ConsoleKeyInfo input;
int selectionNum = 3;
var rand = new Random();
int score = 0;

do
{
    //show user values(with one missing)
    int correctInput = rand.Next(1, 4);
    for (int i = 1; i <= selectionNum; i++) {
        if (i != correctInput) {
            Console.Write(i.ToString());
        }
        Console.Write("\t");
    }
    
    Console.WriteLine();

    //get user input
    input = Console.ReadKey();
    Console.WriteLine(input.KeyChar);

    //if user input is correct then go next
    if (input.KeyChar.ToString() == correctInput.ToString()) {
        Console.Clear();
        score++;
    }
    //if incorrect end and show score
    else {
        Console.Clear();
        Console.Write($"You Lose!\n\nYour score: {score}");
        break;
    }

    



    
} while (input.Key != ConsoleKey.Escape);
    