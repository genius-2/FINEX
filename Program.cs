Console.WriteLine("Введите строку разделяя слова пробелами");
string s = Console.ReadLine();
string s1;
int a = 0;
while (s != null)
{
    a = s.IndexOf(" ");
    if (a == -1 && s.Length > 3)
    {
        break;
    }
    else if (a == -1 && s.Length <= 3)
    {
        Console.WriteLine(s);
        break;
    }
    else if (a <= 3)
    {
        s1 = s.Substring(0, a);
        Console.WriteLine(s1+" ");
    }
    s=s.Substring(a + 1);
}
