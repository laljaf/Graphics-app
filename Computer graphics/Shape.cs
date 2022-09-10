using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics
{
    enum Shapes
    {
        triangle,
        Rect,
        Circle
    }
    abstract class Shape
    {
       // bool  for whether a shape is created or not
        public bool isCreated=false;
        
        //bool for whether a shape is selected or not
        public bool isSelected= false;

        //bool for whether the selection is confirmed or not
        public bool selectionIsConfirmed = false;
        
        // angle of rotation set to 0
         public int angle = 0;

         // get set the pen for drawing shapes        
        public Pen pen { get; set; }
        public Pen penSelected { get; set; }

        public Shape(Pen pen, Pen penSelected)
        {
            this.pen = pen;
            this.penSelected = penSelected;

        }
        // method to draw shapes
        public abstract void Draw(Graphics g);

        //method to check if the mouse cursor is inside the shape for selection
        public abstract bool CursorIsInside(Point p);

        // method for the rotation of the  shape
        public abstract void Rotate(Graphics g);

        // methods for translation of the shape 
        public abstract void MoveUp(Graphics g,Panel p);

        public abstract void MoveDown(Graphics g, Panel p);

        public abstract void MoveRight(Graphics g, Panel p);

        public abstract void MoveLeft(Graphics g, Panel p);
    }
}

