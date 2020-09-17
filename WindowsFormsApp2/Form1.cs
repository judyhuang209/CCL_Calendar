                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;

namespace WindowsFormsApp2
{
    // UNDER THE AGENT ID: 103213

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime date = DateTime.Today;
        String timeNowStr = DateTime.Now.ToString("HHmm");
        DataTable Table_Holiday;
        DataTable Table_Holiday_Per;
        DataTable Table_Personal;
        List<FlowLayoutPanel> listCell;

        private void Form1_Load(object sender, EventArgs e)
        {
            String dateStr = date.ToString("yyyy/MM/dd");
            // Console.WriteLine(date);

            #region 抓現在時間，控制捲軸初始位置
            int timeNow = Int16.Parse(timeNowStr);
            Label timeSection = new Label();
            // dateToday.Text = dateStr;
            // Console.WriteLine(timeNow / 100);    //檢查現在時間
            // 判斷現在時間點決定捲軸Y位置
            if (timeNow/100 < 8)
            {
                timeSection = section9_10;
            }
            else if (timeNow/100 > 21)
            {
                timeSection = section20_21;
            }
            else
            {
                switch (timeNow/100)
                {
                    case 8:
                        timeSection = section9_10;
                        break;
                    case 9:
                        timeSection = section9_10;
                        break;
                    case 10:
                        timeSection = section10_11;
                        break;
                    case 11:
                        timeSection = section11_12;
                        break;
                    case 12:
                        timeSection = section12_13;
                        break;
                    case 13:
                        timeSection = section13_14;
                        break;
                    case 14:
                        timeSection =section14_15;
                        break;
                    case 15:
                        timeSection = section15_16;
                        break;
                    case 16:
                        timeSection = section16_17;
                        break;
                    case 17:
                        timeSection = section17_18;
                        break;
                    case 18:
                        timeSection = section18_19;
                        break;
                    case 19:
                        timeSection = section19_20;
                        break;
                    case 20:
                        timeSection = section20_21;
                        break;
                    case 21:
                        timeSection = section20_21;
                        break;
                }
            }

            #endregion


            String connStr = "";
            SqlConnection cnn;
            connStr = "Data Source=192.168.0.227; Initial Catalog=TVsale_NEW; User ID=SA; Password=#5a3@578A";
            cnn = new SqlConnection(connStr);
            try
            {
                cnn.Open();
                MessageBox.Show("Successful connection!");

                // Fetch Holiday data table
                /*
                String strSQL = "select EYHoliday_Name, EYHoliday_Date " +
                          "from Holiday_EY " +
                          "order by EYHoliday_Date desc";

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet("Schedules");
                adapter.SelectCommand = new SqlCommand(strSQL, cnn);
                adapter.Fill(dataSet, "Holiday_EY");
                */
                Table_Holiday = SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_EYHoliday").Tables[0];


                // Fetch Personal Holiday data table
                /*
                strSQL = "select Category as Event, VacationFrom as StartTime, VacationTo as EndTime, UpdateTime " +
                         "from Holiday_Date_Table " +
                         "where EmpID = '103213' " +
                         "order by VacationFrom desc";
                */
                // adapter.SelectCommand = new SqlCommand(strSQL, cnn);
                // Fill in data set
                // adapter.Fill(dataSet, "Holiday_Per");
                // Table_Holiday_Per = dataSet.Tables["Holiday_Per"];
                Table_Holiday_Per = SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_Holiday", new object[] { "103213" }).Tables[0];

                // Fetch Personal Event data table
                /*String strSQL = // "insert into Holiday_Date_Table " +
                         "select PersonalEvent, StartTime, EndTime, RecordDate " +
                         "from Calendar_PersonalEvent " +
                         "where AgentID = '103213' " +
                         "order by StartTime desc";
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet("Schedules");
                adapter.SelectCommand = new SqlCommand(strSQL, cnn);
                // Fill in data set
                adapter.Fill(dataSet, "Personal");
                Table_Personal = dataSet.Tables["Personal"];
                */
                Table_Personal = SqlHelper.ExecuteDataset(cnn, "xsp_Calendar_PersonalEvent", new object[] { "103213" }).Tables[0];

                // PrintRows(dataSet);
                ShowTable(Table_Personal);

                /*
                DataRow lastrow = Table.Rows[Table.Rows.Count - 1];
                Console.WriteLine(lastrow[0]);
                */

                // close connection
                cnn.Close();

                // scroll down to time section
                Point p = new Point(0, timeSection.Location.Y);
                tableLayoutPanel1.AutoScrollPosition = p;

                #region initial tab2
                weekday1.Text = DateTimePicker2.Value.ToString("yyyy/MM/dd ddd");
                weekday2.Text = DateTimePicker2.Value.AddDays(1).ToString("yyyy/MM/dd ddd");
                weekday3.Text = DateTimePicker2.Value.AddDays(2).ToString("yyyy/MM/dd ddd");
                weekday4.Text = DateTimePicker2.Value.AddDays(3).ToString("yyyy/MM/dd ddd");
                weekday5.Text = DateTimePicker2.Value.AddDays(4).ToString("yyyy/MM/dd ddd");
                weekday6.Text = DateTimePicker2.Value.AddDays(5).ToString("yyyy/MM/dd ddd");
                weekday7.Text = DateTimePicker2.Value.AddDays(6).ToString("yyyy/MM/dd ddd");
                #endregion

                listCell = new List<FlowLayoutPanel>
                {
                    Cell9, Cell10, Cell11, Cell12, Cell13, Cell14,
                    Cell15, Cell16, Cell17, Cell18, Cell19, Cell20
                };

                DayOffOrNot(DateTimePicker1.Value, Table_Holiday);
                SectionOffOrNot(DateTimePicker1.Value, Table_Holiday_Per, Table_Personal);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed!");
            }

        }


        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button_PrevDay_Click(object sender, EventArgs e)
        {
            DateTimePicker1.Value = DateTimePicker1.Value.AddDays(-1);
            // Console.WriteLine(dateTimePicker1.Value.ToString());
        }

        private void Button_NextDay_Click(object sender, EventArgs e)
        {
            DateTimePicker1.Value = DateTimePicker1.Value.AddDays(1);
        }

        private void Button_prevWeek_Click(object sender, EventArgs e)
        {
            DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-7);
            #region update tab2
            weekday1.Text = DateTimePicker2.Value.ToString("yyyy/MM/dd ddd");
            // Console.WriteLine(weekday1.Text);
            weekday2.Text = DateTimePicker2.Value.AddDays(1).ToString("yyyy/MM/dd ddd");
            weekday3.Text = DateTimePicker2.Value.AddDays(2).ToString("yyyy/MM/dd ddd");
            weekday4.Text = DateTimePicker2.Value.AddDays(3).ToString("yyyy/MM/dd ddd");
            weekday5.Text = DateTimePicker2.Value.AddDays(4).ToString("yyyy/MM/dd ddd");
            weekday6.Text = DateTimePicker2.Value.AddDays(5).ToString("yyyy/MM/dd ddd");
            weekday7.Text = DateTimePicker2.Value.AddDays(6).ToString("yyyy/MM/dd ddd");
            #endregion
        }

        private void Button_nextWeek_Click(object sender, EventArgs e)
        {
            DateTimePicker2.Value = DateTimePicker2.Value.AddDays(7);
            #region update tab2
            weekday1.Text = DateTimePicker2.Value.ToString("yyyy/MM/dd ddd");
            // Console.WriteLine(weekday1.Text);
            weekday2.Text = DateTimePicker2.Value.AddDays(1).ToString("yyyy/MM/dd ddd");
            weekday3.Text = DateTimePicker2.Value.AddDays(2).ToString("yyyy/MM/dd ddd");
            weekday4.Text = DateTimePicker2.Value.AddDays(3).ToString("yyyy/MM/dd ddd");
            weekday5.Text = DateTimePicker2.Value.AddDays(4).ToString("yyyy/MM/dd ddd");
            weekday6.Text = DateTimePicker2.Value.AddDays(5).ToString("yyyy/MM/dd ddd");
            weekday7.Text = DateTimePicker2.Value.AddDays(6).ToString("yyyy/MM/dd ddd");
            #endregion
        }

        private void DisableTable()
        {
            tableLayoutPanel1.BackColor = Color.DimGray;
            tableLayoutPanel1.AutoScrollPosition = new Point(0, 0);
            tableLayoutPanel1.Enabled = false;
        }

        private void EnableTable()
        {
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.Enabled = true;
        }

        private void DisableSection(int Start, int End, List<FlowLayoutPanel> listCell, String str)
        {
            Console.WriteLine(Start);
            for (int i = Start; i<End; i++)
            {
                Label EventName = new System.Windows.Forms.Label();
                EventName.Text = str;
                listCell[i - 9].BackColor = Color.Pink;
                // listCell[i - 9].Enabled = false;
                listCell[i - 9].Controls.Add(EventName);
                listCell[i - 9].ContextMenuStrip = day_busy_MenuStrip;
            }
        }

        private void EnableSection()
        {
            for (int i = 0; i < 12; i++)
            {
                listCell[i].BackColor = Color.Transparent;
                listCell[i].Enabled = true;
                listCell[i].Controls.Clear();
                // Load Personal Event
            }
        }


        private void PrintRows(DataSet dataSet)
        {
            // For each table in the DataSet, print the values of each row.
            foreach (DataTable thisTable in dataSet.Tables)
            {
                // For each row, print the values of each column.
                foreach (DataRow row in thisTable.Rows)
                {
                    foreach (DataColumn column in thisTable.Columns)
                    {
                        Console.WriteLine(row[column]);
                    }
                }
            }
        }

        private static void ShowTable(DataTable table)
        {
            foreach (DataColumn col in table.Columns)
            {
                Console.Write("{0,-14}", col.ColumnName);
            }
            Console.WriteLine();

            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    if (col.DataType.Equals(typeof(DateTime)))
                        Console.Write("{0,-14:d}", row[col]);
                    else if (col.DataType.Equals(typeof(Decimal)))
                        Console.Write("{0,-14:C}", row[col]);
                    else
                        Console.Write("{0,-14}", row[col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void DayOffOrNot(DateTime DateToday, DataTable Table)
        {
            EnableTable();
            foreach (DataRow row in Table.Rows)
            {
                // check if date today is holiday
                String HolidayDate = row[1].ToString();
                if (DateToday.ToString() == HolidayDate)
                {
                    DisableTable();
                    Console.WriteLine("table disabled");
                    LabelDayOff.Visible = true;
                    LabelDayOff.Text = row[0].ToString();
                    // Console.WriteLine(labelDayOff.Text);
                    break;
                }
                else if (row == Table.Rows[Table.Rows.Count-1])
                {
                    EnableTable();
                    LabelDayOff.Visible = false;
                }
                // String HolidayType = row["Type"].ToString();
                // String HolidayNote = row["Note"].ToString();
            }

        }

        private void SectionOffOrNot(DateTime DateToday, DataTable Table1, DataTable Table2)
        {
            EnableSection();
            foreach (DataRow row in Table1.Rows)
            {
                // check if date today is holiday
                DateTime startTime = (DateTime)row[1];
                DateTime endTime = (DateTime)row[2];
                String OffDate = startTime.ToShortDateString();

                if (DateToday.ToShortDateString() == OffDate)
                {
                    String temp = startTime.ToString("HH");
                    int start = Int32.Parse(temp);
                    temp = endTime.ToString("HH");
                    int end = Int32.Parse(temp);
                    DisableSection(start, end, listCell, row[0].ToString());
                    break;
                }
                // String HolidayType = row["Type"].ToString();
                // String HolidayNote = row["Note"].ToString();
            }
            foreach (DataRow row in Table2.Rows)
            {
                // check if date today is holiday
                DateTime startTime = (DateTime)row[1];
                DateTime endTime = (DateTime)row[2];
                String OffDate = startTime.ToShortDateString();

                if (DateToday.ToShortDateString() == OffDate)
                {
                    String temp = startTime.ToString("HH");
                    int start = Int32.Parse(temp);
                    temp = endTime.ToString("HH");
                    int end = Int32.Parse(temp);
                    DisableSection(start, end, listCell, row[0].ToString());
                    break;
                }
                // String HolidayType = row["Type"].ToString();
                // String HolidayNote = row["Note"].ToString();
            }

        }


        private void DateTimePicker1_ValueChanged(Object sender, EventArgs e)
        {
            // MessageBox.Show("You are in the DateTimePicker.ValueChanged event.");
            DayOffOrNot(DateTimePicker1.Value, Table_Holiday);
            SectionOffOrNot(DateTimePicker1.Value, Table_Holiday_Per, Table_Personal);

        }

        Control sourceControl = null;


        private void Day_busy_MenuStrip_Opened(object sender, EventArgs e)
        {
            sourceControl = day_busy_MenuStrip.SourceControl;
        }
        private void day_busy_MenuStrip_Click(object sender, EventArgs e)
        {
            var menuStrip = (ContextMenuStrip)sender;
            Console.WriteLine(menuStrip.Name);
            Console.WriteLine(sourceControl);
        }

        // 詳細
        private void Day_detail_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sourceControl.Name);
        }


        private void Day_free_MenuStrip_Opened(object sender, EventArgs e)
        {
            sourceControl = day_free_MenuStrip.SourceControl;
        }

        private void Day_free_MenuStrip_Click(object sender, EventArgs e)
        {
            var menuStrip = (ContextMenuStrip)sender;
            Console.WriteLine(menuStrip.Name);
            Console.WriteLine(sourceControl);
        }

        private void Day_add_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_add form_Add = new Form_add(this);
            form_Add.ShowDialog();
        }

    }
}
