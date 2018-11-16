namespace AutomatedTestingExample
{
    public class NaturalNumberCalculator
    {
        ///<summary>
        ///Add function.
        ///</summary>
        ///<param name="a">First number.</param>
        ///<param name="b">Second number.</param>
        ///<returns>Returns the sum of passed numbers.</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        ///<summary>
        ///Subtract function.
        ///</summary>
        ///<param name="a">First number.</param>
        ///<param name="b">Second number.</param>
        ///<returns>Returns the differnce between passed numbers.</returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        ///<summary>
        ///Multiply function.
        ///</summary>
        ///<param name="a">First number.</param>
        ///<param name="b">Second number.</param>
        ///<returns>Returns the result of mulitiplication.</returns>
        public int Mulitiply(int a, int b)
        {
            return a * b;
        }

        ///<summary>
        ///Divide function.
        ///</summary>
        ///<param name="a">First number.</param>
        ///<param name="b">Second number.</param>
        ///<returns>Returns the result of division.</returns>
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
