using System;

class Program {
    static void Main() {
        string entrada = "Hello, world!";
        string invertida = "";

        for (int i = entrada.Length - 1; i >= 0; i--) {
            invertida += entrada[i];
        }

        Console.WriteLine("String original: " + entrada);
        Console.WriteLine("String invertida: " + invertida);
    }
}

