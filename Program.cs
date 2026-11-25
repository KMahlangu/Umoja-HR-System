// Declaring Constants
const string AppVersion = "1.0.0";

// Method to deplay Welcome message
DisplayWelcome();

Console.WriteLine();
Console.WriteLine("Welcome to Umoja Software Technologies.");
Console.WriteLine();
Console.WriteLine("System Status: Online");
Console.WriteLine($"Version: {AppVersion}");

// Selected Option configuration
bool isRunning = true;

while (isRunning)
{
    DisplayMenu();

    // Choose between options using switch and case.
    Console.Write("Select an option: ");
    string? selectedOption = Console.ReadLine();

    switch (selectedOption)
    {
        case "1":
            RegisterEmployee();
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

// Methods

static void DisplayWelcome()
{
    Console.WriteLine("==================================");
    Console.WriteLine("           UMOJA HR SYSTEM        ");
    Console.WriteLine("         Employee Management      ");
    Console.WriteLine("==================================");
}

static void DisplayMenu()
{
    Console.WriteLine("---------------Main Menu-----------");

    Console.WriteLine("1. Register Employee");
    Console.WriteLine("2. View All Employees");
    Console.WriteLine("3. Search Employee");
    Console.WriteLine("4. Calculate Payroll");
    Console.WriteLine("5. Exit");

    Console.WriteLine("------------------------------------");
}

static void RegisterEmployee()
{
    Console.WriteLine("==================================");
    Console.WriteLine("      EMPLOYEE REGISTRATION");
    Console.WriteLine("==================================");

    // TODO: Capture employee number.
    Console.WriteLine("Enter employee number: ");
    string? empNumber = Console.ReadLine();
    // TODO: Capture first name.
    Console.WriteLine("Enter employee first name: ");
    string? firstName = Console.ReadLine();

    // TODO: Capture last name.
    Console.WriteLine("Enter employee last name: ");
    string? empLastName = Console.ReadLine();

    // TODO: Capture age.
    Console.Write("Enter your age: ");
    string? age = Console.ReadLine();
    
    if (!int.TryParse(age, out int empAge) || empAge <= 0)
    {
        Console.WriteLine("Invalid age");
        return;
        
    }

    // TODO: Capture department.
    Console.WriteLine("Enter department");
    string? empDepart = Console.ReadLine();


    // TODO: Capture basic salary.
    Console.WriteLine("Enter employee basci salary: ");
    string? salary = Console.ReadLine();

    if (!decimal.TryParse(salary, out decimal basicSal) || basicSal <= 0 )
    {
        Console.WriteLine("Invalid amount.Please enter a positive amount");
        return ;
    }

    // TODO: Display employee information.
    Console.WriteLine("====================================");
    Console.WriteLine("         EMPLOYEE INFORMATION       ");
    Console.WriteLine("====================================");
    Console.WriteLine();

    Console.WriteLine($"Employee Number: {empNumber}");
    Console.WriteLine($"First Name: {firstName}");
    Console.WriteLine($"Last Name: {empLastName}");
    Console.WriteLine($"Age: {empAge}");
    Console.WriteLine($"Department: {empDepart}");
    Console.WriteLine($"Basic Salary: R{basicSal:F2}");

    Console.WriteLine("Employee details captured successfully!");
    Console.WriteLine("Returning to main menu...");

}



    



    

    










