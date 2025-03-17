using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;

namespace Validators.Tests.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();
        var request = new RequestRegisterExpenseJson
        {
            Amount = 100,
            Date = DateTime.Now.AddDays(-1),
            PaymentType = CashFlow.Communication.Enums.PaymentType.CreditCard,
            Description = "Description",
            Title = "Apple",

        };
        var result = validator.Validate(request);
        Assert.True(result.IsValid);
    }
}