// email@example.com
// EmAiL@ExAmPle.COM



string emailMixCase = "EmAiL@ExAmPle.COM";
string emailLowercase = "email@example.com";

if (emailMixCase.ToLower() == emailLowercase.ToLower())
{
    Console.WriteLine("Emails match");
}

Console.WriteLine("End of program");