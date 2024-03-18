namespace BasicSorting_Yagnik_007
{
    /// <summary>
    /// Class for sorting data
    /// </summary>
    class SortingTheData
    {
        /// <summary>
        /// Method for ascending order
        /// </summary>
        /// <param name="dataArray"></param>
        public static void AscendingSort(decimal[] dataArray)
        {
            for (int iteratorInDataArray = 0; iteratorInDataArray < dataArray.Length - 1; iteratorInDataArray++)
            {
                for (int iteratorToAccessData = 0; iteratorToAccessData < dataArray.Length - iteratorInDataArray - 1; iteratorToAccessData++)
                {
                    decimal tempVariable = 0;
                    if (dataArray[iteratorToAccessData] > dataArray[iteratorToAccessData + 1])
                    {
                        tempVariable = dataArray[iteratorToAccessData];
                        dataArray[iteratorToAccessData] = dataArray[iteratorToAccessData + 1];
                        dataArray[iteratorToAccessData + 1] = tempVariable;
                    }
                }
            }                   
        }

        /// <summary>
        /// Method for Discending sort
        /// </summary>
        /// <param name="dataArray">Array of data</param>
        public static void DiscendingSort(decimal[] dataArray)
        {
            for (int iteratorInDataArray = 0; iteratorInDataArray < dataArray.Length - 1; iteratorInDataArray++)
            {
                for (int iteratorToAccessData = 0; iteratorToAccessData < dataArray.Length - iteratorInDataArray - 1; iteratorToAccessData++)
                {
                    decimal tempVariable = 0;
                    if (dataArray[iteratorToAccessData] < dataArray[iteratorToAccessData + 1])
                    {
                        tempVariable = dataArray[iteratorToAccessData];
                        dataArray[iteratorToAccessData] = dataArray[iteratorToAccessData + 1];
                        dataArray[iteratorToAccessData + 1] = tempVariable;
                    }
                }
            }
        }
    }
}
