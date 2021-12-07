using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace WpfDrawingApp
{
    /// <summary>
    /// An object of this class represents a Circle, that is painted on a canvas.
    /// 
    /// author: Rikard Karlsson
    /// 
    /// version: 2021-10-20
    /// </summary>
    abstract class Shape
    {
        // object variables
        private int height;
        private int width;
        private int xPosition;
        private int yPosition;
        private String shapeColor;

        // properties

        public String ShapeColor
        {
            get
            {
                return shapeColor;
            }
            set
            {
                shapeColor = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
            }
        }
        public int XPosition
        {
            get
            {
                return xPosition;
            }
            set
            {
                xPosition = value;
            }
        }
        public int YPosition
        {
            get
            {
                return yPosition;
            }
            set
            {
                yPosition = value;
            }
        }
        // methods

       
        // Translate a color from a string to an object of the class Color.
        // Returns the color object.
        protected Color TranslateStringToColor(String color)
        {
            if (color.Equals("red"))
            {
                return Brushes.Red.Color;
            }
            if (color.Equals("green"))
            {
                return Brushes.Green.Color;
            }
            if (color.Equals("blue"))
            {
                return Brushes.Blue.Color;
            }
            if (color.Equals("magenta"))
            {
                return Brushes.Magenta.Color;
            }
            if (color.Equals("cyan"))
            {
                return Brushes.Cyan.Color;
            }
            if (color.Equals("yellow"))
            {
                return Brushes.Yellow.Color;
            }
            if (color.Equals("white"))
            {
                return Brushes.White.Color;
            }
            if (color.Equals("black"))
            {
                return Brushes.Black.Color;
            }
            return Brushes.Brown.Color;
        }


    }
}
