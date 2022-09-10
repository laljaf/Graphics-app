using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_graphics.Forms
{

    public partial class CreateShape : Form
    {
        Graphics gObject;
        int rectX;
        int rectY;

        bool moveUp;
        bool moveDown;
        bool moveLeft;
        bool moveRight;
        bool rotate ;

        Rect rectgl;
        Triangle trgl;
        Circle crcl;

        //the base of the triangle  
        int baseTri = 80; 
        
        //the radius of the circle
        int radius = 80;
        //the circle origin coordinates
        int circlecenterX;
        int circlecenterY;

        Pen pen;

        int xPoint1;

        //points for drawing the triangle
        PointF point1;
        PointF point2;
        PointF point3;
   
        
        public CreateShape()
        {
            InitializeComponent();

            reset();
           
        }

 
        
        
       private void canvas_Paint_1(object sender, PaintEventArgs e)
       {
           
       }


        private void ResetParam()
        {
            gObject = canvas.CreateGraphics();
            Brush brushColor1 = new SolidBrush(Color.BlueViolet);
            Brush brushColor2 = new SolidBrush(Color.Red);
            pen = new Pen(brushColor1, 5);
            Pen penSelected = new Pen(brushColor2, 5);

            
            // creating a Rect class instance 
            rectgl = new Rect(pen, penSelected);
            // setting the X coordinates of the shape to be under the shape button (rctgle.But) 
            rectX = rctgleBut.Location.X + (rctgleBut.Width) / 2 - rectgl.width / 2;
            rectY = 150;
            rectgl.SetParameters(rectX, rectY);



            //creating a Triangle class instance 
            // setting the X coordinates of the shape to be under the shape button (tri.But) 
            xPoint1 = trigleBut.Location.X + trigleBut.Width / 2 - baseTri / 2;
            point1 = new PointF(xPoint1, 250.0F);
            point2 = new PointF(xPoint1 + baseTri, 250.0F);
            point3 = new PointF(xPoint1 + baseTri / 2, point1.Y - baseTri);
            trgl = new Triangle(pen, penSelected);
            trgl.SetParamTr(point1, point2, point3, gObject);




            //creating a circle class instance 
            // setting the X coordinates of the shape to be under the shape button (tri.But) 
            circlecenterX = circBut.Location.X;
            circlecenterY = 150;
            crcl = new Circle(pen, penSelected);
            crcl.SetParameters(circlecenterX, circlecenterY, radius);

        }

       //when button of a shape is pressed this shape is drawn to the panel (canvas) and its isCreated variable is set to true 
        private void Create_Rectangle_Click(object sender, EventArgs e)
        {
            rctgleBut.Enabled = false;
            rectgl.Draw(gObject);

            rectgl.isCreated = true;

        }

        private void Create_Circle_Click(object sender, EventArgs e)
        {


            crcl.Draw(gObject);
            crcl.isCreated = true;
            circBut.Enabled = false;    
            

        }

        private void Create_Triangle_Click(object sender, EventArgs e)
        {
            trgl.Draw(gObject);
            trgl.isCreated= true;
            trigleBut.Enabled = false;

            
        }

        // reset variables to initial state  
        private void reset()
        {
            ResetParam();
            resetButtons();
            resetCreation();
            resetSelection();
            resetMove();
            rotate = false;
            

        }

       
        // reset the bool that verifies the creation of a shape
        private void resetCreation() 
        {
           
            rectgl.isCreated = false;
            trgl.isCreated = false;
            crcl.isCreated=false;

        }

       //reset the selection and the selection confirmation for all shapes
        private void resetSelection()
        {
            
           
            rectgl.selectionIsConfirmed = false;
            trgl.selectionIsConfirmed = false;
            crcl.selectionIsConfirmed = false;

            rectgl.isSelected = false;
            trgl.isSelected = false;
            crcl.isSelected = false;

        }

        // method to reset buttons to their initial state 
        //the movement buttons are disabled untill a shape is created
        //the shape buttons are enabled and only disabled if used (they are enabled again after the clear)
        private void resetButtons() 
        {
            trigleBut.Enabled = true;
            circBut.Enabled = true;
            rctgleBut.Enabled = true;
            conf.Enabled = false;

            
            up.Enabled = false;
            down.Enabled = false;
            right.Enabled = false;
            left.Enabled = false;
            stopBut.Enabled = false;
            rotR.Enabled = false;



        }


        // reset the movement of the shape in question (stops them from translating)
        private void resetMove() 
        {

            moveUp = false;
            moveDown = false;
            moveLeft = false;
            moveRight = false;
            
        }


        //button to reset the panel 
        private void clear_Click(object sender, EventArgs e)
        {
            canvas.Invalidate();
            //reset
            reset();


        }

        Point ClickPosition;
        // method to select a shape if clicked on it
        // changes the color of the shape when selected by verifying if cursor inside at the moment of the click
        private void canvas_Click(object sender, EventArgs e)
        {
            Point point = canvas.PointToClient(Cursor.Position);
            ClickPosition = point;

            // If the cursor is inside the area of the rectangle 
            if (rectgl.isCreated && rectgl.CursorIsInside(point))
            {
                resetSelection();
                canvas.Refresh();

                //if shape is created, redraw in normal color

                if (trgl.isCreated)
                    trgl.Draw(gObject);

                if (crcl.isCreated)
                    crcl.Draw(gObject);

                // isSelected = true => pen = penSelected => colour = red
                rectgl.isSelected = true;
                rectgl.Draw(gObject);
                

            }

            // If the cursor is inside the area of the triangle 
            else if (trgl.isCreated && trgl.CursorIsInside(point)) 
            {
                resetSelection();
                canvas.Refresh();

                //if shape is created, redraw in normal color

                if (rectgl.isCreated)
                    rectgl.Draw(gObject);

                if (crcl.isCreated)
                    crcl.Draw(gObject);


                // isSelected = true => pen = penSelected => colour = red
                trgl.isSelected = true;
                trgl.Draw(gObject);
               

            }

            // If the cursor is inside the area of the circle 
            else if (crcl.isCreated && crcl.CursorIsInside(point)) 
            {
                resetSelection();
                canvas.Refresh();

                //if shape is created, redraw in normal color

                if (rectgl.isCreated)
                    rectgl.Draw(gObject);


                if (trgl.isCreated)
                    trgl.Draw(gObject);



                // isSelected = true => pen = penSelected => colour = red
                crcl.isSelected = true;
                crcl.Draw(gObject);

            }

            if (rectgl.isSelected || trgl.isSelected || crcl.isSelected) 
            {
                //confirmation  button is enabled when a shape is selected
                conf.Enabled = true;
               
            }

            
        }



        // confirm selection buttonn
        // used to confirm the selection of a shape
        private void confirmSelection_Click(object sender, EventArgs e)
        {

            //disable all buttons for shape creation after the a shape is selected and confirmed
            trigleBut.Enabled = false;
            circBut.Enabled = false;
            rctgleBut.Enabled = false;


            //enable all move buttons when the shape is selected and confirmed
            up.Enabled = true;
            down.Enabled = true;
            right.Enabled = true;
            left.Enabled = true;
            rotR.Enabled = true;
            stopBut.Enabled = true;

            //disable the confirm button 
            conf.Enabled = false;


            //refresh the canvas to redraw the shape selected alone
            canvas.Refresh();
            if (rectgl.isSelected)
            {
                rectgl.Draw(gObject);
                rectgl.selectionIsConfirmed = true;
            }

            if (trgl.isSelected)
            {
                trgl.Draw(gObject);
                trgl.selectionIsConfirmed = true;
            }

            if(crcl.isSelected)
            {
                crcl.Draw(gObject);
                crcl.selectionIsConfirmed = true;

                rotR.Enabled = false;

            }

        }


        
       // a timer is invoked to redraw shapes after a specific time to create the illusion of a movement when the coordinates of their 
       //parameters are incremented
        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            gObject = canvas.CreateGraphics();

            // check the movement bool states to determine the nature of the movement, this state is defined by the movement buttons
            if (moveUp==true)
            {
               
                if (rectgl.selectionIsConfirmed)
                {
                   

                     Refresh();
                     
                    
                    rectgl.MoveUp(gObject,canvas);

                }

                else if (trgl.selectionIsConfirmed)
                {
                   
                    Refresh();
                    trgl.MoveUp(gObject, canvas);
                    
                }

                else if (crcl.selectionIsConfirmed)
                {
                   
                    Refresh();
                    crcl.MoveUp(gObject, canvas);
                   
                }


            }


            if (moveDown == true)
            {
                

                if (rectgl.selectionIsConfirmed)
                {
                   


                    Refresh();
                    rectgl.MoveDown(gObject, canvas);
                   
                    
                   
                   

                }

                else if (trgl.selectionIsConfirmed)
                {
                    
                    Refresh();
                    trgl.MoveDown(gObject, canvas);
                }

                else if (crcl.selectionIsConfirmed)
                {
                    
                    Refresh();
                    crcl.MoveDown(gObject, canvas);
                   

                }
            }

            if(moveRight)
            {
                
                
                if (rectgl.selectionIsConfirmed)
                {
                   
                    Refresh();
                    rectgl.MoveRight(gObject, canvas);

                    

                }

                else if (trgl.selectionIsConfirmed)
                {
                    
                    Refresh();
                    trgl.MoveRight(gObject, canvas);
                    
                }

                else if (crcl.selectionIsConfirmed)
                {
                    
                    Refresh();
                    crcl.MoveRight(gObject, canvas);
                   

                }

            }
            if(moveLeft)
            {
                 
                if (rectgl.selectionIsConfirmed)
                {
                   
                    Refresh();
                    
                     rectgl.MoveLeft(gObject, canvas);
                    
                    

                }

                else if (trgl.selectionIsConfirmed)
                {
                    Refresh();
                    trgl.MoveLeft(gObject, canvas);
                   
                }

                else if (crcl.selectionIsConfirmed)
                {
                    
                    Refresh();
                    crcl.MoveLeft(gObject, canvas);
                    

                }

            }

            // calls the rotation function if rotate is true (button is pressed)
            if (rotate)
            {
               
                
                if (rectgl.selectionIsConfirmed)
                {

                    Refresh();
                    rectgl.Rotate(gObject);
                    
                }

                if (trgl.selectionIsConfirmed)
                {

                    Refresh();
                    trgl.Rotate(gObject);
                    
                 
                }
            }

        }



      // sets the movement bool values according to the button clicked (up presse moveUp is true and moveDown set to false)

        private void up_Click(object sender, EventArgs e)
        {
            if (moveUp)
                resetMove();
            moveUp = true;
            moveDown = false;
            

        }

        
        private void down_Click(object sender, EventArgs e)
        {
            if (moveDown)
                resetMove();
            moveDown = true;
            moveUp = false;
            


        }

      
        private void right_Click(object sender, EventArgs e)
        {
            if (moveRight)
                resetMove();
            moveRight = true;
            moveLeft = false;
           

        }

        
        private void left_Click(object sender, EventArgs e)
        {
            if (moveLeft)
                resetMove();
            moveLeft = true;
            moveRight = false;
           



        }

       
        private void rotate_Click(object sender, EventArgs e)
        {
            if (rotate)
                rotate=false;
            else
                rotate=true;

        }

        private void stopBut_Click(object sender, EventArgs e)
        {
            resetMove();
            
        }
    }
}
