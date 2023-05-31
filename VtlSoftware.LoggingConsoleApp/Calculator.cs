using VtlSoftware.Logging.Net6;

namespace VtlSoftware.LoggingConsoleApp
{
    public partial class Calculator
    {
        #region Fields

        private double firstNumber;

        #endregion

        #region Public Methods
        public double Add(double a, [Redact]double b)
        {
            //If you uncomment the line below you'll see that you can add additional log statements
            // on top of that provided by the log aspect.

            //logger.LogInformation($"I'm in the Add Method");

            FirstNumber = a;
            return a + b;
        }

        public static double Divide(double a, double b) { return a / b; }

        public int DivideInt(int a, int b) { return a / b; }

        public double Multiply(double a, double b) { return a * b; }

        public double Subtract(double a, double b) { return (a - b); }

        #endregion

        #region Public Properties
        public double FirstNumber { get => firstNumber; set => firstNumber = value; }

        #endregion
    }
}
