// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pham Tran Thanh Vinh");

Console.WriteLine("Mssv:2415053122248");
Console.WriteLine("Nhap n: ");

int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"So phan tu thu [{i+1}] =");
    arr[i] = int.Parse(Console.ReadLine());
} 
if (arr == null)
    return ;

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
        count++;
}
Console.WriteLine("so phan tu chan " + count);
