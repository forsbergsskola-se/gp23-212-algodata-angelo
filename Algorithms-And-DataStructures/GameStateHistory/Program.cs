using System.Collections;



var currentGameState = new TurboLinkedStack<GameState>();

while (true)
{
    Console.WriteLine($"You are here: {currentGameState}\n" +
                      $"What do you want to do?\n" +
                      $"(0): Go to Level 1\n" +
                      $"(1): Go to Settings\n" +
                      $"(2): Go Back" +
                      $"(Q): Quit");
}


enum GameState
{
    MainMenu,
    Setting,
    Quit,
    Level1,
    Level2,
    Level3
}