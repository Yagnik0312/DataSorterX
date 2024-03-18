namespace BasicSorting_Yagnik_007
{
    /// <summary>
    /// main method class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            GroupOfMeinMethodStatements();
        }

        /// <summary>
        /// Method for main-method statements 
        /// </summary>
        public static void GroupOfMeinMethodStatements()
        {
            int noOfRange;
            noOfRange = UserInputClass.UserInputOfNumber();
            decimal[] dataArray = new decimal[noOfRange];
            dataArray = UserInputClass.DataArrayInput(noOfRange);
            NextProcessClass.NextProcessMenu(dataArray);
        }
    }
}
