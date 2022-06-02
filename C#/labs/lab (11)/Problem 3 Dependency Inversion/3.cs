
using Problem_3_Dependency_Inversion;

PrimitiveCalculator primitiveCalculator = new PrimitiveCalculator();

while (true)
{
    string str = Console.ReadLine();

    if (str.ToLower() == "end")
        break;
    string[] arrStr = str.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    if(arrStr[0] == "mode")
    {
        primitiveCalculator.ChangeStrategy(arrStr[1][0]);
    }
    else
    {
        primitiveCalculator.PerformCalculation(int.Parse(arrStr[0]), int.Parse(arrStr[1]));
    }
}
