using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    /// <summary>
    /// Calendar Popup for adding a day.
    /// </summary>

    public partial class AddDay : Form
    {

        /// <summary>
        /// New date Variable. 
        /// </summary>
        public DateTime selectedDate;

        /// <summary>
        /// Constructor.
        /// </summary>
        public AddDay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click behavior for the date submission button.
        /// </summary>
        /// <param name="sender">The sending winforms object.</param>
        /// <param name="e">Winforms event arguments.</param>
        public void AddDayButton_Click(object sender, EventArgs e)
        {
            // get the selected day
            this.selectedDate = mainCalendar.SelectionStart;

            // check to make sure the day is not in the past
            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("Select a current or future date to add events.");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Exit the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
