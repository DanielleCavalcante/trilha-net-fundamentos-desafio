using System.Runtime.InteropServices;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("\nDigite a placa do veículo que deseja estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"\nVeículo {placa} adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.Write("\nDigite a placa do veículo para remover: ");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("\nDigite a quantidade de horas que o veículo permaneceu estacionado: ");
                double horas = Convert.ToDouble(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * Convert.ToDecimal(horas)); 

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("\nVeículo não localizado! Verifique a placa digitada e tente novamente!");
            }
        }            

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("\nVeículos estacionados:");

                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.");
            }
        }
    }
}
