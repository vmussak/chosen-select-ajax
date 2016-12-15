using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ChosenSelectWithAjax.Models
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public SelectList ComboClientes { get; set; }
    }

    public static class ClienteFactory
    {
        private static string[] Nomes => new[]
        {
            "Alice", "Miguel", "Sophia", "Arthur", "Júlia", "Davi", "Laura", "Pedro", "Isabella", "Bernardo",
            "Manuela", "Gabriel", "Luiza", "Lucas", "Helena", "Matheus", "Valentina", "Heitor", "Giovanna", "Rafael",
            "MariaEduarda", "Enzo", "Beatriz", "Nicolas", "Maria Clara", "Lorenzo", "Maria Luiza", "Guilherme", "Heloísa", "Samuel",
            "Mariana", "Theo", "Lara", "Felipe", "Lívia", "Gustavo", "Lorena", "Henrique", "Ana Clara", "João Pedro", "Isadora", "João Lucas",
            "Rafaela", "Daniel", "Sarah", "Murilo", "Yasmin", "Vitor", "Ana Luiza", "Pedro Henrique", "Letícia", "Eduardo",
            "Nicole", "Leonardo", "Gabriela", "Pietro", "Isabelly", "Benjamin", "Melissa", "Isaac", "Cecília", "João",
            "Esther", "Joaquim", "Ana Júlia", "Lucca", "Emanuelly", "Caio", "Clara", "Vinicius", "Marina", "Cauã",
            "Rebeca", "Bryan", "Vitória", "João Miguel", "Isis", "Vicente", "Lavínia", "Francisco", "Maria", "Antônio",
            "Bianca", "Benício", "Ana Beatriz", "João Vitor", "Larissa", "Enzo Gabriel", "Maria Fernanda", "Davi Lucas",
            "Catarina", "Davi Lucca", "Alícia", "Thiago", "Maria Alice", "Thomas", "Amanda", "Emanuel", "Ana", "Enrico"
        };


        private static List<Cliente> BuscarClientes()
        {
            var lstClientes = new List<Cliente>(100);
            for (int i = 0; i < 100; i++)
                lstClientes.Add(new Cliente(i + 1, Nomes[i]));

            return lstClientes.OrderBy(x => x.Nome).ToList();
        }

        public static List<Cliente> BuscarClientes(string nome)
        {
            return BuscarClientes()
                .Where(x => x.Nome.ToLower().Contains(nome?.ToLower()) || string.IsNullOrEmpty(nome))
                .Take(10)
                .ToList();
        }
    }

}