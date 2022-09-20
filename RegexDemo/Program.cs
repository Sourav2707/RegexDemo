using RegexDemo;

Patterns patterns = new Patterns();
//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
if (patterns.validateString("625017"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
Console.ReadKey();