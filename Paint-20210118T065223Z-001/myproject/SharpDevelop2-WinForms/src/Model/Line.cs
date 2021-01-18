using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    class Line:Shape
    {
		#region Constructor

		public Line(RectangleF rect) : base(rect)
		{

		}

		public Line(RectangleShape rectangle) : base(rectangle)
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

			var x_0 = Location.X;
			var y_0 = Location.Y;

			//променливата shape съдържа броя на точките
			var line = new PointF[6];

			//променлива за радиус (големина на линията)
			var r = 15;

			//създаване на линия на базата на математическа формула
			for (int i = 0; i < 6; i++)
			{
				line[i] = new PointF(
					x_0 + r * (float)Math.Cos(i * 90 * Math.PI / 100f),
					y_0 + r * (float)Math.Sin(i * 40 * Math.PI / 40f));
			}
			
			grfx.DrawPolygon(new Pen(Color), line);

		}
	}
}
