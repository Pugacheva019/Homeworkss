using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonRunning
{
    /// <summary>
    /// Class for Form with button.
    /// </summary>
    public partial class RunningButtonForm : Form
    {
        /// <summary>
        /// Constructor for initializing form.
        /// </summary>
        public RunningButtonForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method for clicking on the button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///  Method to make the mouse run away from cursor.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">Argument that holds information about event.</param>
        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            Button.Location = new Point(rnd.Next(0, this.ClientSize.Width - Button.Width), rnd.Next(0, this.ClientSize.Height - Button.Height));
        }
    }
}
