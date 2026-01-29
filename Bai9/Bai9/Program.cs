Console.WriteLine("Pham Tran Thanh Vinh");
Console.WriteLine("Mssv:2415053122248");

string[] chuoi = new string[5];

for (int i = 0; i < chuoi.Length; i++)
{
    Console.Write($"chuoi[{i + 1}] = ");
    chuoi[i] = Console.ReadLine();
}

int count = 0;

for (int i = 0; i < chuoi.Length; i++)
{
    if (!string.IsNullOrEmpty(chuoi[i]))
    {
        count++;
    }
}

Console.WriteLine("So phan tu khac null va khac rong la: " + count);
