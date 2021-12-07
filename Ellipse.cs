using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfDrawingApp
{
    class Ellipse : Shape, IDrawable
    {

        public Ellipse()
        {
            XPosition = 100;
            YPosition = 200;
            Width = 80;
            Height = 60;
            ShapeColor = "red";
        }
        public void Draw(Canvas canvas)
        {
            System.Windows.Shapes.Ellipse ellipse = new System.Windows.Shapes.Ellipse();
            ellipse.Width = Width;
            ellipse.Height = Height;
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = TranslateStringToColor(ShapeColor);
            ellipse.Fill = brush;
            canvas.Children.Add(ellipse);
            System.Windows.Controls.Canvas.SetTop(ellipse, YPosition);
            System.Windows.Controls.Canvas.SetLeft(ellipse, XPosition);

        }
    }
}
