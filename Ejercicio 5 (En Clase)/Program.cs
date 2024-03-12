using System;

static void Menu()
{
    int Opcion = 0;
    do
    {
        Console.WriteLine("BIENVENIDO (EJERCICIOS CLASE 5)");
        Console.WriteLine("SELECCIONA UNA OPCION");
        Console.WriteLine("SUMA ----------------------> 1");
        Console.WriteLine("NOMBRE --------------------> 2");
        Console.WriteLine("FECHA DE NACIMIENTO -------> 3");
        Console.WriteLine("ADIVINA EL NUMERO ---------> 4");
        Console.WriteLine("PALINDROMOS ---------------> 5");
        Console.WriteLine("CONTADOR DE PALABRAS ------> 6");
        Console.WriteLine("SALIDA --------------------> 7");
        Opcion = Convert.ToInt32(Console.ReadLine());

        switch (Opcion)
        {
            case 1:
                SUMA();
                break;
            case 2:
                string Nombre = SALUDO();
                int Promedio = SUMATORA();
                int Edad = EDAD();
                Console.WriteLine($"{Nombre}, tienes {Edad} años y tu promedio es de {Promedio}");
                break;
            case 3:
                EDAD();
                break;
            case 4:
                int Adivina = NUMSEC();
                break;
            case 5:
                string Palindromo = PALINDROMO();
                break;
            case 6:
                string Conta = CONTADOR();
                break;
            case 7:
                Console.WriteLine("PROGRAMA FINALIZADO");
                break;
            default:
                Console.WriteLine("OPCION INVALIDA. INGRESA UN OPCION ACEPTABLE");
                break;
        }

        Console.WriteLine();
    } while (Opcion != 7);


}

static void SUMA()
{
    int Num1, Num2, Resul;

    Console.WriteLine("Ingrese el primer número:");
    Num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número:");
    Num2 = Convert.ToInt32(Console.ReadLine());
    Resul = Num1 + Num2;
    Console.WriteLine($"El resultado de la suma es: {Resul}");
}

static int SUMATORA()
{
    int Num1, Num2, Num3, Resul;

    Console.WriteLine("Ingrese la primera nota");
    Num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la segunda nota");
    Num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la tercera nota");
    Num3 = int.Parse(Console.ReadLine());
    Resul = Num1 + Num2 + Num3 / 3;
    return Resul;
}

static string SALUDO()
{
    Console.WriteLine("Ingrese su nombre:");
    return Console.ReadLine();
}

static int EDAD()
{
    int Año, Edad;

    Console.WriteLine("Ingrese su año de nacimiento:");
    Año = Convert.ToInt32(Console.ReadLine());
    Edad = 2024 - Año;
    Console.WriteLine($"Usted tiene {Edad} años.");
    return Edad;
}

static int NUMSEC()
{
    int Num1, Resul;

    Console.WriteLine("Piense en un numero");
    Console.Write("¿Listo?");
    Console.ReadLine();
    Console.WriteLine("Multiplica ese numero por 2");
    Console.Write("¿Listo?");
    Console.ReadLine();
    Console.WriteLine("Sumale 8");
    Console.Write("¿Listo?");
    Console.ReadLine();
    Console.WriteLine("Ahora multipliquelo por 5");
    Console.Write("¿Listo?");
    Console.ReadLine();
    Console.WriteLine("Escribe el número");
    Num1 = Convert.ToInt32(Console.ReadLine());
    Resul = (Num1 / 10) - 4; Console.WriteLine($"El numero que usted esta pensando es: {Resul}");
    return 0;
}

static string CONTADOR()
{
    string Frase;
    int NumPal, NumVocal;

    Console.WriteLine("Digite una frase por favor:");
    Frase = Console.ReadLine();
    NumPal = 0;
    NumVocal = 0;
    int i = 0;
    while (i < Frase.Length)
    {
        if (Frase[i] != ' ' && (i == 0 || Frase[i - 1] == ' '))
        {
            NumPal++;
        }
        char Letra = Char.ToLower(Frase[i]);
        if (char.IsLetter(Frase[i]) && (Letra == 'a' || Letra == 'e' || Letra == 'i' || Letra == 'o' || Letra == 'u'))
        {
            NumVocal++;
        }
        i++;
    }
    Console.WriteLine($"Numero de palabras: {NumPal}");
    Console.WriteLine($"Numero de vocales: {NumVocal}");
    return Console.ReadLine();
}


static string PALINDROMO()
{
    string Palabra;
    bool EsPalin;

    Console.WriteLine("Ingrese una palabra:");
    Palabra = Console.ReadLine();

    EsPalin = EsPalindromo(Palabra);

    if (EsPalin)
    {
        Console.WriteLine("La palabra ingresada SI es un palíndromo.");
    }
    else
    {
        Console.WriteLine("La palabra ingresada NO es un palíndromo.");
    }
    return Console.ReadLine();
}

static bool EsPalindromo(string palabra)
{
    int Longitud;
    
    Longitud = palabra.Length;
    for (int i = 0; i < Longitud / 2; i++)
    {
        if (palabra[i] != palabra[Longitud - i - 1])
        {
            return false;
        }
    }
    return true;
}

Menu();