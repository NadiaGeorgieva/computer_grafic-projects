using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    class SquareShape:Shape
    {
		#region Constructor

		public SquareShape(RectangleF rect) : base(rect)
		{
		}

		public SquareShape(RectangleShape rectangle) : base(rectangle)
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

			grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawRectangle(new Pen(BorderColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

		}
	}
}
