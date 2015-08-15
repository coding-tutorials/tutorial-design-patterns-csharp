using System;
using NUnit.Framework;

using DesignPatternsCsharp.Patterns.Creational.Factory;

namespace DesignPatternsCsharp.Test
{
	public class FactoryTest
	{
		[Test]
		public void ShouldCreateRobotWithFactory(){
			var strongRobot = RobotFactory.createRobot (RobotType.FIGHT_ROBOT);
			var fastRobot = RobotFactory.createRobot (RobotType.FAST_ROBOT);

			Assert.Greater (strongRobot.Strength, fastRobot.Strength);
			Assert.Less (strongRobot.Speed, fastRobot.Speed);
		}
			
	}
}


