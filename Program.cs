Console.WriteLine("Gebe Eine Zahl ein:");
var input = Console.ReadLine();
// int index = int.Parse(input);
//int input;
/*var index = int.TryParse(Console.ReadLine(), out int input);
Console.WriteLine(input);
 Selbst*/

bool error = int.TryParse(input, out int index);

if (!error)
{
    Console.WriteLine(error);
}
else
{
    Console.WriteLine(index);
}

int getIndex(string promt)
{
    Console.WriteLine("Gebe die Aufgabe ein, DirectoryNotFoundException du bearbeiten willst:");
    var input = Console.ReadLine();
    var number = int.Parse(input);
    return number;
}

List<string> todos = new();

todos.Add("Wäsche waschen");
todos.Add("Bügeln");

//int index = getIndex("Gebe die Aufgabe ein, die du bearbeiten willst")
