// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pham Tran Thanh Vinh");
Console.WriteLine("Mssv:2415053122248");
Console.Write("Nhap ho ten: ");
string fullName = Console.ReadLine();


if (fullName == null)
    return;
    

string[] words = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);


if (words == null)
    return;

foreach (string w in words)
{
    Console.WriteLine(w);
}

