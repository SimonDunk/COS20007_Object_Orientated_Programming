using NUnit.Framework;
using System;

namespace Robot
{
	[TestFixture ()]
	public class RobotTest
	{
		/*
		//tests creation of Robot
		[Test ()]
		public void TestCreation ()
		{
			Robot r = new Robot ();
			Assert.IsInstanceOf<Robot>(r);
		}

		//Tests attaching Gadgets
		[Test ()]
		public void TestAttach ()
		{
			Robot r = new Robot ();
			Laser l = new Laser ();

			r.Attach (l);

		}

		//Tests not attaching Gadgets
		[Test ()]
		public void TestNotAttachDeploy ()
		{
			Robot r = new Robot ();
			Laser l = new Laser ();

			r.Attach (l);
			r.Deploy ("", true);

			Assert.AreEqual (Console.Out, "NO gadget deployed");

		}

		//Testing deploying 
		[Test ()]
		public void TestDeploy ()
		{
			Robot r = new Robot ();
			Laser l = new Laser ();

			r.Attach (l);
			r.Deploy ("Laser", true);
		}

		//testing operating
		[Test ()]
		public void TestOperate ()
		{
			Robot r = new Robot ();
			Laser l = new Laser ();

			r.Attach (l);
			r.Deploy ("Laser", true);
			r.Operate ();
			Assert.AreEqual (Console.Out, "ZAP!");
		}

		//testing operating
		[Test ()]
		public void TestNotOperate ()
		{
			Robot r = new Robot ();
			Laser l = new Laser ();

			r.Attach (l);
			r.Deploy ("Sonar", true);
			r.Operate ();
			Assert.AreEqual (Console.Out, "I'm afraid I can't do that");
		}
		*/
	}
}

