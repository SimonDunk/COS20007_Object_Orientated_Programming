using NUnit.Framework;
using System;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class ShapeTest
	{
		[Test ()]
		public void TestShapeAt ()
		{
			Shape s = new Shape ();

			s.X = 25;
			s.Y = 25;
			s.Width = 50;
			s.Height = 50;

			Assert.IsTrue (s.IsAt (SwinGameSDK.SwinGame.PointAt (50, 50)));
			Assert.IsTrue (s.IsAt (SwinGameSDK.SwinGame.PointAt (25, 25)));
			Assert.IsFalse (s.IsAt (SwinGameSDK.SwinGame.PointAt (10, 50)));
			Assert.IsFalse (s.IsAt (SwinGameSDK.SwinGame.PointAt (50, 10)));
		}

		[Test ()]
		public void TestShapeWhenMoved ()
		{
			Shape s = new Shape ();

			s.X = 0;
			s.Y = 0;
			s.Width = 50;
			s.Height = 50;

			Assert.IsTrue (s.IsAt (SwinGameSDK.SwinGame.PointAt (25, 25)));

			s.X = 50;
			s.Y = 50;

			Assert.IsFalse (s.IsAt (SwinGameSDK.SwinGame.PointAt (25, 25)));

		}

		[Test ()]
		public void TestShapeWhenResized ()
		{
			Shape s = new Shape ();

			s.X = 0;
			s.Y = 0;
			s.Width = 50;
			s.Height = 50;

			Assert.IsTrue (s.IsAt (SwinGameSDK.SwinGame.PointAt (25, 25)));

			s.Width = 5;
			s.Height = 5;

			Assert.IsFalse (s.IsAt (SwinGameSDK.SwinGame.PointAt (25, 25)));

		}

		[Test ()]
		public void TestShapeSelect ()
		{
			Shape s = new Shape ();

			Assert.AreEqual (false, s.Selected);

			s.Selected = true;

			Assert.AreEqual (true, s.Selected);

		}

		[Test ()]
		public void TestShapeConstructor ()
		{
			Shape s = new Shape (SwinGame.ColorGreen(), 50, 55, 51, 52);

			Assert.AreEqual (SwinGame.ColorGreen(), s.Color);
			Assert.AreEqual (50, s.X);
			Assert.AreEqual (55, s.Y);
			Assert.AreEqual (51, s.Width);
			Assert.AreEqual (52, s.Height);

			s.Color = SwinGame.ColorRed();
			s.X = 5;
			s.Y = 5;
			s.Width = 5;
			s.Height = 5;

			Assert.AreEqual (SwinGame.ColorRed(), s.Color);
			Assert.AreEqual (5, s.X);
			Assert.AreEqual (5, s.Y);
			Assert.AreEqual (5, s.Width);
			Assert.AreEqual (5, s.Height);

		}
	}
}

