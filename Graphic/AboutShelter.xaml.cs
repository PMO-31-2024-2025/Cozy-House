using System.Windows;

namespace Graphic
{
    public partial class AboutShelter : Window
    {
        public AboutShelter()
        {
            InitializeComponent();
        }
    }
    //private void ShowContextMenu(object sender, MouseButtonEventArgs e)
    //{
    //    var element = sender as UIElement;
    //    var text = (sender as TextBlock)?.Text ?? "";

    //    var contextMenu = new ContextMenu();
    //    var position = e.GetPosition(null);

    //    if (position.X + 200 > SystemParameters.PrimaryScreenWidth)
    //    {
    //        position.X = SystemParameters.PrimaryScreenWidth - 200;
    //    }

    //    if (position.Y + 150 > SystemParameters.PrimaryScreenHeight)
    //    {
    //        position.Y = SystemParameters.PrimaryScreenHeight - 150;
    //    }

    //    contextMenu.Show(position, element, text);

    //}
}