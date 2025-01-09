public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //Creating a variable to store an array of numbers
        var result = new double[length];
        //Starting index variable
        var index = 0;

        //Loop through the length, adding the multiplication result
        //to each index in the array
        for (int i = 1; i <= length; i++)
        {
            result[index] = number * i;
            index++;
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //Get the last numbers from the list
        //according to the amount value
        var lastNumbers = data.TakeLast(amount).ToList();

        //Remove these numbers from the list
        data.RemoveRange(data.Count - amount, amount);

        //Add them to the beginning of the list
        data.InsertRange(0, lastNumbers);

    }
}
