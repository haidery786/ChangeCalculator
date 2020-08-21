using ChangeCalculator.Models;
using ChangeCalculator.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ChangeCalculator
{
    class Program
    {
        private static IServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            RegisterServices();

            var changeCalculatorService = _serviceProvider.GetService<IChangeCalculatorService>();

            Console.WriteLine("Please enter the product price");

            var productModel = new ProductModel();

            productModel.Price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the amount");

            productModel.Amount = Convert.ToDecimal(Console.ReadLine());

            var change = changeCalculatorService.CalculateChange(productModel);

            Console.WriteLine("This is your change" + Environment.NewLine);

            Console.WriteLine($"{change.Fifty} * £50" + Environment.NewLine);
            Console.WriteLine($"{change.Twenty} * £20" + Environment.NewLine);
            Console.WriteLine($"{change.Ten} * £10" + Environment.NewLine);
            Console.WriteLine($"{change.Five} * £5" + Environment.NewLine);
            Console.WriteLine($"{change.One} * £1" + Environment.NewLine);
            Console.WriteLine($"{change.FiftyPence} * 50p" + Environment.NewLine);
            Console.WriteLine($"{change.TwentyPence} * 20p" + Environment.NewLine);
            Console.WriteLine($"{change.TenPence} * 10p" + Environment.NewLine);
            Console.WriteLine($"{change.FivePence} * 5p" + Environment.NewLine);
            Console.WriteLine($"{change.TwoPence} * 2p" + Environment.NewLine);
            Console.WriteLine($"{change.OnePence} * 1p" + Environment.NewLine);

            Console.ReadKey();

            DisposeServices();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<IChangeCalculatorService, ChangeCalculatorService>();

            _serviceProvider = services.BuildServiceProvider();
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }

            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
