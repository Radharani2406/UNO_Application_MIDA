namespace MIDAMiagrationProject.Presentation;
using System.Windows;
using Microsoft.Graphics.Display;



public sealed partial class Shell : UserControl
{
    public Shell()
    {
        this.InitializeComponent();
        // contentFrame.Navigate(typeof(MainPage));
    }

   

    private void NavigationExpanderToggleButton_Checked(object sender, RoutedEventArgs e)
    {

    }

    private void NavigationExpanderToggleButton_Unchecked(object sender, RoutedEventArgs e)
    {

    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
        //// Get the display information
        //var displayInfo = DisplayInformation.

        //// Get the screen width and height
        //double screenWidth = displayInfo.ScreenWidthInRawPixels;
        //double screenHeight = displayInfo.ScreenHeightInRawPixels;

        //// Set the grid's width and height
        //ToTransform.Width = screenWidth;
        //ToTransform.Height = screenHeight;
    }
    //public ContentControl ContentControl => Splash;
}
