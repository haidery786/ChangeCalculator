using ChangeCalculator.Models;
using System;

namespace ChangeCalculator.Services
{
    public class ChangeCalculatorService :IChangeCalculatorService
    {
        public ChangeModel CalculateChange(ProductModel product)
        {
            var changeModel = new ChangeModel();

            var change = product.Amount - product.Price  ;

            if (change >= 50)
            {
                var rand = (int)change / 50;
                changeModel.Fifty = (int)rand;
                change = Math.Round(change % 50, 2);
            }

            if (change >= 20)
            {
                var rand = change / 20;
                changeModel.Twenty = (int)rand;
                change = Math.Round(change % 20, 2);
            }

            if (change >= 10)
            {
                var rand = change / 10;
                changeModel.Ten = (int)rand;
                change = Math.Round(change % 10,2);
            }

            if (change >= 5)
            {
                var rand = change / 5;
                changeModel.Five = (int)rand;
                change = Math.Round(change % 5,2);
            }

            if (change >= 1)
            {
                var rand = change / 1;
                changeModel.One = (int)rand;
                change = Math.Round(change % 1, 2);
            }

            if (change >= 0.50M)
            {
                var rand = change / 0.50M;
                changeModel.FiftyPence = (int)rand;
                change = Math.Round(change % 0.50M, 2);
            }

            if (change >= 0.20M)
            {
                var rand = change / 0.20M;
                changeModel.TwentyPence = (int)rand;
                change = Math.Round(change % 0.20M, 2);
            }

            if (change >= 0.10M)
            {
                var rand = change / 0.10M;
                changeModel.TenPence = (int)rand;
                change = Math.Round(change % 0.10M,2);
            }

            if (change >= 0.05M)
            {
                var rand = change / 0.05M;
                changeModel.FivePence = (int)rand;
                change = Math.Round(change % 0.05M,2);
            }

            if (change >= 0.02M)
            {
                var rand = change / 0.02M;
                changeModel.TwoPence = (int)rand;
                change = Math.Round(change % 0.02M,2);
            }

            if (change == 0.01M)
            {
                changeModel.OnePence = Math.Round(change,2);
            }

            return changeModel;
        }
    }
}
