// variables
var today = DateTime.Today;

//start
Console.WriteLine("Hello, Who are you?");
//pick your name
string? pickName = "";
//check if name is empty or null, if empty or null use readline to get input from user
if (string.IsNullOrEmpty(pickName))
{ 
    pickName = Console.ReadLine();
}
// if the pickname variable is not null we go further
if (pickName is not  null)
{//specific names and their rules
    if (pickName.Contains("Glenn") || pickName.Contains("glenn"))
    {
        Console.WriteLine("hi " + pickName + "! Welcome back master, how are you feeling?");
        pickName = "Master";
    }
    else if (pickName.Contains("Sicco")|| pickName.Contains("sicco")|| pickName.Contains("Tim")|| pickName.Contains("tim"))
    {
        Console.WriteLine(pickName + "! You have no power here!!!");
        for (int i = 0; i < 5; i++)
        { 
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("GET OUT! THERE IS NO CODE HERE! RUN WHILE YOU STILL CAN!");
        }
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Your eyes deceived you, everything works fine here!, CIAOKES BYKES!");
        System.Threading.Thread.Sleep(1000);
        return;
    }
    else if (pickName.Contains("Ian")|| pickName.Contains("ian"))
    {
        Console.WriteLine("So " + pickName + " You decided to enter this place again...");
        Console.WriteLine("You shall not leave this place alive!");
        for (int i = 0; i < 5; i++)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Minions Attack");
        }
        System.Threading.Thread.Sleep(5000);
        Console.WriteLine("Sorry program has a bug! Come back later if you dare!!!");
        return;
    }
    else
    {
        Console.WriteLine("Hi " + pickName + "! How are you feeling today my good servant?");
    }

}


string? pickMood = "";

if (string.IsNullOrEmpty(pickMood) && pickMood is not null)
{
    pickMood = Console.ReadLine();
}

if (pickMood is not null && pickName is not null)
{
    if (pickName.Contains("Master"))
        {
            if (pickMood.Contains("good") || pickMood.Contains("great") || pickMood.Contains("happy"))
            {
                Console.WriteLine(" Glad to hear you feel " + pickMood + " " + pickName + "!!");
            }
            else
            {
                Console.WriteLine("sorry to hear you feel " + pickMood + " " + pickName);
            }
        }
        else
        {
            if (pickMood.Contains("good") || pickMood.Contains("great") || pickMood.Contains("happy"))
            {
                Console.WriteLine("Sorry to hear you feel " + pickMood + "! I like it when my servants are miserable!");
            }
            else
            {
                Console.WriteLine("how about we make you feel worse! HAHAHAA :D");
            }
        }
    }



Console.WriteLine(pickName + ". When where you born?");


var birthday = Console.ReadLine();
DateTime dob = Convert.ToDateTime(birthday);

var age = today.Year - dob.Year;
// if statement to check for leap year
if (dob.Date > today.AddYears(-age)) age--;

if (age > 30)
{
    Console.WriteLine("So you are " + age + " years old! Jeez grampa...");
}
else
{
    Console.WriteLine("So you are " + age + " Years old! Right out of the diapers, I see...");
}







