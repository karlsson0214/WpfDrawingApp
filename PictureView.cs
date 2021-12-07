using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace WpfDrawingApp
{
    class PictureView
    {
        public void Draw(Canvas canvas, List<IDrawable> drawables)
        {
            canvas.Children.Clear();
            foreach(IDrawable drawable in drawables)
            {

            }

        }
    }
}
