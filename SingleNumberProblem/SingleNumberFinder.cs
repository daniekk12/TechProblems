using SingleNumber;

namespace SingleNumberAlgorithm
{
    public class SingleNumberFinder : ISingleNumberFinder
    {
        public int FindSingleNumber(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return numbers[0];
            }
            Dictionary<int, int> occurrences = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                occurrences.TryGetValue(number, out int count);
                occurrences[number] = count + 1;
            }
            return occurrences.First(x => x.Value == 1).Key;
        }
    }
}