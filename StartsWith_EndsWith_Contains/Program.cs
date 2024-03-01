
// StartsWith
string originalString = "https://google.com";

if (originalString.StartsWith("HTTPS://", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("This is a secure link");
}
else
{
    Console.WriteLine("This is not a secure link");
}


// EndsWith
string fileName = "filename.mp4";

bool result = fileName.EndsWith(".jpg");

if (result)
{
    Console.WriteLine("This is an Image file");
}
else if (fileName.EndsWith(".mp4"))
{
    Console.WriteLine("This is a video file");
}
else
{
    Console.WriteLine("This is an unknown file type");
}



// Contains Method
string[] cities = { "New Delhi", "Los Angeles", "Toronto", "London", "Hanoi" };

string userTypedText = "ano";

foreach (string city in cities)
{
    if (city.Contains(userTypedText, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("City was found");
        break;
    }
}
