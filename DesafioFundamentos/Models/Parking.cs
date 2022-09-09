namespace DesafioFundamentos.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();
        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string vehiclePlate = Console.ReadLine();
            // "!"é de negação | Verifica se não há veículos no estacionamento
            if (!vehicles.Any(x => x.ToUpper() == vehiclePlate.ToUpper()))
            {
                vehicles.Add(vehiclePlate);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo já está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string vehiclePlate = Console.ReadLine();

            // Verifica se o veículo existe
            if (vehicles.Any(x => x.ToUpper() == vehiclePlate.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int hours = int.Parse(Console.ReadLine());
                decimal totalValue = initialPrice + pricePerHour * hours;

                vehicles.Remove(vehiclePlate);

                Console.WriteLine($"O veículo {vehiclePlate} foi removido e o preço total foi de: {totalValue.ToString("C")}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListVehicles()
        {
            // Verifica se há veículos no estacionamento
            if (vehicles.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string x in vehicles)
                {
                    Console.WriteLine(x);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
