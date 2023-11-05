/* 61. Crea un programa que pida al usuario un símbolo y responda si se 
trata de un operador (+ - * / %), un símbolo de puntuación (. , ; : ), 
un dígito (0 al 9), o algún otro símbolo. Debes emplear el tipo de 
datos "char" y hacerlo de dos formas distintas (en un mismo programa): 
primero usando "if" y después empleando "switch". Recuerda agrupar 
casos cuando sea posible. */

// David (...)

using System;

class TipoChar 
{
  public static void Main (string[] args) 
  {

    Console.Write("Introduce un simbolo: ");
    char simbolo = Convert.ToChar(Console.ReadLine());
    
    if (simbolo == '+' || simbolo == '-'|| simbolo == '*' 
            || simbolo == '/' || simbolo == '%')
        Console.WriteLine("Es un operador");
    else if (simbolo == '.' || simbolo == ','|| simbolo == ';' 
            || simbolo == ':')
        Console.WriteLine("Es un simbolo de puntuacion");
    else if (simbolo >= '0' && simbolo <= '9')
        Console.WriteLine("Es un digito");
    else
        Console.WriteLine("No se que simbolo es");

    //Ahora con switch

    Console.Write("Introduce un símbolo: ");
    char simboloswitch = Convert.ToChar(Console.ReadLine());

    switch (simboloswitch) {
        case '+':
        case '-':
        case '*':
        case '/':
        case '%':
            Console.WriteLine("Es un símbolo");
            break;
        case '.':
        case ',':
        case ';':
        case ':':
            Console.WriteLine("Es un símbolo de puntuación");
            break;
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
            Console.WriteLine("Es un dígito");
            break;
        default:
            Console.WriteLine("No sé qué símbolo es");
            break;
    }
  }
}
