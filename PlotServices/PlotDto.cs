using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotServices
{
    public class PlotDto
    {
        public string Title { get; set; }
        public string XAxisLabel { get; set; }
        public string YAxisLabel { get; set; }
        public List<CurveData> Curves { get; set; }
        public int PlotWidth { get; set; }
        public int PlotHeigth { get; set; }

        public PlotDto()
        {
            Curves = new List<CurveData>();
            PlotWidth = 400;
            PlotHeigth = 300;
        }
    }
}
