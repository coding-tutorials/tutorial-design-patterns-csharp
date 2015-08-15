using System;

namespace DesignPatternsCsharp.Patterns.Creational.Singleton
{	
	public class RobotSingleton
	{
		//the single instance
		//some egs. creates the instance at getInstance() making it lazy-loaded
		//but it isn't thread safe, so that's why I'm creating here
		private static RobotSingleton Robot = new RobotSingleton();
		//private constructor, so no one except this class can create an instance
		private RobotSingleton(){}
		//the public method that returns the single instance
		public static RobotSingleton getInstance(){
			return Robot;
		}

		//and now you can have a bunch of class methods accessed by the single instance...
		public bool IsThisHuman(){
			return false;
		}

		public String SayHelloTo(String name){
			return "Hello " + name;
		}
	}
}

