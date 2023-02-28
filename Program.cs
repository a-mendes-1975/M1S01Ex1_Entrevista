using System;

namespace entrevista
{

    class informacao
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("Olá, Tudo bem? Qual seu nome?"); //Saída: Olá, Tudo bem? Qual o seu nome?
            string nome = Console.ReadLine();  //Entrada: {usuário digita nome}

            System.Console.WriteLine("Qual seu sobrenome?"); //Saída: Qual o seu sobrenome?
            string sobrenome = Console.ReadLine();  //Entrada: {usuário digita sobrenome}

            System.Console.WriteLine("Qual sua idade?"); //Saída: Qual a sua idade?
            int idade = int.Parse(Console.ReadLine());  //Entrada: {usuário digita idade}

            System.Console.WriteLine("Qual sua cor preferida?"); //Saída: Qual a sua cor favorita ?
            string cor = Console.ReadLine();  //Entrada: {usuário digita a cor favorita}

            System.Console.WriteLine("-------------------------------------------------------------------------");

            System.Console.WriteLine("Nome: " + nome);   //Saída: Nome: {nome Usuário}
            System.Console.WriteLine("Sobrenome: " + sobrenome); //Sobrenome: {sobrenome Usuário}
            System.Console.WriteLine("Idade: " + idade); //Idade: {idade Usuário}
            System.Console.WriteLine("Cor Favorita: " + cor); //Cor Favorita: {cor Favorita Usuário}
            
            System.Console.WriteLine("-------------------------------------------------------------------------");


        }
    }
}