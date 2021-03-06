using NUnit.Framework;
using System;

namespace SwinwartsSchoolofMagic
{
	[TestFixture ()]
	public class TestSpellBook
	{
		[Test ()]
		public void TestAdd ()
		{
			SpellBook myBook = new SpellBook ();
			int count = myBook.SpellCount;

			Assert.AreEqual (0, count, "Drawing should start with no shapess");

			myBook.AddSpell (new Heal ());
			myBook.AddSpell (new Invisibility ());
			count = myBook.SpellCount;

			Assert.AreEqual (2, count, "Drawing should have 2 shapess");
		}

		[Test ()]
		public void TestRemove ()
		{
			SpellBook book = new SpellBook ();
			Spell s = new Heal ();
			book.AddSpell (s);
			Spell sp = new Invisibility ("Magic pulse");
			book.AddSpell (sp);
			Assert.AreEqual (2, book.SpellCount);
			book.RemoveSpell (sp);
			Assert.AreEqual (1, book.SpellCount);
		}

		[Test ()]
		public void TestFetch ()
		{
			SpellBook book = new SpellBook ();

			Spell s = new Heal ();
			book.AddSpell (s);


			Assert.AreEqual (s, book[0]);
		}


	}
}

