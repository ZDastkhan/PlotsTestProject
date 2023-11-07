using System.Drawing;
using ZedGraph;

namespace PlotServices
{
    public class Utils
    {       
        public static void PlotValues(ZedGraphControl plot, PlotDto plotDto)
        {            
            var zgPane = plot.GraphPane;
            zgPane.CurveList.Clear();
            zgPane.GraphObjList.Clear();

            foreach (var curve in plotDto.Curves)
            {
                var list1 = new PointPairList();
                for (int i = 0; i < curve.Values.Count; i++)
                    list1.Add(curve.Values[i].X, curve.Values[i].Y);

                var curve1 = zgPane.AddCurve(curve.Name, list1, curve.SymbolColor, SymbolType.Circle);
                curve1.Symbol.Fill = new Fill(curve.SymbolColor);
                curve1.Symbol.IsVisible = curve.IsSymbolVisible;
                curve1.Symbol.Size = 6;
                curve1.Line.Color = curve.LineColor;
                curve1.Line.Width = 2;
                curve1.Line.IsVisible = curve.IsLineVisible;
                curve1.Line.IsAntiAlias = true;
            }

            zgPane.XAxis.Title.Text = plotDto.XAxisLabel;
            zgPane.YAxis.Title.Text = plotDto.YAxisLabel;
            zgPane.Title.IsVisible = !string.IsNullOrEmpty(plotDto.Title);
            zgPane.Title.Text = plotDto.Title;
            zgPane.IsFontsScaled = false;
            zgPane.IsPenWidthScaled = false;
            zgPane.Legend.Border.IsVisible = false;
            zgPane.XAxis.MajorGrid.IsVisible = true;
            zgPane.YAxis.MajorGrid.IsVisible = true;
            zgPane.XAxis.MajorGrid.DashOff = (float)0.0;
            zgPane.YAxis.MajorGrid.DashOff = (float)0.0;

            plot.AxisChange();
            plot.Refresh();
            plot.RestoreScale(zgPane);                    
        }
    }
}
