using NUnit.Framework;
using System;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class TestAddShape
	{
		[Test ()]
		public void TestCase ()
		{
			Drawing myDrawing = new Drawing ();
			int count = myDrawing.ShapeCount;

			Assert.AreEqual (0, count, "Drawing should start with no shapess");

			myDrawing.AddShape (new Shape ());
			myDrawing.AddShape (new Shape ());
			count = myDrawing.ShapeCount;

			Assert.AreEqual (2, count, "Drawing should have 2 shapess");

		}
	}
}

