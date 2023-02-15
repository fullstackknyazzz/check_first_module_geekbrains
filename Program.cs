
string[] cars = {"Volvo", "BMW", "Ford", "Mazda", "Toyota"};


string [] returnArrayWithThreeSymbols (string [] array) {
    int countNewArrayWithThreeSymbols = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length <= 3) {
            countNewArrayWithThreeSymbols++;
        }
    }
    string [] newArrayWithThreeSymbols = new string [countNewArrayWithThreeSymbols];
    for (int i = 0, k = 0; i < array.Length; i++) {
        if (array[i].Length <= 3) {
            newArrayWithThreeSymbols[k] = array[i];
            k++;
        }
    }
    return newArrayWithThreeSymbols;
}

void printArray(string [] array) {
    for (int i = 0; i < array.Length; i++) {
        if ((array.Length - 1) == i) {
            Console.Write($"\"{array[i]}\"");
        } else {
            Console.Write($"\"{array[i]}\", ");
        }
    }
}

Console.Write("[");
printArray(cars);
Console.Write("]");
Console.Write(" -> ");
Console.Write("[");
printArray(returnArrayWithThreeSymbols(cars));
Console.Write("]");