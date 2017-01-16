using System;

namespace SpreadEx
{
    public class Circle : Shape
    {
        private int size;

        public Circle(string name, Point point, int size)
            : base(name, point)
        {
            this.size = size;
        }

        public override string Description
        {
            get
            {
                return String.Concat("size=", size);
            }
        }
    }
}
