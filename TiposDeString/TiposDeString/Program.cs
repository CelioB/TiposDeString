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

        bool comecaComLetraW = meuNomeSemEspaco.StartsWith("W");

        Console.WriteLine(comecaComLetraW);
        Console.WriteLine(letra);
        Console.WriteLine(numero);
        Console.WriteLine(espaco);
        Console.WriteLine(texto);
        Console.WriteLine(primeiraLetraDoTexto);
        Console.WriteLine(meuNome);
        Console.WriteLine(meuNomeSemEspaco);
    }
}