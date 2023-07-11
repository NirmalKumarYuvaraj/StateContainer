using Syncfusion.Maui.Core;
using System.ComponentModel;
using Xamarin.Google.Crypto.Tink.Proto;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        viewModel.CurrentState = "Loaded";
	}

}

public class ViewModel1 : INotifyPropertyChanged
{
       
    private string _currentState = "Loaded";
    public string CurrentState
    {
        get => _currentState;
        set
        {
            _currentState = value;
            NotifyPropertyChanged(nameof(CurrentState));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}

public class CustomBoxView : BoxView
{
    public CustomBoxView()
    {
        BackgroundColor = Colors.Red;
    }
    protected override Size MeasureOverride(double widthConstraint, double heightConstraint)
    {
        return base.MeasureOverride(widthConstraint, heightConstraint);
    }

    protected override Size ArrangeOverride(Rect bounds)
    {
        return base.ArrangeOverride(bounds);
    }
}

