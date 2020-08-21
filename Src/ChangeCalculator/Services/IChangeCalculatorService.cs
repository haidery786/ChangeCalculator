using ChangeCalculator.Models;

namespace ChangeCalculator.Services
{
    interface IChangeCalculatorService
    {
        public ChangeModel CalculateChange(ProductModel product);
    }
}
