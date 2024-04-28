using System;
using System.Text;
using Filme.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Filmes filmes = new Filmes();

Console.WriteLine("\nBem-vindo(a)!");

while (true)
{
    Console.WriteLine("\nO que você gostaria de fazer?\n\n" + "1.Consultar filmes disponiveis \n" + "2.Alugar um filme\n" + "3.Finalizar o aluguel de um filme\n" + "4.Encerrar o programa" );
    int escolha = int.Parse(Console.ReadLine());

    switch(escolha){
        case 1 :
        Console.WriteLine("Filmes disponiveis:\n");
        filmes.ConsultarFilmes();

        Console.WriteLine("\nDeseja ver as avaliações dos filmes? (S/N)");
        string avaliacao = Console.ReadLine();
            switch(avaliacao){
                case "S":
                case "s":
                filmes.ConsultarAvaliacao();
                break;
                case "N":
                case "n":
                break;
                default:
                Console.WriteLine("Essa opção não existe!");
                break;
            }
        break;
        case 2 :
        filmes.AlugarFilme();
        break;
        case 3 :
        filmes.FinalizarAluguel();
        break;
        case 4 :
        Environment.Exit(0);
        break;
        default:
        Console.WriteLine("Essa opção não existe! Digite outro valor");
        break;
    }
}
//adicionar lista de filmes que eu já aluguei
// pedir avaliação do filme
