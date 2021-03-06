using NUnit.Framework;
using System;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class DrawingUnitTest
	{
		[Test ()]
		public void TestCase ()
		{
			Drawing drawing = new Drawing ();
			Assert.AreEqual (SwinGame.ColorWhite(), drawing.Colour);

			Drawing drawing2 = new Drawing (SwinGame.ColorRed());
			Assert.AreEqual(SwinGame.ColorRed(), drawing2.Colour);
		}

		[Test ()]
		public void RemoveShapeTest ()
		{
			Drawing drawing = new Drawing ();
			Rectangle s = new Rectangle ();
			drawing.AddShape (s);
			Rectangle sh = new Rectangle (Color.AliceBlue, 100, 100, 50, 50);
			drawing.AddShape (sh);
			Assert.AreEqual (2, drawing.ShapeCount);
			drawing.RemoveShape (sh);
			Assert.AreEqual (1, drawing.ShapeCount);

			Assert.False (sh.Selected);
		}
	}
}

