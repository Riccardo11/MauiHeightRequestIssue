namespace MauiHeightRequestIssue;

/*
 * TO TEST THE WORKAROUND
 * - Uncomment the PropertyChanged event
 * - Remove from the xaml this line: HeightRequest="{Binding Source={RelativeSource Self}, Path=Width}"
 */

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        // ***** UNCOMMENT THIS TO TEST THE WORKAROUND ******
        // Circle.PropertyChanged += Circle_PropertyChanged;
	}

    // ***** UNCOMMENT THIS TO TEST THE WORKAROUND ******
    //private async void Circle_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    //{
    //    if (e.PropertyName == "Width")
    //    {
    //        await Task.Delay(1);  // this is necessary!!
    //        Circle.HeightRequest = Circle.Width;
    //    }
    //}
}

