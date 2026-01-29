// See https://aka.ms/new-console-template for more information
Console.Write("Nhap chuoi: ");
string str = Console.ReadLine();

if (str == null)
{
    Console.WriteLine("Chuoi khong đoi xung");
    return;
}

// Xóa khoảng trắng
string s = "";
for (int i = 0; i < str.Length; i++)
{
    if (str[i] != ' ')
    {
        s += char.ToLower(str[i]);
    }
}

bool doiXung = true;
int left = 0;
int right = s.Length - 1;

while (left < right)
{
    if (s[left] != s[right])
    {
        doiXung = false;
        break;
    }
    left++;
    right--;
}

if (doiXung)
    Console.WriteLine("Chuoi doi xung");
else
    Console.WriteLine("Chuoi khong đoi xung");
    
