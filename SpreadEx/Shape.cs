using System;

namespace SpreadEx
{
    public abstract class Shape
    {
        private string name;
        private Point point;

        public Shape(string name, Point point)
        {
            this.name = name;
            this.point = point;
        }

        public abstract string Description
        {
            get;
        }

        public override string ToString()
        {
            return String.Concat(name, " (", point.pointX, ",", point.pointY, ") ", Description);
        }

    }
}
