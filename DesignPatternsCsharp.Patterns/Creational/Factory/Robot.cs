using System;

namespace DesignPatternsCsharp.Patterns.Creational.Factory
{
	public class Robot
	{
		public int Strength { get; private set; }
		public int Speed { get; private set; }
		public int Battery { get; private set; }

		public Robot (int strength, int speed, int battery)
		{
			this.Strength = strength;
			this.Speed = speed;
			this.Battery = battery;
		}
	}
}

