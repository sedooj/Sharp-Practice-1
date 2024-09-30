using ConsoleApp5.file;

namespace Sharp_Practice_1.render;

public class ViewRenderer
{
    private List<FileObject> _files;

    public ViewRenderer(List<FileObject> files)
    {
        _files = files;
    }

    public void Render()
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write("    ");
        string[] str1 = { "Левая", "Файл", "Диск", "Команды", "Правая" };
        for (int i = 0; i < str1.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(str1[i][0]);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(str1[i].TrimStart(str1[i][0]) + "    ");
        }

        Console.Write("                    ");
        Console.WriteLine();

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\u2554");

        for (int i = 1; i < 31; i++)
        {
            if (i == 15)
            {
                Console.Write(" C: \\NC ");
                i = 22;
            }

            if (i == 10)
            {
                Console.Write("\u2564");
            }

            if (i == 24)
            {
                Console.Write("\u2564");
            }

            Console.Write("\u2550");
        }

        Console.Write("\u2557");

        Console.Write("\u2554");
        for (int i = 1; i < 31; i++)
        {
            if (i == 15)
            {
                Console.Write(" C: \\NC ");
                i = 22;
            }

            if (i == 10)
            {
                Console.Write("\u2564");
            }

            if (i == 24)
            {
                Console.Write("\u2564");
            }

            Console.Write("\u2550");
        }

        Console.Write("\u2557");

        Console.WriteLine();

        for (int i = 0; i < _files.Count(); i++)
        {
            Console.WriteLine("\u2551" + _files[i].Name + "\u2502 " + (_files[i].Size) + " \u2502 " +
                              _files[i].IsDirectory + " \u2502 " + _files[i].Modification + "\u2551" + "\u2551" +
                              _files[i].Name + "\u2502 " + (_files[i].Size) + " \u2502 " + _files[i].IsDirectory +
                              " \u2502 " + _files[i].Modification + "\u2551");
        }

        Console.Write("\u255F");
        for (int i = 1; i < 31; i++)
        {
            Console.Write("\u2500");
            if (i == 9 || i == 16 || i == 23)
            {
                Console.Write("\u2534");
            }
        }

        Console.Write("\u2562");
        Console.Write("\u255F");
        for (int i = 1; i < 31; i++)
        {
            Console.Write("\u2500");
            if (i == 9 || i == 16 || i == 23)
            {
                Console.Write("\u2534");
            }
        }

        Console.WriteLine("\u2562");

        Console.Write("\u2551" + ".." + "   >Каталог< 16.09.2024  13:15 " + "\u2551");
        Console.WriteLine("\u2551" + ".." + "   >Каталог< 16.09.2024  13:15 " + "\u2551");
        Console.Write("\u255A");
        for (int i = 1; i < 34; i++)
        {
            Console.Write("\u2550");
        }

        Console.Write("\u255D");
        Console.Write("\u255A");
        for (int i = 1; i < 34; i++)
        {
            Console.Write("\u2550");
        }

        Console.WriteLine("\u255D");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("C:/NC>_");
        string[] str2 = { "Пом", "Выз", "Чтение", "Правка", "Коп", "НовИмя", "НоваКат", "Удал-е", "Меню", "Выход" };
        for (int i = 1; i < 11; i++)
        {
            Console.Write(i);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(str2[i - 1] + " ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Black;
    }
}