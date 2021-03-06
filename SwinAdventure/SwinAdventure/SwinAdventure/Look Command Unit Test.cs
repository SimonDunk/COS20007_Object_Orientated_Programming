using NUnit.Framework;
using System;

namespace SwinAdventure
{
	[TestFixture ()]
	public class Look_Command_Unit_Test
	{
		/// <summary>
		/// Returns player description when looking at "inventory"
		/// </summary>
		[Test ()]
		public void TestLookAtMe ()
		{
			Player p = new Player ("joe", "newbie player");

			//Assert.AreEqual("newbie player",LookAtIn(p, "joe", p.Inventory) );
		}

		/// <summary>
		/// Returns the gems description when looking at a gem in the player's inventory.
		/// </summary>
		[Test ()]
		public void TestLookAtGem()
		{
			Player p = new Player ("joe", "newbie player");
			Item gem = new Item (new string[]{ "obj1", "tool1" }, "axe", "normally used to cut wood");
			p.Inventory.Put (gem);

			Assert.AreEqual ();
		}

		/// <summary>
		/// Returns "I can't find the gem" when the player doesn't have a gem in their inventory 
		/// </summary>
		[Test ()]
		public void TestLookAtUnk()
		{
			Player p = new Player ("joe", "newbie player");

			Assert.AreEqual ("I can't find the gem", , "should be same");
		}

		/// <summary>
		/// Returns the gem's description when looking at a gem in the player's inventory eg "look at gem in inventory"
		/// </summary>
		[Test ()]
		public void TestLookAtGemInMe()
		{
			Player p = new Player ("joe", "newbie player");
			Item gem = new Item (new string[]{ "obj1", "tool1" }, "axe", "normally used to cut wood");
			p.Inventory.Put(gem);



			Assert.AreEqual("", )
		}

		/// <summary>
		///Returns the gems description when looking at a gem in a bag that is in the players inventory
		/// </summary>
		[Test ()]
		public void TestLookAtGemInBag()
		{
			Player p = new Player ("joe", "newbie player");
			Item gem = new Item (new string[]{ "obj1", "tool1" }, "axe", "normally used to cut wood");
			Bag plr = new Bag (new string[] { "bag", "container" }, "Bag", "holds stuff");
			p.Inventory.Put (plr);
			plr.Inventory.Put(gem);



			Assert.AreEqual ();
		}

		/// <summary>
		/// Returns "I can't find the bag" when player doesn't have a bag in their inventory
		/// </summary>
		[Test ()]
		public void TestLookatGemInNoBag()
		{
			Player p = new Player ("joe", "newbie player");
			Item gem = new Item (new string[]{ "obj1", "tool1" }, "axe", "normally used to cut wood");
			//Bag plr = new Bag (new string[] { "bag", "container" }, "Bag", "holds stuff");
			//p.Inventory.Put (plr);
			p.Inventory.Put(gem);



			Assert.AreEqual ("I can't find the bag", );
		}

		/// <summary>
		/// Returns "I can't find the gem" when the bag does not have a gem in its inventory
		/// </summary>
		[Test ()]
		public void TestLookatNoGemInBag()
		{
			Player p = new Player ("joe", "newbie player");
			Item gem = new Item (new string[]{ "obj1", "tool1" }, "axe", "normally used to cut wood");
			Bag plr = new Bag (new string[] { "bag", "container" }, "Bag", "holds stuff");
			p.Inventory.Put (plr);
			//plr.Inventory.Put(gem);



			Assert.AreEqual ("I can't find the gem", );
		}

		/// <summary>
		/// Test look options to check all error conditions 
		/// eg look around, hello, look at a b
		/// </summary>
		[Test ()]
		public void TestInvalidLook()
		{
			Player p = new Player ("joe", "newbie player");
			Item gem = new Item (new string[]{ "obj1", "tool1" }, "axe", "normally used to cut wood");
			Bag plr = new Bag (new string[] { "bag", "container" }, "Bag", "holds stuff");
			p.Inventory.Put (plr);
			plr.Inventory.Put(gem);



			Assert.AreEqual ();
		}


	}
}

