using System;

namespace SpreadEx
{
    public class Textbox : Shape
    {
        private int width;
        private int height;
        private string sampleText;

        public Textbox(string name, Point point, int width, int height, string sampleText)
            : base(name, point)
        {
            this.width = width;
            this.height = height;
            this.sampleText = sampleText;
        }

        public override string Description
        {
            get
            {
                return String.Concat("width=", width, " height=",
                    height, " Text=\"", sampleText, "\"");
            }
        }
    }
}
