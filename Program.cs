using System;

using System.Text;

namespace StringBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = new StringBuilder();//Novo Construtor(Build)(Temos sempre a cópia e nunca a referencia)
            texto.Append("Este texto é um teste");
            texto.Append("Este texto é ");
            texto.Append("é um teste");
            texto.Append("Este é teste");

            texto.ToString();
            Console.WriteLine(texto);





            //var texto = "Este texto é um teste";
            //texto += "aqui";  (Concatenacao) Unir duas Strings 


            //Console.WriteLine("Hello World!");

        }
    }
}
