using System;
using System.Collections.Generic;

namespace Filme.Models
{
    public class FilmeInfo
    {
        public string Avaliacao { get; set; }
        public int AnoLancamento { get; set; }
        public string Genero { get; set; }
    }

    public class Filmes
    {
        private Dictionary<string, FilmeInfo> listaFilmes = new Dictionary<string, FilmeInfo>(){

            {"Divertidamente",
            new FilmeInfo{ Avaliacao = "4.6 estrelas", AnoLancamento = 2015, Genero = "Animação"}
            },
            {"Toy Story",
            new FilmeInfo{ Avaliacao = "4.6 estrelas", AnoLancamento = 1995, Genero = "Animação"}
            },
            {"Carros",
            new FilmeInfo{ Avaliacao = "4.7 estrelas", AnoLancamento = 2006, Genero = "Animação"}
            },
            {"Os Incriveis",
            new FilmeInfo{ Avaliacao = "4.7 estrelas", AnoLancamento = 2004, Genero = "Animação"}
            },
            {"Ratatouille",
            new FilmeInfo{ Avaliacao = "4.8 estrelas", AnoLancamento = 2007, Genero = "Animação"}
            },
            {"Monstros SA",
            new FilmeInfo{ Avaliacao = "4.7 estrelas", AnoLancamento = 2001, Genero = "Animação"}
            },
        };

        public void ConsultarFilmes(){
            foreach (var cada in listaFilmes){
                Console.WriteLine(cada.Key);
            }
        }
        public void ConsultarAvaliacao(){
            foreach (var cada in listaFilmes){
                Console.WriteLine(cada.Key + " - " +cada.Value.Avaliacao);
            }
        }

    }
}