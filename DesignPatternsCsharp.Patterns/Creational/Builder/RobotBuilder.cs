using System;

namespace DesignPatternsCsharp.Patterns
{
	public class RobotBuilder
	{
		public String Name { get; private set;}
		public int NumberOfPieces {get; private set;}
		public bool IsEletric {get; private set;}
		public String Color {get; private set;}

		public RobotBuilder (){}

		public RobotBuilder SetName(String name){
			this.Name = name;
			return this;
		}

		public RobotBuilder SetNumberOfPieces(int numberOfPieces){
			this.NumberOfPieces = numberOfPieces;
			return this;
		}

		public RobotBuilder SetIsEletric(bool isEletric){
			this.IsEletric = isEletric;
			return this;
		}

		public RobotBuilder SetColor(String color){
			this.Color = color;
			return this;
		}
	}
}

