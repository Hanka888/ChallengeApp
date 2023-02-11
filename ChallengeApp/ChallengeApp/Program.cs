// dzień 4 zadanie domowe 
var name = "Ewa";
var age = 24;
bool female = true;

if (female && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa/ lat 33");
}
else if (!female && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (female && age > 30)
{
    Console.WriteLine("Kobieta powyżej 30 lat");
}
else
{
    Console.WriteLine("Inna osoba");
}

