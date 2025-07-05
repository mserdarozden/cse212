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
        // Create an array to hold the results
        var results = new double[length];

        // Initialize an index to keep track of the current position in the array
        var index = 0;

        // Loop from 1 to length, multiplying the number by the loop variable
        for (var i = 1; i <= length; i++)
        {
            results[index++] = number * i; // Store the multiple in the array
        }

        // Return the array of multiples
        return results;
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
        // Find the index where the rotation should start
        var index = data.Count - amount;

        // Get the last 'amount' elements that will be moved to the front
        List<int> lastPart = data.GetRange(index, amount);

        // Get the first part of the list that will be moved after the rotated part
        List<int> firstPart = data.GetRange(0, index);

        // Combine the rotated part with the remaining part
        lastPart.AddRange(firstPart);

        // Clear the original list
        data.Clear();

        // Add the rotated elements back to the original list
        data.AddRange(lastPart);
    }
}
