// See https://aka.ms/new-console-template for more information
Console.Write("Nhap chuoi: ");
string str = Console.ReadLine();

if (str == null)
{
    Console.WriteLine("So tu: 0");
    return;
}

str = str.Trim();

if (str == "")
{
    Console.WriteLine("So tu: 0");
    return;
}

string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int count = words.Length;

Console.WriteLine("So tu trong chuoi: " + count);
    
