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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Create an array of the specified length
        double[] result = new double[length];

        // Step 2: Create a for loop to fill the array with multiples of the number - Multiply the number by the index + 1

        
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Determine if the rotation amount is greater than the size of the list and handle it accordingly
        
        if (amount > data.Count)
        {
            return ;
        }

        // Step 2: Get the range of elements that will be moved to the front
        List<int> toMove = data.GetRange(data.Count - amount, amount);

        // Step 3: Remove the elements that will be moved to the front from the end of the list
        data.RemoveRange(data.Count - amount, amount);

        // Step 4: Insert the removed elements at the beginning of the list
        data.InsertRange(0, toMove);

        
    }
}
