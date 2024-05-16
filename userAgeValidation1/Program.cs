// rakendus kusib kasutajal sisestada tema vanuse
//kui kasutaja vanus on vaiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use this app"
// muul juhul
//konsoolis kuvatakse "Welcome to the app"

Console.WriteLine("Enter youe age:");


string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false


bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{

    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to the app");
    }


    else
    {
        Console.WriteLine("You are too young to use app");
    }
}

else
{
    Console.WriteLine("Could not read your age.");
}
