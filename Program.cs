Console.WriteLine("The following items are avaliable: \n 1 - Rope \r \n 2 - Torches \r \n 3 - Climbing Equipment \r \n 4 - Clean Water \r \n 5 - Machete \r \n 6 - Canoe \r \n 7 - Food Supplies \r");
Console.Write("What number do you want to see the price of? ");
string response;

int choice = Convert.ToInt32(Console.ReadLine()); // i think they guy who made the book didnot declare that? im just a dumbass probably lol

response = choice switch
{ 
    1 => "10 gold",
    2 => "20 gold",
    3 => "25 gold",
    4 => "1 gold",
    5 => "20 gold",
    6 => "200 gold",
    7 => "1 gold",
    _ => "i dunno what that is"
};

Console.WriteLine(response);