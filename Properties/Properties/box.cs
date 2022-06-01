using System;
namespace Properties
{
	class box
	{
		private int length = 3;
		private int height;
		//private int width;
		private int volume;

        public int Width { get; set; }
		
		public int Height
        {
			get
			  {
				return height;
			}

			set
			{
				if (value < 0)
				{
					height = -value;
				}
				else
				{
					height = value;
				}
			}
        }

		public box(int length, int height, int width)
		{
			this.length = length;
			this.height = height;
			this.Width = width;
		}
	

		public void SetLength(int length)
		{
            if (length < 0)
            {
				throw new Exception("Length must be more than 0");
            }
			this.length = length;
		}

		public int GetLength()
		{
			return this.length; 
		}

		
		public int Volume
		{
			get
			{
				return this.length * this.height * this.Width;
			}
			
		}
	}
}

