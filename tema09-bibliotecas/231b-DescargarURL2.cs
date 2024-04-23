/*231. Descarga de forma automatizada la versión HTML del libro "Learn Python 
the Hard Way" (al menos los 52 ejercicios), desde

https://learnpythonthehardway.org/book/*/

// Miguel Ángel

using System.IO;
using System.Net;

class DescargarHTML
{
    static void Main()
    {
        WebClient client = new WebClient();
        for (int i = 0; i <= 52;  i++)
        {
            client.DownloadFile(
                "https://learnpythonthehardway.org/book/ex" + i + ".html",
                "phytonEx" + i + ".html");
        }
    }
}

