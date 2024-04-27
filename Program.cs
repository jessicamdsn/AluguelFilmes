using System;
using System.Text;
using Filme.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Filmes filmes = new Filmes();

Console.WriteLine("Bem-vindo(a)!");

while (true)
{
    Console.WriteLine("\nO que você gostaria de fazer?\n" + "1.Consultar filmes disponiveis \n" + "2.Alugar um filme\n" + "3.Cancelar aluguel de um filme\n" + "4.Encerrar o programa" );
    int escolha = int.Parse(Console.ReadLine());

    switch(escolha){
        case 1 :
        Console.WriteLine("Filmes disponiveis:\n");
        filmes.ConsultarFilmes();

        Console.WriteLine("Deseja ver as avaliações dos filmes?\n");
        string avaliacao = Console.ReadLine();
        switch(avaliacao){
            case "SIM":
            case "Sim":
            case "sim":
            filmes.ConsultarAvaliacao();
            break;
            case "NAO":
            case "Não":
            case "nao":
            case "não":
            Console.WriteLine(":)");
            break;
            default:
            Console.WriteLine("Essa opção não existe"!);
            break;

        }

        break;
        case 2 :
        break;
        case 3 :
        break;
        case 4 :
        Environment.Exit(0);
        break;
        default:
        Console.WriteLine("Essa opção não existe! Digite outro valor");
        break;
    }
}

