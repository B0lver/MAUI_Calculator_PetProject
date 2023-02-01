using Calculus_Library.Operations.Base;
using Calculus_Library.Operations.BasicMath;

Plus<int> operation1 = new(new BaseValue<int>(3), new BaseValue<int>(2));
Minus<int> operation2 = new(operation1, new BaseValue<int>(1));
var operation3 = new Multiply<int>(operation2, new BaseValue<int>(9));

var res = operation3.GetValue();

Console.WriteLine(res);
Console.ReadLine();