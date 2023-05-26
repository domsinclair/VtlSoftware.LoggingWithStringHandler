using VtlSoftware.Logging.Net6;

namespace VtlSoftware.LoggingConsoleApp
{
    public partial class Calculator
    {
        #region Public Methods
        [LogMethod]
        public double Add(double a, double b) { return a + b; }

        public double Divide(double a, double b) { return a / b; }

        public double Multiply(double a, double b) { return a * b; }

        public double Subtract(double a, double b) { return (a - b); }

        #endregion
    }
}
