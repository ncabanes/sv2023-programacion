/*El reloj digital
 Tienes un reloj digital de 7 segmentos LED. Un día, al despertar de un sueño 
de ciencia ficción, te preguntas: ¿cuántas veces se encenderán los leds 
individuales después de X segundos, desde la posición 00:00:00?

Pero como buen geek esa pregunta no se quedará en tu mente para siempre, 
¿verdad? ;)

Ten en cuenta que cada segundo se apagan todos los leds y luego se encienden 
los de la siguiente posición.

Entrada de ejemplo
0
4
1000
36000


Salida de ejemplo
36
172
30630
1069232

Pregunta original en: Tuenti Contest 2011, pregunta 6 (ya no disponible 
online)*/

// Miguel Ángel (...)

using System;

class relojDigital
{
    static void Main()
    {
        string stringSegundos;
        do
        {
            stringSegundos = Console.ReadLine();
            if (stringSegundos != "")
            {
                int segundos = Convert.ToInt32(stringSegundos);
                string formatoReloj;
                int contadorLeds = 0;
                for (int i = 0; i <= segundos; i++)
                {
                    formatoReloj = convertirAhhmmss(i);
                    for (int j = 0; j < formatoReloj.Length; j++)
                    {
                        contadorLeds += contadorLedsDigito(formatoReloj[j]);
                    }
                }
                Console.WriteLine(contadorLeds);

            }
        }while(stringSegundos !="");

    }
    
    static string convertirAhhmmss(int segundos)
    {
        restarDias(ref segundos);
        string stringHoras = cantidadHoras(ref segundos);
        string stringMinutos = cantidadMinutos(ref segundos);
        string stringSegundos = "" + segundos;
        if (segundos < 10)
        {
            stringSegundos = "0" + stringSegundos;
        }
        return stringHoras + stringMinutos + stringSegundos;

    }
    static string cantidadHoras(ref int segundos)
    {
        
        int horas = segundos / 3600;
        string stringHoras = "" + horas;
        segundos %= 3600;
        
        if (horas < 10)
        {
            stringHoras = "0" + stringHoras;
        }
        return stringHoras;
    }
    
    static string cantidadMinutos(ref int segundos)
    {
        int minutos = segundos / 60;
        string stringMinutos = ""+ minutos;
        segundos %= 60;
        if (minutos < 10)
        {
            stringMinutos = "0" + stringMinutos;
        }
        return stringMinutos;
    }
    static void restarDias(ref int segundos)
    {
        int dias = segundos / 86400;
        segundos %= 86400;
    }
    
    static byte contadorLedsDigito(char digito)
    {
        byte numLeds = 0;
        switch(digito)
        {
            case '0': numLeds = 6; break;
            case '1': numLeds = 2; break;
            case '2': numLeds = 5; break;
            case '3': numLeds = 5; break;
            case '4': numLeds = 4; break;
            case '5': numLeds = 5; break;
            case '6': numLeds = 6; break;
            case '7': numLeds = 3; break;
            case '8': numLeds = 7; break;
            case '9': numLeds = 6; break;
        }
        return numLeds;
    }
}
