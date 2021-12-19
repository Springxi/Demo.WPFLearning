using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Demo.WPFLearning.Shape
{
    class MyPanel: Panel
    {
        private List<Visual> visuals = new List<Visual>();
        protected override Visual GetVisualChild(int index)
        {
            return visuals[index];
        }

        protected override int VisualChildrenCount => visuals.Count;


        public void AddVisual(Visual visual)
        {
            visuals.Add(visual);
            base.AddLogicalChild(visual);
            base.AddVisualChild(visual);

        }

        public void DelectVisual(Visual visual)
        {
            visuals.Remove(visual);
            base.RemoveLogicalChild(visual);
            base.RemoveVisualChild(visual);

        }
        //找到单机的时的位置
        public DrawingVisual GetVisual(Point point)
        {
            HitTestResult hitTestResult = VisualTreeHelper.HitTest(this, point);
            return hitTestResult != null ? hitTestResult.VisualHit as DrawingVisual :null;
        }

    }
}
