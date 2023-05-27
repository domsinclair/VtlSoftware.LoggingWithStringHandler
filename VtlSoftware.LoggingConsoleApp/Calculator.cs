using VtlSoftware.Logging.Net6;

namespace VtlSoftware.LoggingConsoleApp
{
    public partial class Calculator
    {
        #region Public Methods
        [LogMethod]
        public double Add(double a, double b)
        {
            //If you uncomment the line below you'll see that you can add additional log statements
            // on top of that provided by the log aspect.

            logger.LogInformation($"I'm in the Add Method");
            return a + b;
        }

        [LogMethod]
        public double Divide(double a, double b) { return a / b; }

        [LogMethod]
        public int DivideInt(int a, int b) { return a % b; }

        public double Multiply(double a, double b) { return a * b; }

        public double Subtract(double a, double b) { return (a - b); }

        #endregion
    }
}
