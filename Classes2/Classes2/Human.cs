using System;
namespace Classes2
{
	class Human
	{
		private string firstName;
		public string lastName;
		private string eyeColor;
		private int age;
		public Human(string consFirstName, string lastName, string eyeColor, int age)
		{
			firstName = consFirstName;
			this.lastName = lastName;
			this.eyeColor = eyeColor;
			this.age = age;

		}

		public Human(string consFirstName, string lastName, string eyeColor)
		{
			firstName = consFirstName;
			this.lastName = lastName;
			this.eyeColor = eyeColor;

			this.age = 20;

		}

		public Human(string consFirstName)
		{
			firstName = consFirstName;
		}


		public void IntroduceMyself()
		{
            if ((age == 1 && lastName != null && eyeColor != null ))
            {
				Console.WriteLine($"Hi, my name is {firstName} {lastName}, I am {age} year old, and my eye color is {eyeColor}");
			}
			else
            {
				Console.WriteLine($"Hi, my name is {firstName} {lastName}, I am {age} years old, and my eye color is {eyeColor}");
			}
            
			
		}
	}
}

