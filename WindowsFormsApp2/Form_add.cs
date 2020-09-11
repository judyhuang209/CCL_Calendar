﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form_add : Form
    {
        public Form_add(Form1 form1)
        {
            InitializeComponent();
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            DateTime taskStartTime = startDatePicker.Value.Date + startTimePicker.Value.TimeOfDay;
            DateTime taskEndTime = endDatePicker.Value.Date + endTimePicker.Value.TimeOfDay;
            DateTime recordDate = DateTime.Now;
            String text = textBox1.Text;
            String AgentID = "103213";
            Console.WriteLine(taskStartTime);
            Console.WriteLine(textBox1.Text);

            String connStr = "";
            SqlConnection cnn;
            connStr = "Data Source=192.168.0.227; Initial Catalog=TVsale_NEW; User ID=SA; Password=#5a3@578A";
            cnn = new SqlConnection(connStr);
            try
            {
                cnn.Open();

                // Fetch Personal Event data table
                String strSQL = "insert into Calendar_PersonalEvent " +
                                "(AgentID, PersonalEvent, StartTime, EndTime, RecordDate)" +
                                "values (@AgentID, @text, @taskStartTime, @taskEndTime, @recordDate)";
                SqlDataAdapter adapter = new SqlDataAdapter();
                
                adapter.InsertCommand.Parameters.Add("@AgentID", SqlDbType.VarChar).Value = AgentID;
                adapter.InsertCommand.Parameters.Add("@text", SqlDbType.NVarChar).Value = text;
                adapter.InsertCommand.Parameters.Add("@taskStartTime", SqlDbType.SmallDateTime).Value = taskStartTime;
                adapter.InsertCommand.Parameters.Add("@taskEndTime", SqlDbType.SmallDateTime).Value = taskEndTime;
                adapter.InsertCommand.Parameters.Add("@recordDate", SqlDbType.SmallDateTime).Value = recordDate;

                adapter.InsertCommand = new SqlCommand(strSQL, cnn);
                cnn.Close();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed!");
            }
        }

        private void Form_add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Update();
        }
    }
}