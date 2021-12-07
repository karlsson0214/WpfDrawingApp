using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfDrawingApp
{
    class Rectangle : Shape, IDrawable
    {

        public Rectangle()
        {
            XPosition = 300;
            YPosition = 100;
            Width = 120;
            Height = 80;
            ShapeColor = "green";
        }
        public void Draw(Canvas canvas)
        {
            System.Windows.Shapes.Rectangle rectangle = new System.Windows.Shapes.Rectangle();
            rectangle.Width = Width;
            rectangle.Height = Height;
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = TranslateStringToColor(ShapeColor);
            rectangle.Fill = brush;
            canvas.Children.Add(rectangle);
            System.Windows.Controls.Canvas.SetTop(rectangle, YPosition);
            System.Windows.Controls.Canvas.SetLeft(rectangle, XPosition);

        }
    }
}
