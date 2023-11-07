using PlotServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace SimplePlots
{
    public partial class MainForm : Form
    {
        private Random _random = new Random();

        public MainForm()
        {
            InitializeComponent();

            GraphPane graphPane = zedGraphControl.GraphPane;
            zedGraphControl.Resize += new EventHandler(this.zedGraphControl_Resize);
            graphPane.AxisChangeEvent += new GraphPane.AxisChangeEventHandler(graphPane_AxisChangeEvent);
        }

        private void btnCreateRandom_Click(object sender, EventArgs e)
        {
            var plotDto = CreateTestData();
            Utils.PlotValues(zedGraphControl, plotDto);
        }

        private PlotDto CreateTestData()
        {
            var curve1 = new CurveData();
            curve1.Name = "Data";

            var xOffset = 1.5 * _random.NextDouble();
            var yOffset = 1.5 * _random.NextDouble();

            for (int i = 0; i < 5; i++)
            {
                double x = xOffset + i;
                var y = yOffset + x + _random.NextDouble() * 1.5;
                curve1.Values.Add(new PointF((float)x, (float)y));
            }

            var plotDto = new PlotDto
            {
                XAxisLabel = "X",
                YAxisLabel = "Y",
                Curves = new List<CurveData> { curve1 }
            };

            return plotDto;
        }

        private void pnlMain_SizeChanged(object sender, EventArgs e)
        {
            //no data to show -> return
            if (!zedGraphControl.GraphPane.CurveList.Any())
                return;            
        }

        private void zedGraphControl_Resize(object sender, EventArgs e)
        {
            zedGraphControl.AxisChange();
        }

        private void graphPane_AxisChangeEvent(GraphPane target)
        {
            GraphPane graphPane = zedGraphControl.GraphPane;
            
            //force 1:1 aspect ration
            var scalex2 = (graphPane.XAxis.Scale.Max - graphPane.XAxis.Scale.Min) / graphPane.Rect.Width;    
            var scaley2 = (graphPane.YAxis.Scale.Max - graphPane.YAxis.Scale.Min) / graphPane.Rect.Height;    
            if (scalex2 > scaley2)    
            {        
                var diff = graphPane.YAxis.Scale.Max - graphPane.YAxis.Scale.Min;        
                var new_diff = graphPane.Rect.Height * scalex2;        
                graphPane.YAxis.Scale.Min -= (new_diff - diff) / 2.0;        
                graphPane.YAxis.Scale.Max += (new_diff - diff) / 2.0;
                graphPane.YAxis.Scale.MajorStep = graphPane.XAxis.Scale.MajorStep;
            }    
            else if (scaley2 > scalex2)    
            {        
                var diff = graphPane.XAxis.Scale.Max - graphPane.XAxis.Scale.Min;        
                var new_diff = graphPane.Rect.Width * scaley2;        
                graphPane.XAxis.Scale.Min -= (new_diff - diff) / 2.0;        
                graphPane.XAxis.Scale.Max += (new_diff - diff) / 2.0;
                graphPane.XAxis.Scale.MajorStep = graphPane.YAxis.Scale.MajorStep;
            }    
            
            //recompute the grid lines
            var scaleFactor = graphPane.CalcScaleFactor();    
            Graphics g = zedGraphControl.CreateGraphics();    
            graphPane.XAxis.Scale.PickScale(graphPane, g, scaleFactor);    
            graphPane.YAxis.Scale.PickScale(graphPane, g, scaleFactor);
        }
    }
}
