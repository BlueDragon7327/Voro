using System;
using System.Drawing;
using System.Windows.Forms;

namespace Voro
{
    public partial class Form1 : Form
    {
        private bool dragging = false;          // Indicates if the form is being dragged
        private Point dragCursorPoint;          // Stores the cursor's position during dragging
        private Point dragFormPoint;            // Stores the form's position during dragging

        public Form1()
        {
            InitializeComponent();

            // Attach drag events to the panel
            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseMove += Panel1_MouseMove;
            panel1.MouseUp += Panel1_MouseUp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // You can add additional initialization code here, if needed
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting logic for the panel (optional)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Begin dragging when the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            // Adjust the form's location while dragging
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging when the mouse button is released
            dragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Inject();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute(richTextBox1.Text);
        }
    }
}
