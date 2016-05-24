﻿using System;
using System.Drawing;

using Foundation;
using UIKit;
using Steema.TeeChart;

namespace Simple_Chart
{
    public partial class RootViewController : UIViewController
    {
        public RootViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        TChart Chart;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Creating the Chart component
            Chart = new TChart();
            // Setting the Chart bounds
            Chart.Frame = View.Frame;

            // 2D Chart
            Chart.Aspect.View3D = false;

            // Customizing the Axes grid appearance
            Chart.Axes.Bottom.Grid.Visible = false;
            Chart.Axes.Bottom.MinorTicks.Visible = false;

            // Setting a custom left axis increment, and axis pen width, and other properties
            Chart.Axes.Left.Increment = 12.5;
            Chart.Axes.Left.AxisPen.Width = 1;
            Chart.Axes.Bottom.AxisPen.Width = 1;
            Chart.Axes.Left.MaximumOffset = 12;
            Chart.Axes.Left.AxisPen.Visible = false;

            // Chaging the Legend, Panel and Walls appearance
            Chart.Legend.Transparent = true;
            Chart.Legend.Alignment = LegendAlignments.Bottom;
            Chart.Walls.Back.Visible = false;
            Chart.Panel.Gradient.Visible = false;            

            // Allow to Zoom and Pan over the Chart Series
            Chart.Panning.Active = true;
            Chart.Zoom.Active = true;

            // Creating the Chart Series (Bar series in that case)
            Steema.TeeChart.Styles.Bar bar1 = new Steema.TeeChart.Styles.Bar(Chart.Chart);
            Steema.TeeChart.Styles.Bar bar2 = new Steema.TeeChart.Styles.Bar(Chart.Chart);

            // Customizing the Series Bar aspect
            // bar1.ColorEach = true;

            bar1.CustomBarWidth = 30;
            bar2.CustomBarWidth = 30;

            bar1.Color = Color.FromArgb(255, 156, 73, 181);
            bar1.Pen.Visible = false;
            bar2.Color = Color.FromArgb(255, 107,38,131);
            bar2.Pen.Visible = false;

            // Addign data to the Bar1 and Bar2 Series
            bar1.Add(12.5);
            bar1.Add(40);
            bar1.Add(15.5);
            bar1.Add(12.5);
            bar1.Add(6);

            bar2.Add(14.5);
            bar2.Add(37.5);
            bar2.Add(13.5);
            bar2.Add(14);
            bar2.Add(4);

            // Hiding Series Marks
            bar1.Marks.Visible = false;
            bar2.Marks.Visible = false;

            // Other way to customize the Bar Series
            // (Chart.Series[0] as Steema.TeeChart.Styles.Bar).Marks.Visible = true;

            /*
             * Here creating several Line Series
            Steema.TeeChart.Styles.Line line1 = new Steema.TeeChart.Styles.Line(Chart.Chart);
            Steema.TeeChart.Styles.Line line2 = new Steema.TeeChart.Styles.Line(Chart.Chart);
            Steema.TeeChart.Styles.Line line3 = new Steema.TeeChart.Styles.Line(Chart.Chart);
            Steema.TeeChart.Styles.Line line4 = new Steema.TeeChart.Styles.Line(Chart.Chart);

            for (int i=0;i<Chart.Series.Count;i++)
            {                
                Chart.Series[i].FillSampleValues(4);  // Using random data
                (Chart.Series[i] as Steema.TeeChart.Styles.Line).LinePen.Width = 3;
                (Chart.Series[i] as Steema.TeeChart.Styles.Line).Pointer.Visible = true;
                (Chart.Series[i] as Steema.TeeChart.Styles.Line).Pointer.Pen.Visible = false;
            }
            */

            // Left axis title mods
            Chart.Axes.Left.Title.Text = "This is a title";
            Chart.Axes.Left.Title.Angle = 90;
            Chart.Axes.Left.Title.Visible = true;

            // Right axis title mods
            Chart.Axes.Right.Title.Text = "This is a title";
            Chart.Axes.Right.Title.Angle = 90;
            

            // Setting both vertical axes visible for the Bar Series if desired
            // (Chart.Series[0] as Steema.TeeChart.Styles.Bar).VertAxis = Steema.TeeChart.Styles.VerticalAxis.Both;

          
            // Finally adding the Chart View as SubView to the parent View
            View.AddSubview(Chart);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}
 
 