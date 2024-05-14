using System.Collections;
using System.Net.Quic;


//Initial starting state

var gameStack = new TurboLinkedStack<GameState>();
gameStack.Push(GameState.MainMenu);

while (true)
{
    //Check and assign current state with Peek()
    var currentState = gameStack.Peek();

    // Display
    Console.WriteLine($"Current State: {currentState}");
    PrintOut(currentState);

    //User choice
    Console.Write("\n<<<");
    char input = Console.ReadKey().KeyChar;
    Console.WriteLine();
    // Handle user input
    InputHandle(input, currentState);
}

void InputHandle(char input, GameState gameState)
{
    switch (input, gameState)
    {
        //Main Menu input
        case ('0', GameState.MainMenu): //Go to Level 1
            gameStack.Push(GameState.Level1); 
            break;
        case ('1', GameState.MainMenu): //Go to Setting, can not do anything from there
            gameStack.Push(GameState.Setting);
            break;
        case ('q', GameState.MainMenu): //End program
            Environment.Exit(0);
            break;
        //Level 1 input
        case ('0', GameState.Level1): //Go to level 2
            gameStack.Push(GameState.Level2);
            break;
        case ('1', GameState.Level1): //Go imminently to Main Menu
            gameStack.Clear();
            gameStack.Push(GameState.MainMenu);
            break;
        case ('b', GameState.Level1): //Go back one stack
            StepBack();
            break;
        //Level 2 input
        case ('0', GameState.Level2): //Go to level 2
            gameStack.Push(GameState.Level3);
            break;
        case ('1', GameState.Level2): //Go imminently to Main Menu
            gameStack.Clear();
            gameStack.Push(GameState.MainMenu);
            break;
        case ('b', GameState.Level2): //Go back one stack
            StepBack();
            break;
        //Level 3 input
        case ('0', GameState.Level3): //Go to level 2
            gameStack.Push(GameState.Level3);
            break;
        case ('1', GameState.Level3): //Go imminently to Main Menu
            gameStack.Clear();
            gameStack.Push(GameState.MainMenu);
            break;
        case ('b', GameState.Level3): //Go back one stack
            StepBack();
            break;
    }
}

void StepBack() //Error handling when using Pop() //TODO not working correctly
{
    if (gameStack.Count > 0)
    {
        gameStack.Push(gameStack.Pop());
    }
    else
    {
        Console.WriteLine("\nCannot step back!");
    }
}


static void PrintOut(GameState state)
{
    Console.WriteLine("What do you want to do?");
    switch (state)
    {
        case GameState.MainMenu:
            Console.WriteLine("(0): Go to level 1\n(1): Go to Settings\n(q): Quit\n");
            break;
        case GameState.Setting:
            Console.WriteLine("Cannot go anywhere from Settings");
            break;
        case GameState.Level1:
            Console.WriteLine("(0): Go to level 2\n(1): Go to Main Menu\n(b): Back...\n");
            break;
        case GameState.Level2:
            Console.WriteLine("(0): Go to level 3\n(1): Go to Main Menu\n(b): Back...\n");
            break;
        case GameState.Level3:
            Console.WriteLine("(0): Go to level 4\n(1): Go to Main Menu\n(b): Back...\n");
            break;
    }
}



enum GameState
{
    MainMenu,
    Setting,
    Level1,
    Level2,
    Level3
}