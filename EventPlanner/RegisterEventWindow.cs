﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    
    /// <summary>
    /// Form allowing user to add a new event.
    /// </summary>

    public partial class RegisterEventWindow : Form
    {
        /// <summary>
        /// List containing the days (and corresponding times) for the event
        /// </summary>
        List<Day> Days = new List<Day>();

        /// <summary>
        /// list of timeboxes created
        /// </summary>
        List<Tuple<ComboBox, ComboBox>> timeBoxes = new List<Tuple<ComboBox, ComboBox>>();

        /// <summary>
        /// List of tasks
        /// </summary>
        List<TextBox> eventTasks = new List<TextBox>();

        /// <summary>
        /// Dynamic list of added days and boxes
        /// </summary>
        List<Tuple<Label, Button>> dateBox = new List<Tuple<Label, Button>>();

        /// <summary>
        /// List of half hour times (starts)
        /// </summary>
        List<ComboBoxDateTime> halfHourDateTimes = new List<ComboBoxDateTime>();

        /// <summary>
        /// list of half hour times (ends)
        /// </summary>
        List<ComboBoxDateTime> halfHourDateTimesForEnd = new List<ComboBoxDateTime>();
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\eventSaveFile.json";

        private string userName;

        /// <summary>
        /// Constructor for the RegisterEventWindow form.
        /// </summary>
        /// <param name="selectedDate">The date selected by the user.</param>
        /// <param name="use24Hour">Whether 24 hour time will be used.</param>
        /// <param name="username">The name provided by the user.</param>
        public RegisterEventWindow(DateTime selectedDate, bool use24Hour, string username)
        {
            InitializeComponent();
            userName = username;
            dateLabel.Text = "Adding event";

            ComboBoxDateTime currentTime = new ComboBoxDateTime(selectedDate, use24Hour);


            /*
             ** To show only valid time slots. For today, don't show time slots for time that has passed.
             */
            //If the selected date is after today, show all 48 time slots. That is, let the loop run 48 times.
            //if ( selectedDate.Date > DateTime.Now)
            //{
            //    currentTime = new ComboBoxDateTime(selectedDate.Date, use24Hour);
            //    local_hrs = -1;
            //}

            ////If the selected date is today, round off to the nearest next half hour using the Round method. Pass that to ComboBoxDateTime
            ////Loop should run such that only slots till midnight are displayed. Should not run 48 times.
            //else
            //{
            //    DateTime test = Round(DateTime.Now); //Get current time rounded to the next hour
            //    currentTime = new ComboBoxDateTime(test, use24Hour);
            //    local_hrs = DateTime.Now.Hour*2; 
            //}

            for (int i = 0; i < 48; i++)
            {
                halfHourDateTimes.Add(currentTime);
                halfHourDateTimesForEnd.Add(currentTime);
                currentTime = new ComboBoxDateTime(currentTime.inner.AddMinutes(30), use24Hour);
            }
            DateTime midnight = selectedDate.AddDays(1);
            halfHourDateTimesForEnd.Add(new ComboBoxDateTime(midnight, use24Hour));

            // add label for the initial day
            Label newDateLabel = new Label();

            // add stuff to new label
            newDateLabel.Text = selectedDate.ToShortDateString();
            newDateLabel.Size = new System.Drawing.Size(150, 24);
            newDateLabel.TextAlign = ContentAlignment.MiddleCenter;

            // add set time button for initial day
            Button newDateButton = new Button();

            // add stuff to new button
            newDateButton.Text = "Set Times from Below";
            newDateButton.Size = new System.Drawing.Size(150, 24);
            newDateButton.Tag = selectedDate;
            newDateButton.Click += new EventHandler(this.setDayTimes);

            // add to the list of the combos
            dateBox.Add(new Tuple<Label, Button>(newDateLabel, newDateButton));

            // add them to the flowchart
            flowLayoutPanel3.Controls.Add(newDateButton);
            flowLayoutPanel3.Controls.Add(newDateLabel);
            flowLayoutPanel3.SetFlowBreak(newDateLabel, true);

        }

        /// <summary>
        /// Round a DateTime to the nearest 30 minutes.
        /// </summary>
        /// <param name="dateTime">The Current Date selected by the user.</param>
        public static DateTime Round(DateTime dateTime)
        {
            var updated = dateTime.AddMinutes(30);

            if (dateTime.Minute < 30)
            {
                return new DateTime(updated.Year, updated.Month, updated.Day,
                                 updated.Hour, 30, 0, dateTime.Kind);
            }
            else
            {
                return new DateTime(updated.Year, updated.Month, updated.Day,
                                 updated.Hour, 0, 0, dateTime.Kind);
            }
            
        }

        //make a new event object with the user's chosen options, write it to file
        /// <summary>
        /// Click behavior for the save button.
        /// Check for valid input in the form and collect user input.
        /// </summary>
        /// <param name="sender">The sending winforms object.</param>
        /// <param name="e">Winforms event arguments.</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(nameTextBox.Text);
            foreach (TextBox box in eventTasks)
            {
                Console.WriteLine(box.Text);
            }
            foreach (Day day in Days)
            {
                String errorText = "";
                Boolean inputError = false;
                Boolean comboBoxError = false;

                DateTime previousEndTime = DateTime.MinValue;
                DateTime previousStartTime = DateTime.MinValue;

                nameTextBox.Text += "->" + day.date.ToShortDateString();

                int capInt;
                bool timeWindowError = false;

                List<Tuple<DateTime, DateTime>> dateTimes = new List<Tuple<DateTime, DateTime>>();

                //Master List of tasks affiliated with each event
                List<Tuple<String, String>> ListOfTasks = new List<Tuple<String, String>>();

                int.TryParse(capacityText.Text, out capInt);

                //Adds Each Task Created by the event host to the master list of tasks affiliated with the event
                foreach (TextBox task in eventTasks)
                {
                    String person = "";
                    String taskDef = task.Text;
                    ListOfTasks.Add(new Tuple<String, String>(person, taskDef));
                }


                foreach (Tuple<ComboBox, ComboBox> currentBoxes in timeBoxes)
                {
                    //ensure the time slots are valid
                    //if end time is 12:00 AM that is equivalent to 11:59:59 pm, not a repeat or smaller number.
                    DateTime startTime = (currentBoxes.Item1.SelectedValue as ComboBoxDateTime).inner;
                    DateTime endTime = (currentBoxes.Item2.SelectedValue as ComboBoxDateTime).inner;
                    
                    if (nameTextBox.Text.Length == 0)
                    {
                        errorText = String.Concat(errorText, "\n Event name cannot be empty.");
                        inputError = true;
                    }
                    if (nameTextBox.Text.Length > 36)
                    {
                        errorText = String.Concat(errorText, "\nEvent name is too long.");
                        inputError = true;
                    }
                    if (File.Exists(path))
                    {
                        List<Event> evts = JsonConvert.DeserializeObject<List<Event>>(File.ReadAllText(path));
                        foreach (Event evt in evts)
                        {
                            if (evt.nameOfEvent == nameTextBox.Text)
                            {
                                inputError = true;
                                errorText = String.Concat(errorText, "\nEvent name already exists.");
                            }
                        }
                    }

                    if (capInt == 0)
                    {
                        errorText = String.Concat(errorText, "\nCapacity must be a nonzero number.");
                        inputError = true;
                    }
                    if (locationText.Text.Length == 0)
                    {
                        errorText = String.Concat(errorText, "\n Event Location cannot be empty.");
                        inputError = true;
                    }
                    if (briefMessageText.Text.Length == 0)
                    {
                        errorText = String.Concat(errorText, "\n Event Description cannot be empty.");
                        inputError = true;
                    }
                    if (inputError)
                    {
                        MessageBox.Show(errorText);
                    }
                    else
                    {
                        buildEvent(capInt, day.timeBoxForDay, ListOfTasks);
                    }
                }
                nameTextBox.Text = nameTextBox.Text.Split(new string[] { "->" }, StringSplitOptions.None)[0];
            }
        }

        /// <summary>
        /// Builds a new event object from the user's input and writes it to file.
        /// </summary>
        /// <param name="capInt">The user's chosen capacity value, converted to int.</param>
        /// <param name="dateTimes">The user's chosen DateTime time slots</param>
        /// <param name="MasterTaskList"></param>
        private void buildEvent(int capInt, List<Tuple<DateTime, DateTime>> dateTimes, List<Tuple<String, String>> MasterTaskList)
        {
            //Write event specified by user to file
            this.Close();

            //create an event with the event constructor
            Event evt = new Event(nameTextBox.Text, userName, briefMessageText.Text, dateTimes, locationText.Text, 1, capInt, MasterTaskList);
            //establish list of attendees affiliated with this given event.
            List<Tuple<String, List<DateTime>>> startingAttendees = new List<Tuple<string, List<DateTime>>>();
            List<DateTime> attendeeDTs = new List<DateTime>();

            //Add the attendees to the list
            foreach (Tuple<DateTime, DateTime> tuple in dateTimes)
            {
                DateTime currentTime = tuple.Item1;
                while (currentTime != tuple.Item2)
                {
                    attendeeDTs.Add(currentTime);
                    currentTime = currentTime.AddMinutes(30);
                }
            }
            startingAttendees.Add(new Tuple<String, List<DateTime>>(userName, attendeeDTs));
            evt.attendees = startingAttendees;

            JsonSerializer serializer = new JsonSerializer();

            // Write the string to a file.
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter file = new StreamWriter(path, append: true))
                    {
                        //TODO add event to usersavefile too.
                        List<Event> evts = new List<Event>();
                        evts.Add(evt);
                        serializer.Serialize(file, evts);
                    }
                }
                else
                {
                    List<Event> evts = JsonConvert.DeserializeObject<List<Event>>(File.ReadAllText(path));
                    evts.Add(evt);
                    using (StreamWriter file = new StreamWriter(path, append: false))
                    {
                        serializer.Serialize(file, evts);
                    }
                }
                MessageBox.Show("Event created! You will be added as an attendee to this event.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("File write failed with exception." + ex.ToString());
            }

        }

        /// <summary>
        /// Click behavior for the add slot button.
        /// Dynamically add two more combo boxes for the user to input a second, non-contiguous time slot.
        /// </summary>
        /// <param name="sender">The sending winforms object.</param>
        /// <param name="e">Winforms event arguments.</param>
        private void addSlotButton_Click(object sender, EventArgs e)
        {
            ComboBox newStartBox = new ComboBox();
            newStartBox.Text = "Start Time";
            newStartBox.BindingContext = new BindingContext();
            newStartBox.DataSource = halfHourDateTimes;
            newStartBox.DropDownStyle = ComboBoxStyle.DropDownList;

            ComboBox newEndBox = new ComboBox();
            newEndBox.Text = "End Time";
            newEndBox.BindingContext = new BindingContext();
            newEndBox.DataSource = halfHourDateTimesForEnd;
            newEndBox.DropDownStyle = ComboBoxStyle.DropDownList;

            timeBoxes.Add(new Tuple<ComboBox, ComboBox>(newStartBox, newEndBox));
            flowLayoutPanel1.Controls.Add(newStartBox);
            flowLayoutPanel1.Controls.Add(newEndBox);
            //add another row of combo boxes for the user to add another, non-contiguous timeslot
        }


        //Adds CueBoxes to the second flow layout panel dynamically.
        /// <summary>
        /// Click Behavior for the AddTask Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            CueTextBox NameOfTask = new CueTextBox();
            NameOfTask.Cue = "Enter a new task";
            eventTasks.Add(NameOfTask);
            flowLayoutPanel2.Controls.Add(NameOfTask);
        }

        
        //remove aditional time windows if you've added them
        /// <summary>
        /// Click behavior for the remove time slot button.
        /// Remove the last added time slot.
        /// </summary>
        /// <param name="sender">The sending winforms object.</param>
        /// <param name="e">Winforms event arguments.</param>
        private void removeTimeSlotButton_Click(object sender, EventArgs e)
        {
            if (timeBoxes.Count >= 1)
            {
                flowLayoutPanel1.Controls.Remove(timeBoxes.Last().Item1);
                flowLayoutPanel1.Controls.Remove(timeBoxes.Last().Item2);
                timeBoxes.Remove(timeBoxes.Last());
            }
        }
        /// <summary>
        /// Delete Instance of taskbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///deletes instances of task cueboxes created within the flow layout panel
        private void DeleteTaskBtn_Click(object sender, EventArgs e)
        {
            if (eventTasks.Count >= 1)
            {
                flowLayoutPanel2.Controls.Remove(eventTasks.Last());
                eventTasks.Remove(eventTasks.Last());
            }
        }

        /// <summary>
        /// KeyPress behavior for the capacity textbox.
        /// Prevents the addition of any characters other than digits.
        /// </summary>
        /// <param name="sender">The sending winforms object.</param>
        /// <param name="e">Winforms event arguments.</param>

        private void capacityText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// A wrapper for the DateTime class for 24 hour formatting.
        /// </summary>
        private class ComboBoxDateTime
        {
            private String sts;
            /// <summary>
            /// The short time string of the contained DateTime.
            /// </summary>
            public string shortTimeString { get { return sts; } set { sts = value; } }
            /// <summary>
            /// The short time string of the contained date time, with (Next Day) appended if it's 12:00AM.
            /// </summary>
            public string shortTimeStringForEndBoxes
            {
                get { if (!sts.Equals("12:00 AM")){
                        return sts;
                    }
                    else
                    {
                        return (sts + "(Next Day)");
                    }
                }
                set { shortTimeStringForEndBoxes = value; }
            }
            /// <summary>
            /// The DateTime contained by the wrapper class.
            /// </summary>
            public DateTime inner;
            /// <summary>
            /// Constructor for the ComboBoxDateTime wrapper object.
            /// </summary>
            /// <param name="dt">The dateTime to be contained by the object</param>
            /// <param name="use24Hour">Whether to use 24 hour time.</param>
            public ComboBoxDateTime(DateTime dt, bool use24Hour)
            {
                this.inner = dt;
                if (use24Hour)
                {
                    String dateFormat = "HH:mm";
                    this.sts = inner.ToString(dateFormat);
                }
                else
                {
                    this.sts = inner.ToShortTimeString();
                }

            }
            /// <summary>
            /// ToString override for ComboBoxDateTime. 
            /// </summary>
            /// <returns>The short time string of the object's DateTime in the specified format.</returns>
            public override string ToString()
            {
                return this.sts;
            }
        }

        /// <summary>
        /// Click behavior for the cancel button.
        /// Closes the window.
        /// </summary>
        /// <param name="sender">The sending winforms object.</param>
        /// <param name="e">Winforms event arguments.</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDay_Click(object sender, EventArgs e)
        {
            DateTime newDate;

            using (var form = new AddDay())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // gets value from form
                    newDate = form.selectedDate;

                    // check if the date is repeated
                    bool repeated = false;
                    foreach (Control ctl in flowLayoutPanel3.Controls)
                    {
                        if (ctl.Text == newDate.ToShortDateString())
                        {
                            repeated = true;
                        }
                    }

                    // if not repeated, add corresponding label and button
                    if (!repeated)
                    {
                        Label newDateLabel = new Label();
                        //add stuff to new label
                        newDateLabel.Text = newDate.ToShortDateString();
                        newDateLabel.Size = new System.Drawing.Size(150, 24);
                        newDateLabel.TextAlign = ContentAlignment.MiddleCenter;

                        Button newDateButton = new Button();
                        //add stuff to new button
                        newDateButton.Text = "Set Times From Below";
                        newDateButton.Size = new System.Drawing.Size(150, 24);
                        newDateButton.Tag = newDate;
                        newDateButton.Click += new EventHandler(this.setDayTimes);

                        dateBox.Add(new Tuple<Label, Button>(newDateLabel, newDateButton));

                        flowLayoutPanel3.Controls.Add(newDateButton);
                        flowLayoutPanel3.Controls.Add(newDateLabel);
                        flowLayoutPanel3.SetFlowBreak(newDateLabel, true);

                    }
                    else
                    {
                        MessageBox.Show("The date you selected is already in this event.");
                    }
                }
            }
        }
        
        /// <summary>
        /// Sets Times for a specific day
        /// </summary>
        private void setDayTimes(object sender, EventArgs e)
        {
            // get date of the day of the button
            DateTime d = (DateTime)(sender as Button).Tag;

            bool comboBoxError = false;
            bool inputError = false;
            string errorText = "";

            List<Tuple<DateTime, DateTime>> dateTimes = new List<Tuple<DateTime, DateTime>>();
            List<Tuple<DateTime, DateTime>> newDateTimes = new List<Tuple<DateTime, DateTime>>();

            // from each drop down box, load the times into a list
            foreach (Tuple<ComboBox, ComboBox> currentBoxes in timeBoxes)
            {
                //ensure the time slots are valid
                //if end time is 12:00 AM that is equivalent to 11:59:59 pm, not a repeat or smaller number.
                DateTime startTime = (currentBoxes.Item1.SelectedValue as ComboBoxDateTime).inner;
                DateTime endTime = (currentBoxes.Item2.SelectedValue as ComboBoxDateTime).inner;

                // check if and slots are not possible
                if (endTime <= startTime && !endTime.ToShortTimeString().Equals("12:00 AM") && !comboBoxError)
                {
                    errorText = String.Concat(errorText, "At least one of the time slots is impossible.");
                    comboBoxError = true;
                    inputError = true;
                }

                // check an odd endtime
                if (endTime.ToShortTimeString().Equals("12:00 AM"))
                {
                    endTime = endTime.AddDays(1);
                }

                dateTimes.Add(new Tuple<DateTime, DateTime>(startTime, endTime));
                dateTimes.Sort((x, y) => DateTime.Compare(x.Item1, y.Item1));

            }

            // change the times to the correct 
            if (dateTimes.Count != 0)
            {
                DateTime test = dateTimes[0].Item1;
                int dayNum = 0;
                if (test.Date != d.Date)
                {
                    dayNum = (d - test).Days + 1;
                }
                test = test.AddDays(dayNum);
                foreach (Tuple<DateTime, DateTime> times in dateTimes)
                {
                    DateTime one = times.Item1.AddDays(dayNum);
                    DateTime two = times.Item2.AddDays(dayNum);
                    newDateTimes.Add(new Tuple<DateTime, DateTime>(one, two));
                }
            }
            
            // check for overlapping times 
            for (int i = 0; i < dateTimes.Count; i++)
            {
                DateTime start = dateTimes[i].Item1;
                DateTime end = dateTimes[i].Item2;

                // check for time in the past
                if (start.Date == DateTime.Now.Date && start.TimeOfDay < DateTime.Now.TimeOfDay)
                {
                    inputError = true;
                    errorText = String.Concat(errorText, "\nOne of the times is set in the past");
                }

                int num = i;
                for (int j = num - 1; j >= 0; j--)
                {
                    DateTime startTest = dateTimes[j].Item1;
                    DateTime endTest = dateTimes[j].Item2;

                    if ( ((start.TimeOfDay >= startTest.TimeOfDay) && (start.TimeOfDay < endTest.TimeOfDay)) ||
                         ((endTest.TimeOfDay > start.TimeOfDay)   && (endTest.TimeOfDay <= end.TimeOfDay))   ||
                         ((end.TimeOfDay > startTest.TimeOfDay)   && (end.TimeOfDay <= endTest.TimeOfDay))   ||
                         ((startTest.TimeOfDay >= start.TimeOfDay) && (startTest.TimeOfDay < end.TimeOfDay)) )
                    {
                        errorText = String.Concat(errorText, "\nTwo of the selected time windows overlap.");
                        inputError = true;
                    }

                }
            }

            // show error, or create a new day and add times
            if (inputError)
            {
                MessageBox.Show(errorText);
            }
            else
            {
                Day newDay = new Day(d,newDateTimes);
                string times = "-> ";
                foreach (Tuple<ComboBox, ComboBox> currentBox in timeBoxes)
                {
                    DateTime startTime = (currentBox.Item1.SelectedValue as ComboBoxDateTime).inner;
                    DateTime endTime = (currentBox.Item2.SelectedValue as ComboBoxDateTime).inner;

                    times += startTime.ToShortTimeString() + "-" + endTime.ToShortTimeString() + "; ";
                }

                MessageBox.Show("For date: " + d.ToShortDateString() + ", the following times were set " + times);

                bool check = true;

                // check if the date is already in the list of days
                // if it is, edit the times
                foreach (Day day in Days)
                {
                    if (day.date == d)
                    {
                        day.timeBoxForDay = newDay.timeBoxForDay;
                        check = false;
                        break;
                        
                    }
                }

                // if the date is not in the list, add a new day
                if (check)
                {
                    Days.Add(newDay);
                }

            }
        }

        /// <summary>
        /// remove previous day
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeDay_Click(object sender, EventArgs e)
        {
            if (dateBox.Count >= 1)
            {
                flowLayoutPanel3.Controls.Remove(dateBox.Last().Item1);
                flowLayoutPanel3.Controls.Remove(dateBox.Last().Item2);
                dateBox.Remove(dateBox.Last());
            }
        }

        /// <summary>
        /// checks what times are set 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkTime_Click(object sender, EventArgs e)
        {
            string text = "Current Times/Dates\n";
            foreach (Day day in Days)
            {
                text += day.date + ": ";
                List<Tuple<DateTime,DateTime>> timeBoxesDay = day.timeBoxForDay;
                foreach (Tuple<DateTime,DateTime> times in timeBoxesDay)
                {
                    DateTime startTime = times.Item1;
                    DateTime endTime = times.Item2;

                    text += startTime.ToShortTimeString() + "-" + endTime.ToShortTimeString() + "; ";
                }
                text += "\n";
            }
            MessageBox.Show(text);
        }
    }
}
