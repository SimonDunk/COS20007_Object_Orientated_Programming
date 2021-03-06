using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class Player_Unit_Test
	{
		/// <summary>
		/// Tests the playeris identifiable.
		/// player responds correctly to AreYou requests based on its default identifiers(me and inventory)
		/// </summary>
		[Test ()]
		public void TestPlayerisIdentifiable ()
		{
			Player plr = new Player ("me", "cool guy");

			Assert.IsTrue (plr.AreYou("me"), "should be true");
		}

		/// <summary>
		/// Tests the player locates item.
		/// can the player locate items in its inventory, returns items the player has in the players inventory
		/// </summary>
		[Test ()]
		public void TestPlayerLocatesItem()
		{
			Player plr = new Player ("name", "cool guy");
			Item itm = new Item (new string[]{ "obj1", "tool1" }, "axe", "normally used to cut wood");
			plr.Inventory.Put(itm);

			Assert.IsTrue (plr.Inventory.HasItem("obj1"), "should be true");
		}

		/// <summary>
		/// Tests the player locates self.
		/// player returns itself if asked to locate me or inventory
		/// </summary>
		[Test ()]
		public void TestPlayerLocatesSelf()
		{
			Player plr = new Player ("name", "cool guy");

			Assert.AreEqual (plr.Locate("me"), plr, "should be equal");
		}

		/// <summary>
		/// Tests the locates nothing.
		/// player returns null object if asked to locate soemthing that doesn't exist
		/// </summary>
		[Test ()]
		public void TestLocatesNothing()
		{
			Player plr = new Player ("name", "cool guy");
						
			Assert.IsNull (plr.Locate("obj1"), "should be null");
		}

		/// <summary>
		/// Tests the player full description.
		/// The players full description contains the text "You are carrying" and the short descriptions of the items the player has
		/// (from its inventory's item list)
		/// </summary>
		[Test ()]
		public void TestPlayerFullDescription()
		{
			Player plr = new Player ("name", "cool guy");
			plr.Inventory.Put(new Item(new string[]{ "obj1", "tool1"}, "axe", "normally used to cut wood"));


			Assert.AreEqual ("You are carrying: normally used to cut wood (axe)\r\n", plr.FullDescription, "should be equal");

		}


	}
}

