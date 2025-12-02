Console.WriteLine("Testando operações lógicas no .NET 8:");

bool Or(bool left, bool right) => left || right;
bool And(bool left, bool right) => left && right;
bool Xor(bool left, bool right) => left ^ right;

Console.WriteLine($"Or(true, false) = {Or(true, false)}");
Console.WriteLine($"And(true, false) = {And(true, false)}");
Console.WriteLine($"Xor(true, false) = {Xor(true, false)}");