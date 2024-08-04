double CalculateFormula(int a, int b, int c, int d)
{
    double numentator = a * b;
    int denumetatot = c + d;
    double result = numentator / denumetatot;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);