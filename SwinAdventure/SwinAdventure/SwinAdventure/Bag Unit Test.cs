using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class Bag_Unit_Test
	{
		/// <summary>
		///You can add items to the Bag, and locate the items in its inventory, this
		///returns items the bag has and the item remains in the bag's inventory.
		/// </summary>
		[Test ()]
		public void TestBagLocatesItems ()
		{
			Bag plr = new Bag (new string[] { "bag", "container" }, "Bag", "holds stuff");
			Item itm = new Item (new string[]{ "obj1", "tool1" }, "axe", "normally used to cut wood");
			plr.Inventory.Put(itm);

			Assert.IsTrue (plr.Inventory.HasItem("obj1"), "should be true");
		}

		/// <summary>
		/// The bag returns itself if asked to locate one of its identifiers.
		/// </summary>
		[Test ()]
		public void TestBagLocatesItself()
		{
			Bag plr = new Bag (new string[] { "bag", "container" }, "Bag", "holds stuff");

			Assert.AreEqual (plr.Locate("bag"), plr, "should be equal");
		}

		/// <summary>
		/// The bag returns a null/nil object if asked to locate something it does not have.
		/// </summary>
		[Test ()]
		public void TestBagLocatesNothing()
		{
			Bag plr = new Bag (new string[] { "bag", "container" }, "Bag", "holds stuff");

			Assert.IsNull (plr.Locate("obj1"), "should be null");
		}

		/// <summary>
		///The bag's full description contains the text "In the <name> you can
		///see:" and the short descriptions of the items the bag contains (from its
		///inventory's item list)
		/// </summary>
		[Test ()]
		public void TestBagFullDescription()
		{
			Bag plr = new Bag (new string[] { "bag", "container" }, "Bag", "holds stuff");
			plr.Inventory.Put(new Item(new string[]{ "obj1", "tool1"}, "axe", "normally used to cut wood"));


			Assert.AreEqual ("In the Bag you can see: normally used to cut wood (axe)\r\n", plr.FullDescription, "should be equal");

		}

		/// <summary>
		/// Create two Bag objects (b1, b2), put b2 in b1’s inventory. Test that b1
		///can locate b2. Test that b1 can locate other items in b1. Test that b1
		///can not locate items in b2.
		/// </summary>
		[Test ()]
		public void TestBaginBag()
		{
			Bag plr = new Bag (new string[] { "bag", "container" }, "Bag", "holds stuff");
			Bag plr1 = new Bag (new string[] { "bagu", "containeru" }, "Bag", "holds stuff");
			plr.Inventory.Put (plr1);

			Assert.IsTrue (plr.Inventory.HasItem("bagu"), "should be true");
		}

	}
}

