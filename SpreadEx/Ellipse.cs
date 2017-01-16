using System;

namespace SpreadEx
{
    public class Ellipse : Shape
    {
        private int diameterH;
        private int diameterV;

        public Ellipse(string name, Point point, int diameterH, int diameterV)
            : base(name, point)
        {
            this.diameterH = diameterH;
            this.diameterV = diameterV;
        }

        public override string Description
        {
            get
            {
                return String.Concat("diameterH = ", diameterH, " diameterV = ", diameterV);
            }
        }
    }
}
