using System;
using NUnit.Framework;

using DesignPatternsCsharp.Patterns;

namespace DesignPatternsCsharp.Test
{
	public class BuilderTest
	{
		[Test]
		public void ShouldCreateRobotUsingBuilder(){
			var robotBuilder = new RobotBuilder ()
				.SetColor ("blue")
				.SetIsEletric (true)
				.SetNumberOfPieces (15)
				.SetName ("Carlbot");
			var robot = new Robot (robotBuilder);

			Assert.AreEqual ("blue", robot.Color);
			Assert.AreEqual (true, robot.IsEletric);
			Assert.AreEqual (15, robot.NumberOfPieces);
			Assert.AreEqual ("Carlbot", robot.Name);
		}


	}
}


