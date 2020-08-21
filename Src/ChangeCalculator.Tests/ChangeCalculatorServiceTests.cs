using ChangeCalculator.Models;
using ChangeCalculator.Services;
using NUnit.Framework;

namespace ChangeCalculator.Tests
{
    public class ChangeCalculatorServiceTests
    {
        private ChangeCalculatorService _changeCalculatorService;

        [SetUp]
        public void Setup()
        {
            _changeCalculatorService = new ChangeCalculatorService();
        }

        [Test]
        public void TestsTheCalculateChange_WhenPriceAndAmountPassed_ReturnCorrectChange()
        {
            // Arrange
            var productModel = new ProductModel();
            productModel.Price = 49.21M;
            productModel.Amount = 200M;

            var expectedChangeModel = new ChangeModel();
            expectedChangeModel.Fifty = 3;
            expectedChangeModel.FiftyPence = 1;
            expectedChangeModel.TwentyPence = 1;
            expectedChangeModel.FivePence = 1;
            expectedChangeModel.TwoPence = 2;

            //Act
            var actualexpectedChangeModel = _changeCalculatorService.CalculateChange(productModel);

            //Assert
            Assert.AreEqual(expectedChangeModel.Fifty, actualexpectedChangeModel.Fifty);
            Assert.AreEqual(expectedChangeModel.FiftyPence, actualexpectedChangeModel.FiftyPence);
            Assert.AreEqual(expectedChangeModel.TwoPence, actualexpectedChangeModel.TwoPence);
            Assert.AreEqual(expectedChangeModel.FivePence, actualexpectedChangeModel.FivePence);
            Assert.AreEqual(expectedChangeModel.TwoPence, actualexpectedChangeModel.TwoPence);
        }
    }
}