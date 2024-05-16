// See https://aka.ms/new-console-template for more information
//rakendus kusib kasutajal valida tema sugu (m/f)
//rakendus kusib kasutajal sisestada tema perekonnanime
//lahtudes kasutaja valikust, rakendus tervitab kasutajalt jargmiselt:
//"Welcome Mr[kasutaja perekonnanimi]" /" Welcome, Ms [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender(m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid sone formaadis

Console.WriteLine("Please, enter your last name:");

string userLastName = Console.ReadLine();

if (userGender == 'm') 
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if (userGender =='f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome{userLastName}!");
}


