int CalculateEvenSum(int limit) {
    List<int> evenNumbers = new List<int>();

    for (int i = 1; i <= limit; i++) {
        if (i % 2 == 0) {
            evenNumbers.Add(i);
        }
    }

    int totalSum = 0;
    foreach (int num in evenNumbers) {
        totalSum += num;
    }

    return totalSum;
}