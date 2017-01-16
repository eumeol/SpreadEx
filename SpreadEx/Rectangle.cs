using System;

namespace SpreadEx
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public override string Description
        {
            get
            {
                return String.Concat("width=", width, " height=", height);
            }
        }

        public Rectangle(string name, Point point, int width, int height)
            : base(name, point)
        {
            this.width = width;
            this.height = height;
        }
    }
}
