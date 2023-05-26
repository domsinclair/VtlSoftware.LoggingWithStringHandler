namespace VtlSoftware.Logging.Net6
{
    internal class ArgumentList
    {
        #region Fields
        private int index;

        #endregion

        #region Constructors
        public ArgumentList(int formattedCount) => Arguments = new object?[formattedCount];

        #endregion

        #region Public Methods
        public void Add(object? value) => Arguments[index++] = value;

        #endregion

        #region Public Properties
        public object?[] Arguments { get; }

        #endregion
    }
}
