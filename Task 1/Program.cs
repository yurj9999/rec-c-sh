class Checker
{
    public static int[] GetNumbersFromInterval(int from, int to)
    {
        List<int> result = new List<int>();

        for (int i = from; i < to + 1; i++) {
            result.Add(i);
        }

        return result.ToArray();
    }

    public static int[] CheckNumbersForNatural(int[] numbers, int counter, List<int> preparedData)
    {
        if (counter == numbers.Length) {
            return preparedData.ToArray();
        }

        if (numbers[counter] > 0) {
            preparedData.Add(numbers[counter]);
        }

        counter++;
        
        return CheckNumbersForNatural(numbers, counter, preparedData);
    }

    public static void ShowNaturalNumbers(int[] numbers)
    {
        List<int> preparedData = new List<int>();
        int counter = 0;

        int[] result = CheckNumbersForNatural(numbers, counter, preparedData);

        Console.WriteLine(string.Join(", ", result));
    }
}

class NaturalNumber
{
    public static void Main()
    {
        int M = 3;
        int N = 5;

        int[] data = Checker.GetNumbersFromInterval(M, N);
        Checker.ShowNaturalNumbers(data);
    }
}
