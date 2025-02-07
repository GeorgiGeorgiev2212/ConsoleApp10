// type variable || void



//int sum = Add(5, 6);
//int secondSum = Add(33, 7);


//PrintSum(secondSum);

string f = Console.ReadLine();
string l = Console.ReadLine();





   Console.WriteLine (Combine(f, l));
   Console.WriteLine(Combine("Today is",  "Tuesday"));

void PrintSum(int x)
{
    ;

    Console.WriteLine($"Sum is =  {x}");

}

 int Add(int first, int second)
 {


    return first + second;


 }


string Combine(string first, string second)
{ 
    string combinedString = first + second;
    return combinedString;

}