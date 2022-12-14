// написать программу, кт из имеющегося массива строк формирует массив строк,
// длина кт меньше либо равна 3 символа.
using static System.Console;
WriteLine("Dear teacher, write any text: ");
string[] Array = new string [ReadLine()!.Length];
string Massive = String.Empty;
int count = 0;
string words = String.Empty;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] == " " || Array[i] == "," || Array[i] == "." || Array[i] == "!" || Array[i] == ";" || Array[i] == "?")
    {
        if (count > 3)
        {
            count = 0;
            words = String.Empty;
        }
        else
        {
            Massive = Massive + words + Array[i];
            count = 0;
            words = String.Empty;
        }
    }
    else
    {
        words = words + Array[i];
        count++;
    }
}
if (count > 3)
{
    WriteLine(Massive);
}
else
{
    Massive = Massive + words;
    WriteLine(Massive);
}
