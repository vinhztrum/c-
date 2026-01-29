// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pham Tran Thanh Vinh");
Console.WriteLine("Mssv:2415053122248");
Console.Write("Nhap n: ");
int n = int.Parse(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("Mang rong");
    return;
}

int[] a = new int[n];


for (int i = 0; i < n; i++)
{
    Console.Write($"Phan tu thu [{i + 1}] = ");
    a[i] = int.Parse(Console.ReadLine());
}

int max = a[0];
for (int i = 1; i < a.Length; i++)
{
    if (a[i] > max)
        max = a[i];
}

Console.WriteLine("Gia tri lon nhat: " + max);