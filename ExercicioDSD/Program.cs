using Newtonsoft.Json;
using System;

namespace ExercicioDSD
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimaisResgatados Object = new AnimaisResgatados()
            {
                Nome = "Canguru",
                TipoDeAnimal = "Marsupial",
                PaisOrigem = "Australia",
                QuantidadeEncontrada = 30
            };

            string creditApplicationJson = JsonConvert.SerializeObject(
    new
    {
        jsonCreditApplication = Object
    });
            Console.WriteLine(creditApplicationJson);

        }
    }
}