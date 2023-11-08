using System;
using System.Collections;
using System.Collections.Generic;

namespace correcaoProva
{
    public class Carro
    {
        private string marca;
        private string modelo;
        private int ano;

        public Carro(string modelo, string marca, int ano)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.ano = ano;
        }

        public Carro()
        {
            modelo = "Modelo Qualquer";
            marca = "Marca Qualquer";
            ano = 1999;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Carro c = obj as Carro;
            return c.modelo == this.modelo && c.marca == this.marca && c.ano == this.ano;
        }

        public override string ToString()
        {
            return $"modelo: {this.modelo}, marca: {this.marca}, ano: {this.ano}";
        }

        //QUESTÃO 2
        public static ArrayList ContarMarcas(ArrayList arr)
        {
            ArrayList marcas = new ArrayList();

            foreach (Carro carro in arr)
                if (!marcas.Contains(carro.marca))
                    marcas.Add(carro.marca);

            return marcas;
        }

        public static int ContarCarros(ArrayList arr, string marca)
        {
            int count = 0;
            foreach (Carro carro in arr)
                if (carro.marca == marca)
                    count++;

            return count;
        }

        public static void Teste1()
        {
            Console.WriteLine("\nQUESTÃO 1");
            Carro carroa = new Carro("Uno", "Fiat", 1999);
            Carro carrob = new Carro("Uno", "Fiat", 1999);

            if (carroa.Equals(carrob))
                Console.WriteLine("Os carros são iguais");
            else
                Console.WriteLine("Os carros não são iguais");
        }

        public static void Teste2()
        {
            Console.WriteLine("\nQUESTÃO 2");
            ArrayList arr = new ArrayList();

            Carro carroGenerico = new Carro();

            arr.Add(new Carro("Palio", "Fiat", 2002));
            arr.Add(new Carro("Palio", "Fiat", 2003));
            arr.Add(new Carro("Punto", "Fiat", 2011));
            arr.Add(new Carro("Punto", "Fiat", 2012));
            arr.Add(new Carro("Civic", "Honda", 2019));
            arr.Add(new Carro("Eclipse", "Mitsubishi", 2008));

            ArrayList marcas = Carro.ContarMarcas(arr);

            foreach (string marca in marcas)
                Console.WriteLine($"{marca}: {Carro.ContarCarros(arr, marca)} carro(s).");
        }

        public static void Teste3()
        {
            Console.WriteLine("\nQUESTÃO 3");
            ArrayList arr = new ArrayList();

            arr.Add(new Carro("Kwid", "Renault", 2023));
            arr.Add(new Carro("Mobi", "Fiat", 2023));
            arr.Add(new Carro("C3", "Citroën", 2023));
            arr.Add(new Carro("Argo", "Fiat", 2023));
            arr.Add(new Carro("HB20", "Hyundai", 2023));
            arr.Add(new Carro("Stepway", "Renault", 2023));
            arr.Add(new Carro("Onix", "Chevrolet", 2023));
            arr.Add(new Carro("Cronos", "Fiat", 2023));
            arr.Add(new Carro("Polo Track", "Volkswagen", 2023));

            Dictionary<string, int> d = new Dictionary<string, int>();

            foreach (Carro car in arr)
                if (!d.ContainsKey(car.marca))
                    d[car.marca] = Carro.ContarCarros(arr, car.marca);

            foreach (KeyValuePair<string, int> item in d)
                Console.WriteLine($"{item.Key}: {item.Value} carros");
        }

        public static void Teste4()
        {
            Console.WriteLine("\nQUESTÃO 4");
            Console.WriteLine("digite o número desejado para iterar (valor de n)");
            uint x = uint.Parse(Console.ReadLine());
            int n = (int)x;

            // MÉTODO 1
            int counter = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    counter++;

            Console.WriteLine($"O algoritmo processou {counter} vezes na complexidade de {n} x {n}");

            // MÉTODO 2
            counter = 0;
            for (int i = 0; i < (n * n); i++)
                counter++;
            Console.WriteLine($"O algoritmo processou {counter} vezes na complexidade de {n} x {n}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro.Teste1();
            Carro.Teste2();
            Carro.Teste3();
            Carro.Teste4();
        }
    }
}
