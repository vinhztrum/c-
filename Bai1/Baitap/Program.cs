// See https://aka.ms/new-console-template for more information
Console.Write("Nhap ho ten: ");
string hoTen = Console.ReadLine();

if (string.IsNullOrWhiteSpace(hoTen))
{
    Console.WriteLine("chuoi rong hoac null!");
    return;
}


hoTen = hoTen.Trim();


string[] tu = hoTen.Split(' ', StringSplitOptions.RemoveEmptyEntries);


string ketQua = "";
for (int i = 0; i < tu.Length; i++)
{
    string word = tu[i].ToLower();
    word = char.ToUpper(word[0]) + word.Substring(1);
    ketQua += word + " ";
}

Console.WriteLine("Ho ten chuan hoa: " + ketQua.Trim());
    