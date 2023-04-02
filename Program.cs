using System;

namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {

//Essa linha declara cinco variáveis do tipo double: n1, n2, n3, n4 e soma
            double n1, n2, n3, n4, soma;
//Essa linha escreve uma mensagem na tela, pedindo ao usuário que digite o primeiro número
             Console.Write("Digite o primeiro número: ");
//Essa linha lê o valor digitado pelo usuário como uma string, converte-o em um número decimal e atribui o valor à variável n1.
             n1 = Convert.ToDouble(Console.ReadLine());
       
             Console.Write("Digite o segundo número: ");
             n2 = Convert.ToDouble(Console.ReadLine());

             Console.Write("Digite o terceiro número: ");
             n3 = Convert.ToDouble(Console.ReadLine());

             Console.Write("Digite o quarto número: ");
             n4 = Convert.ToDouble(Console.ReadLine());
             
//Essa linha calcula a soma dos quatro números e atribui o resultado à variável soma
             soma = (n1 + n2+ n3 + n4);

//Essa linha calcula a média dos quatro números dividindo a soma por 4 e atribui o resultado à variável media
             double media = soma / 4;
             
//Essa linha escreve o valor da soma na tela, junto com a mensagem "SOMA:"
             Console.WriteLine("SOMA: " + soma );

//Essa linha escreve o valor da média na tela, junto com a mensagem "MEDIA:"
             Console.WriteLine("MEDIA: " + media);

//Essa linha aguarda o usuário pressionar qualquer tecla antes de fechar a janela do console.
             Console.ReadKey();
        }
    }
}