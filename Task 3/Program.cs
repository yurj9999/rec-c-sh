class Utils
{
    public static int[] HelperReverce(int[] arr, int counter, List<int> preparedData) {
        if (counter == 0) {
            return preparedData.ToArray();
        }

        preparedData.Add(arr[counter - 1]);
        counter--;

        return HelperReverce(arr, counter, preparedData);
    }

    public static int[] Reverce(int[] arr) {
        List<int> preparedData = new List<int>();

        int counter = arr.Length;

        int[] result = HelperReverce(arr, counter, preparedData);

        return result;
    }
}

class ArrayReverced
{
    public static void Main()
    {
        int[] arr = {1, 2, 3, 4, 5, 6};

        int[] result = Utils.Reverce(arr);

        Console.WriteLine(string.Join(" ", result));
    }
}
