using System;
namespace BasicSorting_Yagnik_007
{
    /// <summary>
    /// Contains mathods to take input from user
    /// </summary>
    class UserInputClass
    {
        /// <summary>
        /// Method for Input data array index
        /// </summary>
        /// <returns>Array index of data array</returns>
        public static int UserInputOfNumber()
        {
            while (true)
            {
                Console.WriteLine(DisplayMessage.UserInputOfNumberMessage, ClassOfConstants.MinRangeForIndex, ClassOfConstants.MaxRangeForIndex);
                string input = Console.ReadLine();
                if (ValidationClass.ValidateIntInput(input, ClassOfConstants.MinRangeForIndex, ClassOfConstants.MaxRangeForIndex))
                {
                    return int.Parse(input);
                }
                else
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// Method for Input data array index
        /// </summary>
        /// <param name="rangeOfArray">Length of data array</param>
        /// <returns>Data Array</returns>
        public static decimal[] DataArrayInput(int rangeOfArray)
        {
            decimal[] dataArray = new decimal[rangeOfArray];
            Console.WriteLine(DisplayMessage.RangeForDataInputMessage, ClassOfConstants.MinRangeForData, ClassOfConstants.MaxRangeForData);
            for (int iterator = 0; iterator < rangeOfArray; iterator++)
            {
                while (true)
                {
                    int dataMember = iterator + 1;
                    string indeoxOfData = dataMember.ToString();
                    Console.WriteLine(DisplayMessage.DataInputMessage, NextProcessClass.ToChangeOrdinal(dataMember));
                    string input = Console.ReadLine();
                    if (ValidationClass.ValidateDecimalInput(input, ClassOfConstants.MinRangeForData, ClassOfConstants.MaxRangeForData))
                    {
                        dataArray[iterator] = decimal.Parse(input);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.Clear();
            return dataArray;
        }

        /// <summary>
        /// Method to input Process id in Enum
        /// </summary>
        /// <returns></returns>
        public static EnumNextProcess EnumInputMethod()
        {
            EnumNextProcess EnumForNextProcessInput;
            while (true)
            {
                bool isValidInput = false;
                isValidInput = Enum.TryParse(Console.ReadLine(), out EnumForNextProcessInput);
                if (isValidInput == false)
                {
                    Console.WriteLine(DisplayMessage.WrongInputForOrderTypeMessage);
                    continue;
                }
                else
                {
                    break;
                }
            }
            return EnumForNextProcessInput;
        }

        /// <summary>
        /// Method to take input for new data while updating the data
        /// </summary>
        /// <returns>new data s</returns>
        public static decimal NewDataInput()
        {
            while (true)
            {
                Console.WriteLine(DisplayMessage.NewDataInputMessage);
                string input = Console.ReadLine();
                if (ValidationClass.ValidateDecimalInput(input, ClassOfConstants.MinRangeForData, ClassOfConstants.MaxRangeForData))
                {
                    return decimal.Parse(input);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
