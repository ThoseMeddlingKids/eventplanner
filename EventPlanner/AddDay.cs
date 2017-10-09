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
            this.selectedDate = mainCalendar.SelectionStart;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


/*
 * TODO:
 * 
 * RegisterEventWindow line 25: use this to store and create new dates
 * work on way to get value from form and store it in label and such
 * assign label and button values
 * make button form for extra times
 * enable chosen first day to show up in days
 *  
 */
