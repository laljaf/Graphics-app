using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics
{
    class Rect : Shape
    {
        private int rectX;
        private int rectY;


        private const int realWidth = 80;
        public int  width = realWidth;
        private const int realHeight = 100;
        private int height = realHeight;
        
        public int baseTri = 80;
      

        
        public Rect(Pen pen, Pen penSelected) : base(pen, penSelected)
        {
            this.pen = pen;
            this.penSelected = penSelected;
            
            
           
        }

        //set the coordinates origin of the rectangle
        public void SetParameters(int rectX, int rectY) 
        {
            this.rectX = rectX;
            this.rectY = rectY;
            
        
        }


        

        public override void Draw(Graphics g)
        {
            
            
            if (isSelected)
            {
                
                g.DrawRectangle(penSelected, rectX, rectY, width, height);
            }
            else
                g.DrawRectangle(pen, rectX, rectY, width, height);
        }

       

       


        public override bool CursorIsInside(Point point)
        {
            return
            point.X >= rectX &&
            point.X <= rectX + width &&
            point.Y >= rectY &&
            point.Y <= rectY + height;


        }


        public override void MoveUp(Graphics g, Panel p)
        {

            rectY -= 5;
            if (rectY < 0)
                rectY = p.Height;
            Draw(g);

        }



        public override void MoveDown(Graphics g, Panel p)
        {

            rectY += 5;
            //loop around the screen if rectangle gets out of the screen same applies to other movement methods
            if (rectY > p.Height)
            {
                rectY = 0;

                height = 0;
            }
            if (height < realHeight)
            {
                rectY -= 5;
                height += 5;
            }

            Draw(g);

        }

        public override void MoveRight(Graphics g, Panel p)
        {

            rectX += 5;
            // to draw on the other side the rectangle if goes off the screen
            if (rectX > p.Width)
            {
                rectX = 0;

                width = 0;
            }
            if (width < realWidth)
            {
                rectX -= 5;
                width += 5;
            }

            Draw(g);

        }

        public override void MoveLeft(Graphics g, Panel p)
        {

            rectX -= 5;
            if (rectX < 0)
            {
                rectX = p.Width;


            }
            Draw(g);

        }

        public override void Rotate(Graphics g)
        {
            angle = angle + 30;

            g.TranslateTransform(rectX + width / 2, rectY + height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(rectX + width / 2), -(rectY + height / 2));
            Draw(g);


        }
    }
}
