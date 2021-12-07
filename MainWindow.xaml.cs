using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
//using System.Windows.Shapes;

namespace WpfDrawingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Picture picture;
        public MainWindow()
        {
            InitializeComponent();
            picture = new Picture();

            Rectangle rectangle = new Rectangle();
            picture.Add(rectangle);
        }

        private void drawCircle_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            picture.Add(ellipse);
            picture.Draw(myCanvas);
        }

        private void shapes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (shapes.SelectedItem != null)
            {

                String selectedShape = shapes.SelectedItem;
                if (selectedShape == "circle")
                {
                    output.Text = "circle";
                }
                else
                {
                    output.Text = selectedShape;
                }
            }
        }
    }
}
