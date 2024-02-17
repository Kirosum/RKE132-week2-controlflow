// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajal sisestada tema vanuse
//Kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
// "You are too young to use instagram"
//muul juhul 
//Konsoolis kuvatkase "Welcome to instagram"

Console.WriteLine("Enter your age");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {userAgeNum}. User is {userAgeNum} years old.");

if (isAgeNumber == true)
{
    if (userAgeNum >=13)
    {
        Console.WriteLine("welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("you are too young to use Instagram.");
    }   
}
else
{
    Console.WriteLine("Could not read your age.");                                                                                                         
}