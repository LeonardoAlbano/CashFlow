namespace CashFlow.Exception.ExceptionBase;

public class ErrorOnValidationException : CashFlowException
{
    public List<string> Errors { get; }
    public ErrorOnValidationException(List<string> errorMessages)
    {
        Errors = errorMessages;
    }
}