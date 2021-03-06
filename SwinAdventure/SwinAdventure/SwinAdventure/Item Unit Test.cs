using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class Item_Unit_Test
	{

		/// <summary>
		/// Tests the item is identifiable by responding to AreYou requests based on the identifiers it is created with.
		/// </summary>
		[Test ()]
		public void TestItemisIdentifiable ()
		{
			Item obj = new Item (new string[]{ "obj1", "axe"}, "axe", "normally used to cut wood" );

			Assert.IsTrue (obj.AreYou ("obj1"), "should be true");
		}

		/// <summary>
		/// Tests the short description returns the string "a name (first_id)".
		/// </summary>
		[Test ()]
		public void TestShortDescription()
		{
			Item obj = new Item (new string[]{ "obj1", "tool1"}, "axe", "normally used to cut wood" );

			Assert.AreEqual (obj.ShortDescription, "axe", "should be true");
		}

		/// <summary>
		/// Tests the full description is returned.
		/// </summary>
		[Test ()]
		public void TestFullDescription()
		{
			Item obj = new Item (new string[]{ "obj1", "tool1"}, "axe", "normally used to cut wood" );

			Assert.AreEqual (obj.FullDescription, "normally used to cut wood", "should be true");
		}


	}
}

