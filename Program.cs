// Declaring Constants
const string AppVersion = "1.0.0";

Console.WriteLine("==================================");
Console.WriteLine("           UMOJA HR SYSTEM        ");
Console.WriteLine("         Employee Management      ");
Console.WriteLine("==================================");

Console.WriteLine();
Console.WriteLine("Welcome to Umoja Software Technologies.");
Console.WriteLine();
Console.WriteLine("System Status: Online");
Console.WriteLine($"Version: {AppVersion}");

// Selected Option configuration
bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("---------------Main Menu-----------");

    Console.WriteLine("1. Register Employee");
    Console.WriteLine("2. View All Employees");
    Console.WriteLine("3. Search Employee");
    Console.WriteLine("4. Calculate Payroll");
    Console.WriteLine("5. Exit");

    Console.WriteLine("------------------------------------");

    // Choose between options using switch and case.
    Console.Write("Select an option: ");
    string? selectedOption = Console.ReadLine();

    switch (selectedOption)
    {
        case "1":
            Console.WriteLine("Register employee selected.");
            break;

        case "2":
            Console.WriteLine("View All employees selected.");
            break;

        case "3":
            Console.WriteLine("Search employee selected.");
            break;

        case "4":
            Console.WriteLine("Calculate payroll selected.");
            break;

        case "5":
            Console.WriteLine("Thank You for using UmojaHR.");
            isRunning = false;
            break;

        default:
            Console.WriteLine("Invalid option. Enter a valid number.");
            break;

    } // End of while Loop
}

//












