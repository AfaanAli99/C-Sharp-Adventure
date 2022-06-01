using System;
namespace Challange10
{
    public class Box
	{
		private int height;
		private int lenght;

		public Box(int height, int lenght)
		{
			this.height = height;
			this.lenght = lenght;
		}
		public int FrontSurface
		{
			get
			{
				return height * lenght;
			}
		}
	}
}

