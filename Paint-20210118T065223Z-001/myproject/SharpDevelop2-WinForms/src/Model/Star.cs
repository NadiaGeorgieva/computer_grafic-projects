using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    class Star:Shape
    {

		#region Constructor

		public Star(RectangleF rect) : base(rect)
		{

		}

		public Star(RectangleShape rectangle) : base(rectangle)
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


			//взимаме точките и ги записваме в променливите
			var x_0 = Location.X;
			var y_0 = Location.Y;

			//променливата shape съдържа броя на точките
			var shape = new PointF[6];

			//променлива за радиус (големина на звездите)
			var r = 15; 

			//създаване на звезда на базата на математическа формула
			for (int i = 0; i < 6; i++)
			{
				shape[i] = new PointF(
					x_0 + r * (float)Math.Cos(i *90 * Math.PI / 110f),
					y_0 + r * (float)Math.Sin(i * 84 * Math.PI / 70f));
			}
			grfx.FillPolygon(new SolidBrush(BorderColor),shape);
			grfx.DrawPolygon(new Pen(Color), shape);
		
			
		}
	}
}
