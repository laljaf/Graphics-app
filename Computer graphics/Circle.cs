using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics
{
     class Circle : Shape
    {
       private int circleCenterX;
        private int circleCenterY;
       
        private int radius;

       public Circle(Pen pen, Pen penSelected) : base(pen, penSelected)
        {
            this.pen = pen;
            this.penSelected = penSelected;

        }


        public void SetParameters(int circleCenterX, int circleCenterY, int radius)
        {
            this.circleCenterX = circleCenterX;
            this.circleCenterY = circleCenterY;
            this.radius = radius;


        }




        public override void Draw(Graphics g)
        {
            if (isSelected)
            {

                g.DrawEllipse(penSelected, circleCenterX, circleCenterY, radius, radius);
            }
            else
                g.DrawEllipse(pen, circleCenterX, circleCenterY, radius, radius);
        }



        public override void Rotate(Graphics g)
        {
           

        }


        public override bool CursorIsInside(Point point)
        {
            return point.X >= circleCenterX && point.X <= circleCenterX + radius && point.Y >= circleCenterY && point.Y <= circleCenterY + radius;


        }


        public override void MoveUp(Graphics g, Panel p)
        {

            circleCenterY -= 5;
            if (circleCenterY + radius < 0)
                circleCenterY = p.Height + radius;
            Draw(g);

        }

        public override void MoveDown(Graphics g, Panel p)
        {

            circleCenterY += 5;
            if (circleCenterY - radius > p.Height)
                circleCenterY = 0;
            Draw(g);

        }

        public override void MoveRight(Graphics g, Panel p)
        {

            circleCenterX += 5;
            if (circleCenterX - radius > p.Width)
                circleCenterX = 0;
            Draw(g);

        }

        public override void MoveLeft(Graphics g, Panel p)
        {

            circleCenterX -= 5;
            if (circleCenterX + radius < 0)
                circleCenterX = p.Width + radius;
            Draw(g);

        }
    }
}

