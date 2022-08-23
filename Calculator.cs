namespace CalculatorApp
{
    public class Calculator
    {
        #region Logger
        /// <summary>
        /// Writes a message in the console all user friendly-like. <3
        /// </summary>
        /// <param name="txt">The text you would like to write in the console</param>
        /// <returns></returns>
        static async Task Log(string txt)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("[" + DateTime.Now + " (" + DateTime.Now.Millisecond.ToString().Substring(0, 2) + "ms)" + "] Machine: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(txt);
        }
        #endregion

        static void Main(string[] args)
        {
            //Un-used.
        }

        /// <summary>
        /// Adds 2 numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Sum of 2 numbers</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts 2 numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Difference of 2 numbers</returns>
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies 2 numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Product of 2 numbers</returns>
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides 2 numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Quotient of 2 numbers</returns>
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero!");
            return a / b;
        }
    }
}