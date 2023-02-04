using Calculus_Library.Operations.Base;

namespace Calculus_Maui_Controls.Components;

public partial class BinaryOperationView : ContentView
{
	public BinaryOperationView()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
		if (this.BindingContext is not BinaryOperation operation)
		{
			return;
		}
		prefix_label.Text = operation.Extension.GetPrefix();
		middle_symbol.Text = operation.Extension.GetMiddleSymbol();
		suffix_label.Text = operation.Extension.GetSuffix();
    }
}