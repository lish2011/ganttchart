using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OnPaintTest
{
    public partial class Form1 : Form
    {
        private Image picture;
        private Point pictureLocation;

        public Form1()
        {
            InitializeComponent();

            // Enable drag-and-drop operations and 
            // add handlers for DragEnter and DragDrop.
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new DragEventHandler(this.Form1_DragEnter);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // If there is an image and it has a location, 
            // paint it when the Form is repainted.
            base.OnPaint(e);
            if (this.picture != null && this.pictureLocation != Point.Empty)
            {
                e.Graphics.DrawImage(this.picture, this.pictureLocation);
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // Handle FileDrop data.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Assign the file names to a string array, in 
                // case the user has selected multiple files.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                try
                {
                    // Assign the first image to the picture variable.
                    this.picture = Image.FromFile(files[0]);
                    // Set the picture location equal to the drop point.
                    this.pictureLocation = this.PointToClient(new Point(e.X, e.Y));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            // Handle Bitmap data.
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                try
                {
                    // Create an Image and assign it to the picture variable.
                    this.picture = (Image)e.Data.GetData(DataFormats.Bitmap);
                    // Set the picture location equal to the drop point.
                    this.pictureLocation = this.PointToClient(new Point(e.X, e.Y));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            // Force the form to be redrawn with the image.
            this.Invalidate();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            // If the data is a file or a bitmap, display the copy cursor.
            if (e.Data.GetDataPresent(DataFormats.Bitmap) ||
               e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // This example creates a PictureBox control on the form and draws to it.
        // This example assumes that the Form_Load event handler method is
        // connected to the Load event of the form.

        private PictureBox pictureBox1 = new PictureBox();
        // Cache font instead of recreating font objects each time we paint.
        private Font fnt = new Font("Arial", 10);
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Dock the PictureBox to the form and set its background to white.
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BackColor = Color.White;
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            // Add the PictureBox control to the Form.
            this.Controls.Add(pictureBox1);
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;

            // Draw a string on the PictureBox.
            g.DrawString("This is a diagonal line drawn on the control",
                fnt, System.Drawing.Brushes.Blue, new Point(30, 30));
            // Draw a line in the PictureBox.
            g.DrawLine(System.Drawing.Pens.Red, pictureBox1.Left, pictureBox1.Top,
                pictureBox1.Right, pictureBox1.Bottom);
        }

    }
}
