using System;

namespace TiposDeString;

class Program
{
    static void Main() {
        char[] letras = new char[] { 'a', 'b', 'c' };
        char letra = 'a';
        char numero = '0';
        char espaco = ' ';

        string texto = "Este curso é muito bom";
        char primeiraLetraDoTexto = texto[0];

        string meuNome = "           Wellington        ";
        string meuNomeSemEspaco = meuNome.Trim();
        string textoAposReplace = meuNomeSemEspaco.Replace('e', '7');


        bool comecaComLetraW = meuNomeSemEspaco.StartsWith("W");
        bool existe1 = texto.Contains("curso");
        bool existe2 = texto.Equals("curso");

        Console.WriteLine(existe);
        Console.WriteLine(comecaComLetraW);
        Console.WriteLine(textoAposReplace);
        Console.WriteLine(letra);
        Console.WriteLine(numero);
        Console.WriteLine(espaco);
        Console.WriteLine(texto);
        Console.WriteLine(primeiraLetraDoTexto);
        Console.WriteLine(meuNome);
        Console.WriteLine(meuNomeSemEspaco);
    }
}