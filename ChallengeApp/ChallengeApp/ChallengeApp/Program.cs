// liczby calkowite

using System.ComponentModel.Design;

int myAge = 40;
int newAge = myAge + 5;

int myVar = int.MaxValue;
uint myVar2 = uint.MaxValue;
long muVar3 = long.MaxValue;

//liczby zmienno przecinkowe

float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;

//zmienno tekstowe 
string name = "Waclaw";
string surname = "Skaza";
string result = name + surname + myAge;
//Console.WriteLine(result);
char myVar5 = 'c';
var result2 = name.ToArray();

//zmienna logiczna

bool isAktive = true;
isAktive = false;
var isValid = 5 > 6;

//Console.WriteLine(isValid);




var number1 = 50;
var number2 = 10;
if (number1 < number2)
{
    //Console.WriteLine("JESTEM TUTAJ W LINI NR 34");
}
else
{

    // Console.WriteLine("jestem tutaj w lini nr 43");
}

// Operatory Relacyjne 
//== rowna sie 
//!= czy sa rozne 
//< wieksza liczba 
//> mniejsza liczba
//< = lub rowne 
//> = lub rowne 

//Operatory logiczne 
// && i 
// || lub 
//(!(...) negacja sprawdzanie czy nie jest mniejszy niz....

var name4 = "Waclaw ";
var age = 40;

if (name4 == "Waclaw" && age < 50)

{
    if (name4 == "Waclaw")
    {
        Console.WriteLine("tak ma na inie Waclaw");
    }else







    Console.WriteLine("Jestem Waclawem lub mam niej niz 50 lat.");
}

else if (age > 39)
{
    Console.WriteLine("Jestem w innym wieku  ");
}
