using NUnit.Framework;
using System;

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
	}
}

