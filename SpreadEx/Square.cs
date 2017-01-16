using System;

namespace SpreadEx
{
    public class Square : Shape
    {
        private int size;

        public Square(string name, Point point, int size)
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
