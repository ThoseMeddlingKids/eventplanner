﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace WindowsFormsApplication1
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {

        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            //open 'add event dialog'
            RegisterEventWindow registerPopup = new RegisterEventWindow();
            registerPopup.ShowDialog();
        }

        private void calendar1_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            //when the user clicks on the calendar, cancel the calendar library's default event creation
            //instead, open our own add event dialog so we can create non-contiguous events
            e.Cancel = true;
            Console.Out.WriteLine("creating");
        }
    }
}