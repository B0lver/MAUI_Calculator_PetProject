using Calculus_Library.Operations.Base;

namespace Calculus_Maui_Controls.Components;

public partial class UnaryOperationView : ContentView
{
	public UnaryOperationView()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
		if (this.BindingContext is not UnaryOperation operation)
		{
			return;
		}
		prefix_label.Text = operation.UnaryExtension.GetPrefix();
		suffix_label.Text = operation.UnaryExtension.GetSuffix();
    }
}