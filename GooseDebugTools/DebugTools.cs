using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using GooseShared;

namespace GooseDebugTools
{
    static class DebugTools
    {
        private static Color _background = Color.FromArgb(255, Color.Black),
            _text = ColorTranslator.FromHtml("#4AF626");

        public static SolidBrush _brushBackground = new SolidBrush(_background),
            _brushText = new SolidBrush(_text);

        public static void OutputLine(GooseEntity g, Graphics graph, int lineNum, string txt)
        {
            Size txtLen = graph.MeasureString(txt, SystemFonts.DefaultFont).ToSize();
            PointF txtPos = new PointF(g.position.x + 25, g.position.y + 25 + 14 * lineNum);

            graph.FillRectangle(_brushBackground, new Rectangle(Point.Round(txtPos), txtLen));
            graph.DrawString(txt, SystemFonts.DefaultFont, _brushText, txtPos);

            lineNum++;
        }
    }
}
