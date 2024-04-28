using System;
using System.Collections.Generic;

namespace Filme.Models
{
    public class FilmeInfo
    {
        public string Avaliacao { get; set; }
        public int AnoLancamento { get; set; }
        public string Genero { get; set; }
        public bool Disponivel { get; set; }
    }

    public class Filmes
    {
        private Dictionary<string, FilmeInfo> listaFilmes = new Dictionary<string, FilmeInfo>(){

            {"Divertidamente",
            new FilmeInfo{ Avaliacao = "4.6 estrelas", AnoLancamento = 2015, Genero = "Animação", Disponivel= true}
            },
            {"Toy Story",
            new FilmeInfo{ Avaliacao = "4.6 estrelas", AnoLancamento = 1995, Genero = "Animação", Disponivel= true}
            },
            {"Carros",
            new FilmeInfo{ Avaliacao = "4.7 estrelas", AnoLancamento = 2006, Genero = "Animação", Disponivel= true}
            },
            {"Os Incriveis",
            new FilmeInfo{ Avaliacao = "4.7 estrelas", AnoLancamento = 2004, Genero = "Animação", Disponivel= true}
            },
            {"Ratatouille",
            new FilmeInfo{ Avaliacao = "4.8 estrelas", AnoLancamento = 2007, Genero = "Animação", Disponivel= true}
            },
            {"Monstros SA",
            new FilmeInfo{ Avaliacao = "4.7 estrelas", AnoLancamento = 2001, Genero = "Animação", Disponivel= true}
            },
        };

        public void ConsultarFilmes(){
            foreach (var cada in listaFilmes){
                Console.WriteLine(cada.Key);
            }
        }
        public void ConsultarAvaliacao(){
            foreach (var cada in listaFilmes){
                Console.WriteLine(cada.Key + " - " + cada.Value.Avaliacao);
            }
        }
        public void AlugarFilme(){
            Console.WriteLine("O valor dos filmes são R$ 8,00 a hora");
            Console.WriteLine("Qual filme você quer alugar?");
            string querAlugar = Console.ReadLine();

            bool filmeEncontrado = false;

            foreach (var cada in listaFilmes){

                if (querAlugar == cada.Key){
                    filmeEncontrado = true;

                    if (!listaFilmes[querAlugar].Disponivel){
                        Console.WriteLine("Esse filme não está disponivel no momento");
                    }else{
                        Console.WriteLine("Informe o seu nome:");
                        string nomePessoa = Console.ReadLine();
                        Console.WriteLine("Pedido finalizado " + nomePessoa + "! " + "Você alugou o filme " + querAlugar + "!");
                        listaFilmes[querAlugar].Disponivel = false;
                    }
                }
            }
             if (!filmeEncontrado){
                    Console.WriteLine("\nEsse nome não corresponde com nenhum de nossos filmes");
                }
        }

        public void FinalizarAluguel(){
            Console.WriteLine("Qual o filme você deseja encerrar o aluguel?");
            string EncerrarAluguel = Console.ReadLine();

             bool filmeAlugado = false;

            foreach (var cada in listaFilmes){

                if (EncerrarAluguel == cada.Key){

                    filmeAlugado = true;

                    if(!listaFilmes[EncerrarAluguel].Disponivel){
                        Console.WriteLine("Quantas horas você passou com acesso ao filme?");
                        int horas = int.Parse(Console.ReadLine());

                        int valorAPagar = horas *8;

                        Console.WriteLine("O valor total a ser pago será de " + valorAPagar + " reais !");
                        listaFilmes[EncerrarAluguel].Disponivel = true;

                    }
                }
            }
            if (!filmeAlugado){
                    Console.WriteLine("\nEsse filme não foi alugado");
                }
        }


    }
}