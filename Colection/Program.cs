using System;

var names = new List<string> { "<name>", "Ana", "Felipe" };


names.Add("marria");// thêm phần tử vào cuối trong list
names.Add("nhat");
names.Add("Anh");
names.Remove("Ana");// xóa phần tử trong list
//for (int i = 0; i < names.Count; i++)
//{
//    string name = names[i];
//    NewMethod(name);
//}
var index = names.IndexOf("nhat"); // Trả về vị trí phần tử đầu tiên trùng với phần tử truyên vào => return int
Console.WriteLine("Ở vị trí {0}, ta có phần tử [{1}]", index, names[index]);
names.Sort() ;// Giúp xắp xếp các phần tử , mặc định tăng dần nếu type number hoặc a-z nếu chuỗi
foreach (string name in names)
{
    NewMethod(name);
}

static void NewMethod(string name)
{
    Console.WriteLine($"Hello {name.ToUpper(System.Globalization.CultureInfo.CurrentCulture)}!");
}