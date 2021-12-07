using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace WpfDrawingApp
{
    interface IDrawable
    {
        public void Draw(Canvas canvas);
    }
}
