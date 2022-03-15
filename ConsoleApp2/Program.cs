namespace StalinSort;
public class Program_les_3
{
    static void Main(string[] args)
    {
       // Входные данные
       int[] a = {1, 2, 3, 7, 5, 9, 8};
       Array.Reverse(a);
       
       // копирую массив. сортирую и привожу в правильный порядок
       int[] b = new List<int>(a.AsEnumerable()).ToArray();
       Array.Sort(b);
       Array.Reverse(b);

       // прохожу циклом
       for (var i = 0; i < a.Length; i++)
       {   
          // сравниваю два массива на правильлный порядок цифр
          if (a[i] == b[i])
             Console.Write(a[i] + ","); // 3 2 1 сошлись

          if (a[i] != b[i])
             Console.WriteLine($"к расстрелу: {a[i]}"); // 8 9 5 7 - не сошлись
       }
    }
}