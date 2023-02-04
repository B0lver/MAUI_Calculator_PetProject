using Calculus_Library.Interfaces;
using Calculus_Library.Operations.Base;
using System.Linq.Expressions;

namespace Calculus_Maui_Controls.Components;

public partial class CommonOperationView : ContentView
{
    public CommonOperationView()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        if (this.BindingContext is not IValue val)
        {
            return;
        }
        ref_ContentHolder.Children.Clear();
        if (val is not ICalculusOperation operation) // BaseValue
        {
            BaseValueView view = new()
            {
                BindingContext = val,
            };
            ref_ContentHolder.Children.Add(view);
            return;
        }
        if (operation is UnaryOperation unaryOperation) // UnaryOperation
        {
            UnaryOperationView view = new()
            {
                BindingContext = unaryOperation,
            };
            ref_ContentHolder.Children.Add(view);
            return;
        }
        if (operation is BinaryOperation binaryOperation) // BinaryOperation
        {
            BinaryOperationView view = new()
            { 
                BindingContext = binaryOperation, 
            };
            ref_ContentHolder.Children.Add(view); 
            return;
        }
    }
}