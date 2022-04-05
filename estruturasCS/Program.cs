using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturasCS
{
    internal class Program
    {
        //struct
        struct Carro
        {
            public string Marca;
            public string Modelo;
            public string Cor;
            public string Placa;

            public Carro(string marca, string modelo,string cor, string placa)//construtor da struct
            {
                Marca = marca;
                Modelo = modelo;
                Cor = cor;
                Placa = placa;
            }

            public void Exibirdados()
            {
                Console.WriteLine($"Marca.: {Marca} \nModelo: {Modelo} \nCor...: {Cor} \nPlaca.: {Placa}");
            }

        }

        
        static void Main(string[] args)
      
        {
            Console.WriteLine("----------------------list - listas------------------------------");
            //Carro carro = new Carro();
            //carro.Marca = "Honda";
            //carro.Modelo = "civic";
            //carro.Cor = "000000";//preto
            Carro carro2 = new Carro("ford","Ka","Azul","Preto");
            //Console.WriteLine("Marca: " + carro.Marca);
            //Console.WriteLine("Modelo: {0}", carro.Modelo);
            //Console.WriteLine($"Cor: {carro.Cor} \n Placa: {carro.Placa}");
            
            carro2.Exibirdados();

            //list - Listas

            List<Carro> carros = new List<Carro>();
            carros.Add(new Carro("ford", "Ka", "Azul", "EJC1203"));
            carros.Add(new Carro("VW", "fusta", "Azul", "ADE7989"));
            carros.Add(new Carro("Kia", "Soul", "Cinza", "GGK0712"));
            foreach (Carro carro in carros)
            {
                carro.Exibirdados();
                Console.WriteLine();
            }
            //List<object> list = new List<object>();//outra lista, detro da lista anterior
            //list.Add(carros);

            var teste = carros.Contains(new Carro("ford", "Ka", "Azul", "EJC1203"))? "tem sim, mano!" : "tem não mano :(";
            Console.WriteLine(teste);
            Console.WriteLine("----------------------queue - fila---------------------------------");


            //queue - Filas
            Queue<string> fila = new Queue<string>();
            
            //pessoas na fila, 3 nese caso
            fila.Enqueue("José:)");
            fila.Enqueue("Bruna<3");
            fila.Enqueue("Gui>:)");
            
            //exibe o número de elementos na fila
            Console.WriteLine($"Número de pessoas na fila: {fila.Count}");
            Console.WriteLine($"Proximo da fila: {fila.Peek()}");
            Console.WriteLine($"Número de pessoas na fila: {fila.Count}");
            Console.WriteLine($"cliente {fila.Dequeue()}, será atendido no guichê 4");
            Console.WriteLine($"Número de pessoas na fila: {fila.Count}");
            Console.WriteLine($"Proximo da fila: {fila.Peek()}");
            fila.Enqueue("júlio");
            Console.WriteLine("o cliente júlio entrou na fila!");
            Console.WriteLine($"Número de pessoas na fila: {fila.Count}");



            Console.WriteLine("------------------------stacks - Pilhas-----------------------------");
            //stack - Pilhas
            Stack<int> pilha = new Stack<int>();    
            pilha.Push(12);//adiciona elemento na pilha
            pilha.Push(13);
            pilha.Push(14); 
            pilha.Push(15);
            Console.WriteLine($"Removemos o primeiro elemento da pilha {pilha.Pop()}");
            Console.WriteLine($"Proximo elemento da pilha {pilha.Peek()}");



            Console.ReadKey();
        }
    }
}
