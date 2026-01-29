// See https://aka.ms/new-console-template for more information\
Console.WriteLine("Pham Tran Thanh Vinh");
Console.WriteLine("Mssv:2415053122248");

Console.Write("Nhap so phan tu n: ");
int n = int.Parse(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("So phan tu khong hop le");
    return;
}

int[] arr = new int[n];

for (int i = 0; i < n; i++) 
{
    Console.Write($"Phan tu thu[{i+1}] = ");
    arr[i] = int.Parse(Console.ReadLine());
}

if (arr == null)
{
    Console.WriteLine("Mang chua duoc khoi tao");
    return;
}

int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}

Console.WriteLine("Tong cac phan tu = " + sum);