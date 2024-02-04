string product = Console.ReadLine();
string type = "";

switch (product)
{
    case "banana":
    case "apple":
    case "kiwi":
    case "cherry":
    case "lemon":
    case "grapes":
        type = "fruit";
        break;
    case "tomato":
    case "cucumber":
    case "pepper":
    case "carrot":
        type = "vegetable";
        break;
    default:
        type = "unknown";
        break;
}

Console.WriteLine(type);
