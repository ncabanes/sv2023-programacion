/*227. Crea un menú que permita al usuario lanzar 8 aplicaciones prefijadas, 
pulsando las teclas del 1 al 8, o salir pulsando ESC. Por ejemplo, 1 podría 
lanzar el Bloc de Notas y 2 podría lanzar Geany.*/ 

// Miguel Ángel

using System; 
using System.Diagnostics;

class MenuLanzador
{
    static void Main()
    {
        bool salir = false;
        do
        {
            MostrarMenu();
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Escape)
            {
                salir = true;
            }
            else 
            { 
                string opcion =  "" + tecla.KeyChar;
                IniciarProgramas(opcion);
            }
            Console.WriteLine();
        }
        while (!salir);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Menú de aplicaciones");
        Console.WriteLine();
        Console.WriteLine("1. Google Chrome.");
        Console.WriteLine("2. Geany.");
        Console.WriteLine("3. Bloc de notas.");
        Console.WriteLine("4. Visual studio.");
        Console.WriteLine("5. Notepad ++");
        Console.WriteLine("6. IntelliJ IDEA");
        Console.WriteLine("7. Microsoft Edge");
        Console.WriteLine("8. Paint");
        Console.WriteLine("Pulse ESC para salir.");
        Console.WriteLine();
        Console.Write("Elige una opción: ");
    }

    static void IniciarProgramas(string opcion)
    {
        Process process;
        string chrome = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
        string geany = @"C:\Program Files\Geany\bin\geany.exe";
        string blocN = @"C:\WINDOWS\system32\notepad.exe";
        string visualS = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe";
        string notepad = @"C:\Archivos portables\npp.7.3.bin.x64\notepad++.exe";
        string intelliJ = @"C:\Program Files\JetBrains\IntelliJ IDEA Community Edition 2023.2.5\bin\idea64.exe";
        string edge = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
        string paint = @"C:\WINDOWS\system32\mspaint.exe";

        switch (opcion)
        {
            case "1": process = Process.Start(chrome); break;
            case "2": process = Process.Start(geany); break;
            case "3": process = Process.Start(blocN); break;
            case "4": process = Process.Start(visualS); break;
            case "5": process = Process.Start(notepad); break;
            case "6": process = Process.Start(intelliJ); break;
            case "7": process = Process.Start(edge); break;
            case "8": process = Process.Start(paint); break;
            default: 
                Console.WriteLine();
                Console.WriteLine("Opción incorrecta."); 
                break;
        }
    }
}

