using System;

namespace DesignPatternsCsharp.Patterns.Creational.Factory
{
	public class RobotFactory
	{
		public static Robot createRobot(RobotType robotType)
		{
			switch(robotType){
			case RobotType.FIGHT_ROBOT:
				return new Robot(strength: 100, speed: 20, battery: 80);
				break;
			case RobotType.REPAIR_ROBOT:
				return new Robot(strength: 80, speed: 20, battery: 100);
				break;
			case RobotType.FAST_ROBOT:
				return new Robot(strength: 20, speed: 100, battery: 80);
				break;
			default:
				throw new Exception ("Invalid robot type");
			}
		}
	}
}

