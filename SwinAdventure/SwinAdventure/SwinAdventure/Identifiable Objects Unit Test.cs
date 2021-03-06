using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class Identifiable_Objects_Unit_Test
	{
		[Test ()]
		public void TestCreation ()
		{
			Identifiable_Object obj = new Identifiable_Object (new string[]{ "obj1", "obj2" });


			Assert.IsNotNull (obj, "should have 2 objects");
		}

		[Test ()]
		public void TestAreYou()
		{
			Identifiable_Object obj = new Identifiable_Object (new string[]{ "obj1", "obj2" });

			Assert.IsTrue (obj.AreYou ("obj1"), "should be true");
		}

		[Test ()]
		public void TestAreYouNot()
		{
			Identifiable_Object obj = new Identifiable_Object (new string[]{ "obj1", "obj2" });

			Assert.IsFalse (obj.AreYou ("obj5"), "should be false");
		}

		[Test ()]
		public void TestCaseSensitive()
		{
			Identifiable_Object obj = new Identifiable_Object (new string[]{ "obj1", "obj2" });
						
			Assert.IsTrue (obj.AreYou ("oBj1"), "should be true");
		}

		[Test ()]
		public void TestFirstID()
		{
			Identifiable_Object obj = new Identifiable_Object (new string[]{ "obj1", "obj2" });
			Assert.AreEqual ("obj1", obj.FirstId(), "should be obj1");

		}

		[Test ()]
		public void TestAddID()
		{
			Identifiable_Object obj = new Identifiable_Object (new string[]{ "obj1", "obj2" });
			obj.AddIdentifier ("obj3");

			Assert.IsTrue (obj.AreYou ("obj3"), "should be true");
		}
	}
}

