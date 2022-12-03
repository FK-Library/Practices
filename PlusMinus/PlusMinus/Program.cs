
using PlusMinus;

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.plusMinus(arr);

Console.ReadKey();

/**
    test cases:
    5
    0 0 -1 1 1
    =>
    0.400000
    0.200000
    0.400000
  
    6
    -4 3 -9 0 4 1
    =>
    0.500000
    0.333333
    0.166667
 */
