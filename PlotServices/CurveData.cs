using System.Collections.Generic;
using System.Drawing;

namespace PlotServices
{
    public class CurveData
    {
        public List<PointF> Values { get; set; }
        public string Name { get; set; }
        public bool IsSymbolVisible { get; set; }
        public bool IsLineVisible { get; set; }
        public Color SymbolColor { get; set; }
        public Color LineColor { get; set; }
        public CurveData()
        {
            Values = new List<PointF>();
            IsSymbolVisible = true;
            IsLineVisible = true;
            LineColor = Color.Blue;
            SymbolColor = Color.Red;
        }

    }
}
