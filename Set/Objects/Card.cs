using System;
using System.Collections.Generic;
using System.Text;

namespace Set
{
    public class Card
    {
        private SetEnum.CardShape shape;
        private SetEnum.CardColor color;
        private SetEnum.CardShade shade;
        private SetEnum.CardNumber number;


        public Card(SetEnum.CardShape shape, SetEnum.CardColor color, SetEnum.CardShade shade, SetEnum.CardNumber number)
        {
            this.shape = shape;
            this.color = color;
            this.shade = shade;
            this.number = number;
        }

        public SetEnum.CardShape  Shape
        {
            get { return shape; }
            set { shape = value; }
        }

        public SetEnum.CardColor Color
        {
            get { return color; }
            set { color = value; }
        }
        public SetEnum.CardShade Shade
        {
            get { return shade; }
            set { shade = value; }
        }
        public SetEnum.CardNumber Number
        {
            get { return number; }
            set { number = value; }
        }

    }

}