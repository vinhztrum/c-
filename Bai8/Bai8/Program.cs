// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pham Tran Thanh Vinh");
Console.WriteLine("Mssv:2415053122248");
string chuoi=Console.ReadLine();

if (chuoi == null)
    return;


string[] words = chuoi.Split(' ', StringSplitOptions.RemoveEmptyEntries);
if (words.Length == 0)
    return;

string longest = words[0];

for (int i = 1; i < words.Length; i++)
{
    if (words[i].Length > longest.Length)
        longest = words[i];
}
Console.WriteLine("Tu dai nhanh la " + longest);