using NUnit.Framework;
using System;

namespace SwinwartsSchoolofMagic
{
	[TestFixture ()]
	public class TestSpell
	{
		[Test ()]
		public void TestTeleport ()
		{
			Spell spls =  new Teleport("Mitch's mighty mover");

			StringAssert.AreEqualIgnoringCase ("Mitch's mighty mover", spls.Name);
			Assert.AreEqual (spls.Kind, SpellKind.Teleport);
		}

		[Test ()]
		public void TestHeal ()
		{
			Spell spls =  new Heal ("Paul's potent poultice");

			StringAssert.AreEqualIgnoringCase ("Paul's potent poultice", spls.Name);
			Assert.AreEqual (spls.Kind, SpellKind.Heal);
		}

		[Test ()]
		public void TestInvisibility ()
		{
			Spell spls = new Invisibility ("David's dashing disappearance");

			//making sure string is right
			StringAssert.AreEqualIgnoringCase ("David's dashing disappearance", spls.Name);
			//making sure right type of spell
			Assert.AreEqual (spls.Kind, SpellKind.Invisibility);
		}

		[Test ()]
		public void TestNameChange ()
		{
			Spell spls = new Invisibility ("David's dashing disappearance");

			StringAssert.AreEqualIgnoringCase ("David's dashing disappearance", spls.Name);

			spls.Name = "Paul's dashing disappearance";

			StringAssert.AreEqualIgnoringCase ("Paul's dashing disappearance", spls.Name);
		}

		[Test ()]
		public void TestInvisibilityonce ()
		{
			Invisibility spls = new Invisibility ("David's dashing disappearance");

			Assert.AreEqual (false, spls.WasCast);

			spls.Cast (spls);

			Assert.AreEqual ("Player casts Invisibility", spls.Result);

			Assert.AreEqual (true, spls.WasCast);

			spls.Cast (spls);

			Assert.AreEqual ("pzzzzit", spls.Result);



		}

		[Test ()]
		public void TestHeals ()
		{
			Heal spls = new Heal ();

			Assert.AreEqual ("and... nothing happened", spls.Result);

			spls.Cast (spls);

			Assert.AreEqual ("Ahhh... you feel better", spls.Result);


		}

		[Test ()]
		public void TestTeleports ()
		{
			Teleport spls = new Teleport ();

			spls.Cast (spls);

			double a = spls.Random;

			if(a == 1)
			{
				Assert.AreEqual ("Poof... you apear somewhere else", spls.Result);
			}

			if(a == 0)
			{
				Assert.AreEqual ("arrr... I'm too tired to move", spls.Result);
			}



		}
	}
}

