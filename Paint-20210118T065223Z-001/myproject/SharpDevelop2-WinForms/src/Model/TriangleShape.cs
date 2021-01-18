using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    class TriangleShape:Shape
    {
        #region Constructor

        TriangleShape(RectangleF rect) : base(rect)
        {

        }
        public TriangleShape(RectangleShape rectangle) : base(rectangle)
        {
        }

        #endregion
        public override bool Contains(PointF point)
        {
            if (base.Contains(point))

                return true;
            else

                return false;
        }
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            System.Drawing.PointF[] points = {
            new System.Drawing.PointF(Location.X+Width/2, Location.Y),
            new System.Drawing.PointF(Location.X+Width, Location.Y+Height),
            new System.Drawing.PointF(Location.X, Location.Y+Height)
             }; 

            grfx.FillPolygon(new SolidBrush(FillColor),points);
            grfx.DrawPolygon(new Pen(BorderColor), points);
          
        }
    }
}
