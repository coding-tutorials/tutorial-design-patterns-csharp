using System;
using NUnit.Framework;

using DesignPatternsCsharp.Patterns.Creational.Singleton;

namespace DesignPatternsCsharp.Test
{
	public class SingletonTest
	{
		[Test]
		public void ShouldCheckIfTwoCallsToSingletonIsTheSameInstance(){
			var robotOne = RobotSingleton.getInstance ();
			var robotTwo = RobotSingleton.getInstance ();

			Assert.AreEqual (robotOne, robotTwo);
		}

		[Test]
		public void ShouldUseSingletonMethods(){
			var robot = RobotSingleton.getInstance ();

			var expectedResult = false;
			var someMethodResult = robot.IsThisHuman ();

			Assert.AreEqual (expectedResult, someMethodResult);
		}
	}
}


