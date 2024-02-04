string country = Console.ReadLine();
string element = Console.ReadLine();

double evaluation = 0;

switch (country)
{
    case "Bulgaria":
        switch (element)
        {
            case "ribbon":
                evaluation = 9.600 + 9.400;
                break;
            case "hoop":
                evaluation = 9.550 + 9.750;
                break;
            default:
                evaluation = 9.500 + 9.400;
                break;
        }
        break;
    case "Italy":
        switch (element)
        {
            case "ribbon":
                evaluation = 9.200 + 9.500;
                break;
            case "hoop":
                evaluation = 9.450 + 9.350;
                break;
            default:
                evaluation = 9.700 + 9.150;
                break;
        }
        break;
    default:
        switch (element)
        {
            case "ribbon":
                evaluation = 9.100 + 9.400;
                break;
            case "hoop":
                evaluation = 9.300 + 9.800;
                break;
            default:
                evaluation = 9.600 + 9.000;
                break;
        }
        break;
}

Console.WriteLine($"The team of {country} get {evaluation:F3} on {element}.");
Console.WriteLine($"{(20 - evaluation) / 20 * 100:F2}%");