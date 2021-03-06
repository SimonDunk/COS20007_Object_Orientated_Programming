using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class Inventory_Unit_Test
	{
		/// <summary>
		/// Tests the find items that are put in it.
		/// </summary>
		[Test ()]
		public void TestFindItem ()
		{
			Inventory inv = new Inventory (new string[] { "me", "inventory" }, "Player", "Self");
			inv.Put(new Item(new string[]{ "obj1", "tool1"}, "axe", "normally used to cut wood"));

			Assert.IsTrue (inv.HasItem("obj1"), "should be true");
		}

		/// <summary>
		/// Tests that the inventory has no items that it does not contain.
		/// </summary>
		[Test ()]
		public void TestNoItemFind()
		{
			Inventory inv = new Inventory (new string[] { "me", "inventory" }, "Player", "Self");

			Assert.IsFalse (inv.HasItem("obj1"), "should be false");
		}

		/// <summary>
		/// Tests the fetch method, returning items it has and the items remains in the inventory
		/// </summary>
		[Test ()]
		public void TestFetchItem()
		{
			Inventory inv = new Inventory (new string[] { "me", "inventory" }, "Player", "Self");

			Item itm = new Item(new string[]{ "obj1", "tool1"}, "axe", "normally used to cut wood");

			inv.Put(itm);
			Item test = inv.Fetch ("obj1");

			Assert.AreEqual (itm, test, "should be same");
		}

		/// <summary>
		/// Tests the take method for item by returning the item and removing it from the inventory.
		/// </summary>
		[Test ()]
		public void TestTakeItem()
		{
			Inventory inv = new Inventory (new string[] { "me", "inventory" }, "Player", "Self");
			inv.Put(new Item(new string[]{ "obj1", "tool1"}, "axe", "normally used to cut wood"));
			inv.Take ("obj1");

			Item itm = new Item(new string[]{ "obj1", "tool1"}, "axe", "normally used to cut wood");

			Assert.AreNotEqual (inv.Fetch("obj1"), itm, "should be not equal");
		}

		/// <summary>
		/// Tests the item list. 
		/// Returns a list of strings with one row per item. The rows contain tab indented short descriptions of the items in the inventory.
		/// </summary>
		[Test ()]
		public void TestItemList()
		{
			Inventory inv = new Inventory (new string[] { "me", "inventory" }, "Player", "Self");
			inv.Put(new Item(new string[]{ "obj1", "tool1"}, "axe", "normally used to cut wood"));


			Assert.AreEqual ("normally used to cut wood (axe)\r\n", inv.ItemList, "should be obj1");
		}

		[Test ()]
		public void TestMultipleItemList()
		{
			Inventory inv = new Inventory (new string[] { "me", "inventory" }, "Player", "Self");
			inv.Put(new Item(new string[]{ "obj1", "tool1"}, "axe", "normally used to cut wood"));
			inv.Put(new Item(new string[]{ "obj1", "tool1"}, "axe", "normally used to cut wood"));

			Assert.AreEqual ("normally used to cut wood (axe)\r\nnormally used to cut wood (axe)\r\n", inv.ItemList, "should be obj1");
		}


	}
}

