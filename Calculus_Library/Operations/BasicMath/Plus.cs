﻿using Calculus_Library.Interfaces;
using Calculus_Library.Operations.Base;
using System.Numerics;

namespace Calculus_Library.Operations.BasicMath
{
    public class Plus<T> : BinaryOperation<T> where T : INumber<T>
    {
        public Plus(IValue<T> a, IValue<T> b) : base(a, b)
        {
        }
        public override T Execute()
        {
            return a_value.GetValue() + b_value.GetValue();
        }
    }
}