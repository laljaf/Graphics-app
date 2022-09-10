using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_graphics.Forms
{
    public partial class canvas : Form
    {
        CreateShape newPan;
        public canvas()
        {
            InitializeComponent();
            newPan= new CreateShape();


        }
        
      
        private void SelectShape_Load(object sender, EventArgs e)
        {

        }


       


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
               
        }

        private void SelectShape_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
