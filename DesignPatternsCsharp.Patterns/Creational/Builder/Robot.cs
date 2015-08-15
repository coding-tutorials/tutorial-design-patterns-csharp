using System;

namespace DesignPatternsCsharp.Patterns.Creational.Builder
{
	public class Robot
	{
		public String Name {get;}
		public int NumberOfPieces {get;}
		public bool IsEletric {get;}
		public String Color {get;}

		public Robot (RobotBuilder robotBuilder)
		{
			this.Name = robotBuilder.Name;
			this.NumberOfPieces = robotBuilder.NumberOfPieces;
			this.IsEletric = robotBuilder.IsEletric;
			this.Color = robotBuilder.Color;
		}
	}
}

