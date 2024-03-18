using System;
namespace BasicSorting_Yagnik_007
{
    /// <summary>
    /// Class for next process
    /// </summary>
    class NextProcessClass
    {
        /// <summary>
        /// Method for next process to be exicuted
        /// </summary>
        /// <param name="dataArray">Array of data</param>
        public static void NextProcessMenu(decimal[] dataArray)
        {
            EnumNextProcess enumForLastProcess = EnumNextProcess.NulEnumValue;
        ShowMenu:
            Console.WriteLine(DisplayMessage.ProcessIdForShowDataMessage, (int)EnumNextProcess.ShowData);
            Console.WriteLine(DisplayMessage.ProcessIdForAcendingOrderInputMessage, (int)EnumNextProcess.SortAscending);
            Console.WriteLine(DisplayMessage.ProcessIdForDicendingOrderInputMessage, (int)EnumNextProcess.SortDiscending);
            Console.WriteLine(DisplayMessage.ProcessIdForDataChangeInputMessage, (int)EnumNextProcess.ChangeTheData);
            Console.WriteLine(DisplayMessage.ProcessIdForStartWithNewDataMessage, (int)EnumNextProcess.StartWithNewData);
            Console.WriteLine(DisplayMessage.ProcessIdForExitProgramInputMessage, (int)EnumNextProcess.ExitTheProgram);

            while (true)
            {   
                EnumNextProcess enumForProcessMenu = UserInputClass.EnumInputMethod();
                switch(enumForProcessMenu)
                {
                    case EnumNextProcess.ShowData:
                        if (enumForLastProcess == EnumNextProcess.LastProcessWasSeeData)
                        {
                            Console.WriteLine(DisplayMessage.DataIsDisplayedMessage);
                            break;
                        }
                        else
                        {
                            enumForLastProcess = EnumNextProcess.LastProcessWasSeeData;
                            Console.Clear();
                            Console.WriteLine(DisplayMessage.ShowYourDataMessage);
                            PrintDataArray(dataArray);
                            goto ShowMenu;
                        }
                    case EnumNextProcess.SortAscending:
                        if (enumForLastProcess == EnumNextProcess.LastProcessWasAscendingOrder)
                        {
                            Console.WriteLine(DisplayMessage.DataSortedInAscendingMessage);
                            break;
                        }
                        else
                        {
                            SortingTheData.AscendingSort(dataArray);
                            enumForLastProcess = EnumNextProcess.LastProcessWasAscendingOrder;
                            Console.Clear();
                            Console.WriteLine(DisplayMessage.AcsendingOrderOutputMessage);
                            PrintDataArray(dataArray);
                            goto ShowMenu;
                        }
                    case EnumNextProcess.SortDiscending:
                        if (enumForLastProcess == EnumNextProcess.LastProcessWasDicendingOrder)
                        {
                            Console.WriteLine(DisplayMessage.DataSortedInDiscendingMessage);
                            break;
                        }
                        else
                        {
                            SortingTheData.DiscendingSort(dataArray);
                            enumForLastProcess = EnumNextProcess.LastProcessWasDicendingOrder; 
                            Console.Clear();
                            Console.WriteLine(DisplayMessage.DiscendingOrderOutputMessage);
                            PrintDataArray(dataArray);
                            goto ShowMenu;
                        }
                    case EnumNextProcess.ChangeTheData:
                        ChangeTheData(dataArray);
                        NextProcessMenu(dataArray);
                        break;
                    case EnumNextProcess.StartWithNewData:
                        Console.Clear();
                        Program.GroupOfMeinMethodStatements();
                        break;
                    case EnumNextProcess.ExitTheProgram:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(DisplayMessage.WrongInputForOrderTypeMessage);
                        continue;
                }
            }
        }

        /// <summary>
        /// Method to change the data
        /// </summary>
        /// <param name="dataArray">data array</param>
        public static void ChangeTheData(decimal[] dataArray)
        {
            int indexofdataToBeChanged = -1;

            while (true)
            {
                Console.WriteLine(DisplayMessage.DataToBeChangedMessage);
                decimal dataToBeChanged;
                bool isDataToBeChangedValid = decimal.TryParse(Console.ReadLine(), out dataToBeChanged);
                if (isDataToBeChangedValid == false)
                {
                    Console.WriteLine(DisplayMessage.FormatExceptionmessage);
                    continue;
                }
                indexofdataToBeChanged = Array.IndexOf(dataArray, dataToBeChanged);
                if (indexofdataToBeChanged == -1)
                {
                    Console.WriteLine(DisplayMessage.DataNotFoundMessage);
                    continue;
                }
                else
                {
                    break;
                }
            }

            bool flag = true;
            while (flag)
            {
                Console.WriteLine(DisplayMessage.ProcessIdForOccurenceMessage, (int)EnumNextProcess.ChangeAllOccurence, (int)EnumNextProcess.ChangeOneOccurence);
                EnumNextProcess EnumProcessId = UserInputClass.EnumInputMethod();

                switch (EnumProcessId)
                {
                    case EnumNextProcess.ChangeOneOccurence:
                        ChangeOneOccurence(dataArray, indexofdataToBeChanged);
                        flag = false;
                        break;
                    case EnumNextProcess.ChangeAllOccurence:
                        ChangeAllOccurenceOfdata(dataArray, indexofdataToBeChanged);
                        flag = false;
                        break;
                    default:
                        Console.WriteLine(DisplayMessage.WrongInputForOrderTypeMessage);
                        flag = true;
                        break;
                }
            }

            Console.WriteLine(DisplayMessage.ExchangeMoreDataMessage, (int)EnumNextProcess.ContinueTheProcess, (int)EnumNextProcess.ChangeTheData);

            while (true)
            {
                EnumNextProcess enumForNextProcess = UserInputClass.EnumInputMethod();
                switch (enumForNextProcess)
                {
                    case EnumNextProcess.ContinueTheProcess:
                        NextProcessMenu(dataArray);
                        break;
                    case EnumNextProcess.ChangeTheData:
                        ChangeTheData(dataArray);
                        NextProcessMenu(dataArray);
                        break;
                    default:
                        Console.WriteLine(DisplayMessage.WrongInputForOrderTypeMessage);
                        continue;
                }
            }
        }

        /// <summary>
        /// Method to change one occurence of data
        /// </summary>
        /// <param name="dataArray">array of data</param>
        /// <param name="indexofdataToBeChanged">index of data  which you want to change</param>
        static void ChangeOneOccurence(decimal[] dataArray,int indexofdataToBeChanged)
        {
            Console.WriteLine(DisplayMessage.RangeForDataInputMessage, ClassOfConstants.MinRangeForData, ClassOfConstants.MaxRangeForData);
            dataArray[indexofdataToBeChanged] = UserInputClass.NewDataInput();
            Console.Clear();
        }

        /// <summary>
        /// Method to change all occurence of data
        /// </summary>
        /// <param name="dataArray">array of data</param>
        /// <param name="indexofdataToBeChanged">index of data  which you want to change</param>
        static void ChangeAllOccurenceOfdata(decimal[] dataArray, int indexofdataToBeChanged)
        {
            Console.WriteLine(DisplayMessage.RangeForDataInputMessage, ClassOfConstants.MinRangeForData, ClassOfConstants.MaxRangeForData);
            decimal dataToBechange = dataArray[indexofdataToBeChanged];
            int count = 1;
            for (int iterator = 0; iterator < dataArray.Length;iterator++)
            {
                if (dataArray[iterator] == dataToBechange)
                {
                    Console.WriteLine(DisplayMessage.PrintOccurenceMessage,ToChangeOrdinal(count));
                    dataArray[iterator] = UserInputClass.NewDataInput();
                    count+=1;
                }
            }
            Console.Clear();
        }

        /// <summary>
        /// Method Print Data Array
        /// </summary>
        /// <param name="dataArray">array of data</param>
        public static void PrintDataArray(decimal[] dataArray)
        {
            foreach (var i in dataArray)
            {
                Console.WriteLine(i);
            }
        }

        public static string ToChangeOrdinal (int NumberOfOrdinal)
        {
            string toOrdinalString = NumberOfOrdinal.ToString();
            switch(NumberOfOrdinal)
                    {
                        case 1:
                            toOrdinalString = toOrdinalString + "st";
                            break;
                        case 2:
                            toOrdinalString = toOrdinalString + "nd";
                            break;
                        case 3:
                            toOrdinalString = toOrdinalString + "rd";
                            break;
                        default:
                            toOrdinalString = toOrdinalString + "th";
                            break;
                    }
            return toOrdinalString;
        }
    }
}
