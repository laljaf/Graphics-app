namespace Computer_graphics
{
    public partial class windowMenu : System.Windows.Forms.Form
    {
        private Button currentButton;
        private Form activeForm;
       
        // Stat the application
        public windowMenu()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text=String.Empty;
            
        }


        // button aesthetics for active and disabled button
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Red;
                    currentButton.ForeColor = Color.White;
                    
                }

            }
        }
        private void DisableButton()
        {
            
            foreach(Control previousButton in menu.Controls) 
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.DarkSlateGray;
                    previousButton.ForeColor = Color.White;
                }
            }
        }





        // method to set up and open a new panel related to one of the two menues: create shape or instructuions 
        private void OpenChildForm(Form childForm, object btnSender) 
        {
            // check if there's an active form
        if (activeForm != null)
            {
              activeForm.Close();
            }
            // method for the aesthetics of the button of an active form
            ActivateButton(btnSender);

            //allocate the child form to the active form
            activeForm = childForm;
            activeForm.TopLevel = false;

            // set up the display setting
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //open the actual child form and display its header text as label 
            this.dashBoard.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            label2.Text = childForm.Text;

        }

        //exit button closes the form
        private void exit_Click(object sender, EventArgs e)
        {
            if (sender != null)
                Application.Exit();
        }

        // instructions button open the instructions window
        private void instructions_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.canvas(), sender);
        }


        // create shape button open the create shape window
        private void create_shape_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CreateShape(), sender);

            
        }


        private void panelMenu_Load(object sender, EventArgs e)
        {

        }
    }
}