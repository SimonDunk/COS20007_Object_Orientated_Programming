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
			Spell spls =  new Spell("Mitch's mighty mover", SpellKind.Teleport);

			StringAssert.AreEqualIgnoringCase ("Mitch's mighty mover", spls.Name);
			Assert.AreEqual (spls.Kind, SpellKind.Teleport);
		}

		[Test ()]
		public void TestHeal ()
		{
			Spell spls =  new Spell ("Paul's potent poultice", SpellKind.Heal);

			StringAssert.AreEqualIgnoringCase ("Paul's potent poultice", spls.Name);
			Assert.AreEqual (spls.Kind, SpellKind.Heal);
		}

		[Test ()]
		public void TestInvisibility ()
		{
			Spell spls = new Spell ("David's dashing disappearance", SpellKind.Invisibility);

			//making sure string is right
			StringAssert.AreEqualIgnoringCase ("David's dashing disappearance", spls.Name);
			//making sure right type of spell
			Assert.AreEqual (spls.Kind, SpellKind.Invisibility);
		}

		[Test ()]
		public void TestNameChange ()
		{
			Spell spls = new Spell ("David's dashing disappearance", SpellKind.Invisibility);

			StringAssert.AreEqualIgnoringCase ("David's dashing disappearance", spls.Name);

			spls.Name = "Paul's dashing disappearance";

			StringAssert.AreEqualIgnoringCase ("Paul's dashing disappearance", spls.Name);
		}
	}
}

