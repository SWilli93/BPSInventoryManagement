// See https://aka.ms/new-console-template for more information
using BPSInventoryManagement;


PrintWelcome();

Utilities.InitializeStock();

Utilities.ShowMainMenu();

Console.WriteLine("Application shutting down...");

Console.ReadLine();

#region Layout

static void PrintWelcome()
{

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(@"
    ()()()()()()   ____     _____      _____                                         
    |\         |  |  _ \   |  __  \   / ____|                                                                                     ()()()()()()
    |.\. . . . |  | |_) |  | |__) |  | (___                                                                                        |\         |
    \'.\       |  |  _ <   |  ___/    \___ \                                                                                       |.\. . . . |
     \.:\ . . .|  | |_) |  | |        ____) |                                                                                      \'.\       |
      \'o\     |  |____/_  |_|       |_____/  _                     __  __                                                   _      \.:\ . . .|
       \.'\. . |  |_   _|                    | |                   |  \/  |                                                 | |      \'o\     |
        \'.\   |    | |  _ ____   _____ _ __ | |_ __|___ __ _   _  | \  / | __ _ _ __   __ _  __ _  _ _ _ __ ___   ___ _ __ | |_      \.'\. . |
         \'`\ .|    | | | '_ \ \ / / _ \ '_ \| __/ _ \| '__| | | | | |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '_ ` _ \ / _ \ '_ \| __|      \'.\   |
          \.'\ |   _| |_| | | \ V /  __/ | | | || (_) | |  | |_| | | |  | | (_| | | | | (_| | (_| |  __/ | | | | |  __/ | | | |_        \'`\ .|
           \__\|  |_____|_| |_|\_/ \___|_| |_|\__\___/|_|   \__, | |_|  |_|\__,_|_| |_|\__,_|\__, |\___|_| |_| |_|\___|_| |_|\__|        \.'\ |
                                                             __/ |                            __/ |                                       \__\|
                                                            |___/                            |___/                               
    ");

    Console.ResetColor();

    Console.WriteLine("Press enter key to start logging in!");

    //accepting enter here
    Console.ReadLine();

    Console.Clear();
}
#endregion