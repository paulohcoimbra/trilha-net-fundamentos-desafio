namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal _precoInicial = 0;
        private decimal _precoPorHora = 0;
        private List<string> _veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            _precoInicial = precoInicial;
            _precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            _veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (!_veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                return;
            }

            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            string inputUsuario = Console.ReadLine();

            int horas = 0;
            if(!int.TryParse(inputUsuario, out horas))
            {
                Console.WriteLine("Entrada inválida para as horas, tente novamente!");
                return;
            }

            decimal valorTotal = _precoInicial + (_precoPorHora * horas); 

            _veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (!_veiculos.Any())
            {
                Console.WriteLine("Não há veículos estacionados.");
                return;
            }

            Console.WriteLine("Os veículos estacionados são:");
            _veiculos.ForEach(Console.WriteLine);
        }
    }
}
