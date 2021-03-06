using NUnit.Framework;
using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
	[TestFixture ()]
	public class SelectShapeTest
	{
		[Test ()]
		public void TestCase ()
		{
			Drawing myDrawing = new Drawing();
			Shape[] testShapes = {
					new Shape(Color.Red, 25, 25, 50, 50),
					new Shape(Color.Green, 25, 10, 50, 50),
					new Shape(Color.Blue, 10, 25, 50, 50) };

			foreach(Shape s in testShapes) myDrawing.AddShape( s ); 

			List<Shape> selected;
			Point2D point;

			point = SwinGame.PointAt( 70, 70 );
			myDrawing.SelectShapesAt( point );
			selected = myDrawing.SelectedShapes;
			CollectionAssert.Contains( selected, testShapes[0] );
			Assert.AreEqual( 1, selected.Count );

			point = SwinGame.PointAt( 70, 50 );
			myDrawing.SelectShapesAt( point );
			selected = myDrawing.SelectedShapes;
			CollectionAssert.Contains( selected, testShapes[0] );
			CollectionAssert.Contains( selected, testShapes[1] );
			Assert.AreEqual( 2, selected.Count );

		}
	}
}

