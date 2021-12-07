using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace WpfDrawingApp
{
    class Picture
    {
        private List<IDrawable> drawables = new List<IDrawable>();

        public void Add(IDrawable drawable)
        {
            drawables.Add(drawable);
        }

        public void Draw(Canvas canvas)
        {
            canvas.Children.Clear();
            foreach (IDrawable drawable in drawables)
            {
                drawable.Draw(canvas);
            }
        }


    }
}
