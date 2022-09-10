using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics
    
{
     class Triangle : Shape
    {
        
        public PointF[] triangle;
        float height;
        float heightForComp;
        float basetri;
        float baseTriforComp;
        public PointF point1;
        public PointF point2;
        public PointF point3;
        

        public Triangle(Pen pen, Pen penSelected) : base(pen, penSelected)
        {
            this.pen = pen;
            this.penSelected = penSelected;

           
        }

        // set the points of the triangle
        public void SetParamTr(PointF p1, PointF p2, PointF p3, Graphics g) 
        {

          point1 = p1;
          point2 = p2;
          point3 = p3;
          height = p1.Y - p3.Y;
          basetri= p2.X - p1.X;
          

        }

        //draw triangle
        public override void Draw(Graphics g)
        {

            PointF[] trig =
            {
                    point1,
                    point2,
                    point3,
            };

            triangle = trig;


            if (isSelected)
            {

                g.DrawPolygon(penSelected, triangle);
            }
            else
                g.DrawPolygon(pen, triangle);


        }

       
       


        // method to calculate triangle area
        public static double area(double x1, double y1, double x2,
                     double y2, double x3, double y3)
        {
            return Math.Abs((x1 * (y2 - y3) +
                             x2 * (y3 - y1) +
                             x3 * (y1 - y2)) / 2.0);
        }

        public override bool CursorIsInside(Point point)
        {


            /* Calculate area of triangle ABC */
            double A = area(point1.X, point1.Y, point2.X, point2.Y, point3.X, point3.Y);

            /* Calculate area of triangle PBC */
            double A1 = area(point.X, point.Y, point2.X, point2.Y, point3.X, point3.Y);

            /* Calculate area of triangle PAC */
            double A2 = area(point1.X, point1.Y, point.X, point.Y, point3.X, point3.Y);

            /* Calculate area of triangle PAB */
            double A3 = area(point1.X, point1.Y, point2.X, point2.Y, point.X, point.Y);

            /* Check if sum of A1, A2 and A3 is same as A */
            return (A == A1 + A2 + A3);


        }

        //triangle movements:
        public override void MoveUp(Graphics g, Panel p)
        {

            point1.Y -= 5;
            point2.Y -= 5;
            point3.Y -= 5;
          
            // loop throught the window if the triangle gets out of the screen
            if (point2.Y < 0)
            {
                point2.Y = p.Height;
                point1.Y = p.Height;
                point3.Y = p.Height-height;
                    
            }

         
            Draw(g);

        }

        public override void MoveDown(Graphics g, Panel p)
        {

            point1.Y += 5;
            point2.Y += 5;
            point3.Y += 5;

            if (point3.Y > p.Height)
            {
                point2.Y = height;
                point1.Y = height;
                point3.Y = 0;

            }

            Draw(g);

        }

        public override void MoveRight(Graphics g, Panel p)
        {
            
            point1.X += 5;
            point2.X += 5;
            point3.X += 5;

            if (point1.X > p.Width)
            {
                point2.X = basetri;
                point1.X = 0;
                point3.X = basetri / 2;

            }
            Draw(g);
        }

        public override void MoveLeft(Graphics g, Panel p)
        {
            point1.X -= 5;
            point2.X -= 5;
            point3.X -= 5;

            if (point2.X < 0)
            {
                point2.X = p.Width;
                point1.X = p.Width-basetri;
                point3.X = p.Width - basetri / 2;

            }
            Draw(g);


        }

        public override void Rotate(Graphics g)
        {
            angle = angle + 30;


            g.TranslateTransform(point3.X, point3.Y + (point2.Y - point3.Y) / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-point3.X, -(point3.Y + (point2.Y - point3.Y) / 2));
            Draw(g);


        }

    }
}
