using Calculus_Library.Operations.Base;
using Calculus_Library.Operations.BasicMath;

Plus operation1 = new(new BaseValue(3), new BaseValue(2));
Minus operation2 = new(operation1, new BaseValue(1));
Multiply operation3 = new(operation2, new BaseValue(9));
Divide operation4 = new(operation3, new BaseValue(35));

var res = operation4.GetValue();

Console.WriteLine(res);
Console.ReadLine();