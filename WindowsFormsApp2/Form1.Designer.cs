﻿using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DayOrWeek = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelDayOff = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Button_NextDay = new System.Windows.Forms.Button();
            this.Button_PrevDay = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.section10_11 = new System.Windows.Forms.Label();
            this.section11_12 = new System.Windows.Forms.Label();
            this.section12_13 = new System.Windows.Forms.Label();
            this.section13_14 = new System.Windows.Forms.Label();
            this.section14_15 = new System.Windows.Forms.Label();
            this.section16_17 = new System.Windows.Forms.Label();
            this.section15_16 = new System.Windows.Forms.Label();
            this.section17_18 = new System.Windows.Forms.Label();
            this.section18_19 = new System.Windows.Forms.Label();
            this.section19_20 = new System.Windows.Forms.Label();
            this.section20_21 = new System.Windows.Forms.Label();
            this.section9_10 = new System.Windows.Forms.Label();
            this.Cell9 = new System.Windows.Forms.FlowLayoutPanel();
            this.day_free_MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.day_add_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cell10 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell11 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell12 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell13 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell14 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell15 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell16 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell17 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell18 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell19 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cell20 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.weekday2 = new System.Windows.Forms.Label();
            this.weekday1 = new System.Windows.Forms.Label();
            this.weekday3 = new System.Windows.Forms.Label();
            this.weekday4 = new System.Windows.Forms.Label();
            this.weekday5 = new System.Windows.Forms.Label();
            this.weekday6 = new System.Windows.Forms.Label();
            this.weekday7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Button_NextWeek = new System.Windows.Forms.Button();
            this.Button_PrevWeek = new System.Windows.Forms.Button();
            this.day_busy_MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.day_detail_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.day_edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.day_del_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DayOrWeek.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.day_free_MenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.day_busy_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DayOrWeek
            // 
            this.DayOrWeek.Controls.Add(this.tabPage1);
            this.DayOrWeek.Controls.Add(this.tabPage2);
            this.DayOrWeek.Location = new System.Drawing.Point(11, 11);
            this.DayOrWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DayOrWeek.Name = "DayOrWeek";
            this.DayOrWeek.SelectedIndex = 0;
            this.DayOrWeek.Size = new System.Drawing.Size(1076, 544);
            this.DayOrWeek.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1068, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "每日";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LabelDayOff);
            this.panel1.Controls.Add(this.DateTimePicker1);
            this.panel1.Controls.Add(this.Button_NextDay);
            this.panel1.Controls.Add(this.Button_PrevDay);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 54);
            this.panel1.TabIndex = 1;
            // 
            // LabelDayOff
            // 
            this.LabelDayOff.AutoSize = true;
            this.LabelDayOff.Enabled = false;
            this.LabelDayOff.Font = new System.Drawing.Font("新細明體", 15F);
            this.LabelDayOff.Location = new System.Drawing.Point(16, 14);
            this.LabelDayOff.Name = "LabelDayOff";
            this.LabelDayOff.Size = new System.Drawing.Size(130, 25);
            this.LabelDayOff.TabIndex = 3;
            this.LabelDayOff.Text = "labelDayOff";
            this.LabelDayOff.Visible = false;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Font = new System.Drawing.Font("新細明體", 15F);
            this.DateTimePicker1.Location = new System.Drawing.Point(435, 8);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(223, 37);
            this.DateTimePicker1.TabIndex = 2;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Button_NextDay
            // 
            this.Button_NextDay.Location = new System.Drawing.Point(664, 14);
            this.Button_NextDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_NextDay.Name = "Button_NextDay";
            this.Button_NextDay.Size = new System.Drawing.Size(45, 25);
            this.Button_NextDay.TabIndex = 1;
            this.Button_NextDay.Text = ">>";
            this.Button_NextDay.UseVisualStyleBackColor = true;
            this.Button_NextDay.Click += new System.EventHandler(this.Button_NextDay_Click);
            // 
            // Button_PrevDay
            // 
            this.Button_PrevDay.AutoSize = true;
            this.Button_PrevDay.Location = new System.Drawing.Point(384, 14);
            this.Button_PrevDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_PrevDay.Name = "Button_PrevDay";
            this.Button_PrevDay.Size = new System.Drawing.Size(45, 31);
            this.Button_PrevDay.TabIndex = 1;
            this.Button_PrevDay.Text = "<<";
            this.Button_PrevDay.UseVisualStyleBackColor = true;
            this.Button_PrevDay.Click += new System.EventHandler(this.Button_PrevDay_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.section10_11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.section11_12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.section12_13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.section13_14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.section14_15, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.section16_17, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.section15_16, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.section17_18, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.section18_19, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.section19_20, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.section20_21, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.section9_10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cell9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cell10, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cell11, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Cell12, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Cell13, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Cell14, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Cell15, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Cell16, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Cell17, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.Cell18, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.Cell19, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.Cell20, 1, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1062, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // section10_11
            // 
            this.section10_11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section10_11.AutoSize = true;
            this.section10_11.Font = new System.Drawing.Font("新細明體", 16F);
            this.section10_11.Location = new System.Drawing.Point(4, 48);
            this.section10_11.Name = "section10_11";
            this.section10_11.Size = new System.Drawing.Size(161, 46);
            this.section10_11.TabIndex = 1;
            this.section10_11.Text = "10:00 - 11:00";
            this.section10_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section11_12
            // 
            this.section11_12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section11_12.AutoSize = true;
            this.section11_12.Font = new System.Drawing.Font("新細明體", 16F);
            this.section11_12.Location = new System.Drawing.Point(4, 95);
            this.section11_12.Name = "section11_12";
            this.section11_12.Size = new System.Drawing.Size(161, 46);
            this.section11_12.TabIndex = 1;
            this.section11_12.Text = "11:00 - 12:00";
            this.section11_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section12_13
            // 
            this.section12_13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section12_13.AutoSize = true;
            this.section12_13.Font = new System.Drawing.Font("新細明體", 16F);
            this.section12_13.Location = new System.Drawing.Point(4, 142);
            this.section12_13.Name = "section12_13";
            this.section12_13.Size = new System.Drawing.Size(161, 46);
            this.section12_13.TabIndex = 1;
            this.section12_13.Text = "12:00 - 13:00";
            this.section12_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section13_14
            // 
            this.section13_14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section13_14.AutoSize = true;
            this.section13_14.Font = new System.Drawing.Font("新細明體", 16F);
            this.section13_14.Location = new System.Drawing.Point(4, 189);
            this.section13_14.Name = "section13_14";
            this.section13_14.Size = new System.Drawing.Size(161, 46);
            this.section13_14.TabIndex = 1;
            this.section13_14.Text = "13:00 - 14:00";
            this.section13_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section14_15
            // 
            this.section14_15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section14_15.AutoSize = true;
            this.section14_15.Font = new System.Drawing.Font("新細明體", 16F);
            this.section14_15.Location = new System.Drawing.Point(4, 236);
            this.section14_15.Name = "section14_15";
            this.section14_15.Size = new System.Drawing.Size(161, 46);
            this.section14_15.TabIndex = 1;
            this.section14_15.Text = "14:00 - 15:00";
            this.section14_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section16_17
            // 
            this.section16_17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section16_17.AutoSize = true;
            this.section16_17.Font = new System.Drawing.Font("新細明體", 16F);
            this.section16_17.Location = new System.Drawing.Point(4, 330);
            this.section16_17.Name = "section16_17";
            this.section16_17.Size = new System.Drawing.Size(161, 46);
            this.section16_17.TabIndex = 1;
            this.section16_17.Text = "16:00 - 17:00";
            this.section16_17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section15_16
            // 
            this.section15_16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section15_16.AutoSize = true;
            this.section15_16.Font = new System.Drawing.Font("新細明體", 16F);
            this.section15_16.Location = new System.Drawing.Point(4, 283);
            this.section15_16.Name = "section15_16";
            this.section15_16.Size = new System.Drawing.Size(161, 46);
            this.section15_16.TabIndex = 1;
            this.section15_16.Text = "15:00 - 16:00";
            this.section15_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section17_18
            // 
            this.section17_18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section17_18.AutoSize = true;
            this.section17_18.Font = new System.Drawing.Font("新細明體", 16F);
            this.section17_18.Location = new System.Drawing.Point(4, 377);
            this.section17_18.Name = "section17_18";
            this.section17_18.Size = new System.Drawing.Size(161, 46);
            this.section17_18.TabIndex = 1;
            this.section17_18.Text = "17:00 - 18:00";
            this.section17_18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section18_19
            // 
            this.section18_19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section18_19.AutoSize = true;
            this.section18_19.Font = new System.Drawing.Font("新細明體", 16F);
            this.section18_19.Location = new System.Drawing.Point(4, 424);
            this.section18_19.Name = "section18_19";
            this.section18_19.Size = new System.Drawing.Size(161, 46);
            this.section18_19.TabIndex = 1;
            this.section18_19.Text = "18:00 - 19:00";
            this.section18_19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section19_20
            // 
            this.section19_20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section19_20.AutoSize = true;
            this.section19_20.Font = new System.Drawing.Font("新細明體", 16F);
            this.section19_20.Location = new System.Drawing.Point(4, 471);
            this.section19_20.Name = "section19_20";
            this.section19_20.Size = new System.Drawing.Size(161, 46);
            this.section19_20.TabIndex = 1;
            this.section19_20.Text = "19:00 - 20:00";
            this.section19_20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section20_21
            // 
            this.section20_21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section20_21.AutoSize = true;
            this.section20_21.Font = new System.Drawing.Font("新細明體", 16F);
            this.section20_21.Location = new System.Drawing.Point(4, 518);
            this.section20_21.Name = "section20_21";
            this.section20_21.Size = new System.Drawing.Size(161, 91);
            this.section20_21.TabIndex = 1;
            this.section20_21.Text = "20:00 - 21:00";
            this.section20_21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // section9_10
            // 
            this.section9_10.AutoSize = true;
            this.section9_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.section9_10.Font = new System.Drawing.Font("新細明體", 16F);
            this.section9_10.Location = new System.Drawing.Point(4, 1);
            this.section9_10.Name = "section9_10";
            this.section9_10.Size = new System.Drawing.Size(161, 46);
            this.section9_10.TabIndex = 1;
            this.section9_10.Text = "9:00 - 10:00";
            this.section9_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell9
            // 
            this.Cell9.AutoSize = true;
            this.Cell9.BackColor = System.Drawing.Color.Transparent;
            this.Cell9.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell9.Location = new System.Drawing.Point(172, 3);
            this.Cell9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell9.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell9.Name = "Cell9";
            this.Cell9.Size = new System.Drawing.Size(882, 42);
            this.Cell9.TabIndex = 2;
            // 
            // day_free_MenuStrip
            // 
            this.day_free_MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.day_free_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.day_add_ToolStripMenuItem});
            this.day_free_MenuStrip.Name = "day_MenuStrip2";
            this.day_free_MenuStrip.Size = new System.Drawing.Size(109, 28);
            this.day_free_MenuStrip.Click += new System.EventHandler(this.Day_free_MenuStrip_Click);
            // 
            // day_add_ToolStripMenuItem
            // 
            this.day_add_ToolStripMenuItem.Name = "day_add_ToolStripMenuItem";
            this.day_add_ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.day_add_ToolStripMenuItem.Text = "新增";
            this.day_add_ToolStripMenuItem.Click += new System.EventHandler(this.Day_add_ToolStripMenuItem_Click);
            // 
            // Cell10
            // 
            this.Cell10.AutoSize = true;
            this.Cell10.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell10.Location = new System.Drawing.Point(172, 50);
            this.Cell10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell10.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell10.Name = "Cell10";
            this.Cell10.Size = new System.Drawing.Size(882, 42);
            this.Cell10.TabIndex = 3;
            // 
            // Cell11
            // 
            this.Cell11.AutoSize = true;
            this.Cell11.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell11.Location = new System.Drawing.Point(172, 97);
            this.Cell11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell11.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell11.Name = "Cell11";
            this.Cell11.Size = new System.Drawing.Size(882, 42);
            this.Cell11.TabIndex = 4;
            // 
            // Cell12
            // 
            this.Cell12.AutoSize = true;
            this.Cell12.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell12.Location = new System.Drawing.Point(172, 144);
            this.Cell12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell12.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell12.Name = "Cell12";
            this.Cell12.Size = new System.Drawing.Size(882, 42);
            this.Cell12.TabIndex = 5;
            // 
            // Cell13
            // 
            this.Cell13.AutoSize = true;
            this.Cell13.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell13.Location = new System.Drawing.Point(172, 191);
            this.Cell13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell13.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell13.Name = "Cell13";
            this.Cell13.Size = new System.Drawing.Size(882, 42);
            this.Cell13.TabIndex = 6;
            // 
            // Cell14
            // 
            this.Cell14.AutoSize = true;
            this.Cell14.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell14.Location = new System.Drawing.Point(172, 238);
            this.Cell14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell14.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell14.Name = "Cell14";
            this.Cell14.Size = new System.Drawing.Size(882, 42);
            this.Cell14.TabIndex = 7;
            // 
            // Cell15
            // 
            this.Cell15.AutoSize = true;
            this.Cell15.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell15.Location = new System.Drawing.Point(172, 285);
            this.Cell15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell15.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell15.Name = "Cell15";
            this.Cell15.Size = new System.Drawing.Size(882, 42);
            this.Cell15.TabIndex = 8;
            // 
            // Cell16
            // 
            this.Cell16.AutoSize = true;
            this.Cell16.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell16.Location = new System.Drawing.Point(172, 332);
            this.Cell16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell16.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell16.Name = "Cell16";
            this.Cell16.Size = new System.Drawing.Size(882, 42);
            this.Cell16.TabIndex = 9;
            // 
            // Cell17
            // 
            this.Cell17.AutoSize = true;
            this.Cell17.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell17.Location = new System.Drawing.Point(172, 379);
            this.Cell17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell17.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell17.Name = "Cell17";
            this.Cell17.Size = new System.Drawing.Size(882, 42);
            this.Cell17.TabIndex = 10;
            // 
            // Cell18
            // 
            this.Cell18.AutoSize = true;
            this.Cell18.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell18.Location = new System.Drawing.Point(172, 426);
            this.Cell18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell18.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell18.Name = "Cell18";
            this.Cell18.Size = new System.Drawing.Size(882, 42);
            this.Cell18.TabIndex = 11;
            // 
            // Cell19
            // 
            this.Cell19.AutoSize = true;
            this.Cell19.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell19.Location = new System.Drawing.Point(172, 473);
            this.Cell19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell19.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell19.Name = "Cell19";
            this.Cell19.Size = new System.Drawing.Size(882, 42);
            this.Cell19.TabIndex = 12;
            // 
            // Cell20
            // 
            this.Cell20.AutoSize = true;
            this.Cell20.ContextMenuStrip = this.day_free_MenuStrip;
            this.Cell20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cell20.Location = new System.Drawing.Point(172, 520);
            this.Cell20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cell20.MinimumSize = new System.Drawing.Size(865, 42);
            this.Cell20.Name = "Cell20";
            this.Cell20.Size = new System.Drawing.Size(882, 87);
            this.Cell20.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1068, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "每週";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel2.Controls.Add(this.weekday2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.weekday1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.weekday3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.weekday4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.weekday5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.weekday6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.weekday7, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 66);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.747045F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.25295F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1061, 444);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // weekday2
            // 
            this.weekday2.AutoSize = true;
            this.weekday2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekday2.Location = new System.Drawing.Point(167, 2);
            this.weekday2.Name = "weekday2";
            this.weekday2.Size = new System.Drawing.Size(154, 37);
            this.weekday2.TabIndex = 1;
            this.weekday2.Text = "weekday2";
            this.weekday2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekday1
            // 
            this.weekday1.AutoSize = true;
            this.weekday1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekday1.Location = new System.Drawing.Point(5, 2);
            this.weekday1.Name = "weekday1";
            this.weekday1.Size = new System.Drawing.Size(154, 37);
            this.weekday1.TabIndex = 0;
            this.weekday1.Text = "weekday1";
            this.weekday1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekday3
            // 
            this.weekday3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekday3.Location = new System.Drawing.Point(329, 2);
            this.weekday3.Name = "weekday3";
            this.weekday3.Size = new System.Drawing.Size(154, 37);
            this.weekday3.TabIndex = 0;
            this.weekday3.Text = "weekday3";
            this.weekday3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekday4
            // 
            this.weekday4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekday4.Location = new System.Drawing.Point(491, 2);
            this.weekday4.Name = "weekday4";
            this.weekday4.Size = new System.Drawing.Size(154, 37);
            this.weekday4.TabIndex = 0;
            this.weekday4.Text = "weekday4";
            this.weekday4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekday5
            // 
            this.weekday5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekday5.Location = new System.Drawing.Point(653, 2);
            this.weekday5.Name = "weekday5";
            this.weekday5.Size = new System.Drawing.Size(154, 37);
            this.weekday5.TabIndex = 0;
            this.weekday5.Text = "weekday5";
            this.weekday5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekday6
            // 
            this.weekday6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekday6.Location = new System.Drawing.Point(815, 2);
            this.weekday6.Name = "weekday6";
            this.weekday6.Size = new System.Drawing.Size(154, 37);
            this.weekday6.TabIndex = 0;
            this.weekday6.Text = "weekday6";
            this.weekday6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekday7
            // 
            this.weekday7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekday7.Location = new System.Drawing.Point(977, 2);
            this.weekday7.Name = "weekday7";
            this.weekday7.Size = new System.Drawing.Size(259, 37);
            this.weekday7.TabIndex = 0;
            this.weekday7.Text = "weekday7";
            this.weekday7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DateTimePicker2);
            this.panel2.Controls.Add(this.Button_NextWeek);
            this.panel2.Controls.Add(this.Button_PrevWeek);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 54);
            this.panel2.TabIndex = 2;
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Location = new System.Drawing.Point(461, 14);
            this.DateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(145, 25);
            this.DateTimePicker2.TabIndex = 2;
            this.DateTimePicker2.Value = new System.DateTime(2020, 8, 5, 0, 0, 0, 0);
            // 
            // Button_NextWeek
            // 
            this.Button_NextWeek.AutoSize = true;
            this.Button_NextWeek.Location = new System.Drawing.Point(612, 14);
            this.Button_NextWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_NextWeek.Name = "Button_NextWeek";
            this.Button_NextWeek.Size = new System.Drawing.Size(83, 31);
            this.Button_NextWeek.TabIndex = 1;
            this.Button_NextWeek.Text = "下一週";
            this.Button_NextWeek.UseVisualStyleBackColor = true;
            this.Button_NextWeek.Click += new System.EventHandler(this.Button_nextWeek_Click);
            // 
            // Button_PrevWeek
            // 
            this.Button_PrevWeek.AutoSize = true;
            this.Button_PrevWeek.Location = new System.Drawing.Point(372, 14);
            this.Button_PrevWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_PrevWeek.Name = "Button_PrevWeek";
            this.Button_PrevWeek.Size = new System.Drawing.Size(83, 31);
            this.Button_PrevWeek.TabIndex = 1;
            this.Button_PrevWeek.Text = "上一週";
            this.Button_PrevWeek.UseVisualStyleBackColor = true;
            this.Button_PrevWeek.Click += new System.EventHandler(this.Button_prevWeek_Click);
            // 
            // day_busy_MenuStrip
            // 
            this.day_busy_MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.day_busy_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.day_detail_ToolStripMenuItem,
            this.day_edit_ToolStripMenuItem,
            this.day_del_ToolStripMenuItem});
            this.day_busy_MenuStrip.Name = "day_busy_MenuStrip";
            this.day_busy_MenuStrip.Size = new System.Drawing.Size(109, 76);
            this.day_busy_MenuStrip.Opened += new System.EventHandler(this.Day_busy_MenuStrip_Opened);
            this.day_busy_MenuStrip.Click += new System.EventHandler(this.day_busy_MenuStrip_Click);
            // 
            // day_detail_ToolStripMenuItem
            // 
            this.day_detail_ToolStripMenuItem.Name = "day_detail_ToolStripMenuItem";
            this.day_detail_ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.day_detail_ToolStripMenuItem.Text = "詳情";
            this.day_detail_ToolStripMenuItem.Click += new System.EventHandler(this.Day_detail_ToolStripMenuItem_Click);
            // 
            // day_edit_ToolStripMenuItem
            // 
            this.day_edit_ToolStripMenuItem.Name = "day_edit_ToolStripMenuItem";
            this.day_edit_ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.day_edit_ToolStripMenuItem.Text = "編輯";
            // 
            // day_del_ToolStripMenuItem
            // 
            this.day_del_ToolStripMenuItem.Name = "day_del_ToolStripMenuItem";
            this.day_del_ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.day_del_ToolStripMenuItem.Text = "刪除";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 568);
            this.Controls.Add(this.DayOrWeek);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "行事曆";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DayOrWeek.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.day_free_MenuStrip.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.day_busy_MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

    }


        #endregion

        private System.Windows.Forms.TabControl DayOrWeek;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Button_NextDay;
        private System.Windows.Forms.Button Button_PrevDay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label section10_11;
        private System.Windows.Forms.Label section11_12;
        private System.Windows.Forms.Label section12_13;
        private System.Windows.Forms.Label section13_14;
        private System.Windows.Forms.Label section14_15;
        private System.Windows.Forms.Label section16_17;
        private System.Windows.Forms.Label section15_16;
        private System.Windows.Forms.Label section17_18;
        private System.Windows.Forms.Label section18_19;
        private System.Windows.Forms.Label section19_20;
        private System.Windows.Forms.Label section20_21;
        private System.Windows.Forms.Label section9_10;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
        private System.Windows.Forms.Button Button_NextWeek;
        private System.Windows.Forms.Button Button_PrevWeek;
        private System.Windows.Forms.Label weekday2;
        private System.Windows.Forms.Label weekday1;
        private System.Windows.Forms.Label weekday3;
        private System.Windows.Forms.Label weekday4;
        private System.Windows.Forms.Label weekday5;
        private System.Windows.Forms.Label weekday6;
        private System.Windows.Forms.Label weekday7;
        private System.Windows.Forms.Label LabelDayOff;
        private System.Windows.Forms.FlowLayoutPanel Cell9;
        private System.Windows.Forms.FlowLayoutPanel Cell10;
        private System.Windows.Forms.FlowLayoutPanel Cell11;
        private System.Windows.Forms.FlowLayoutPanel Cell12;
        private System.Windows.Forms.FlowLayoutPanel Cell13;
        private System.Windows.Forms.FlowLayoutPanel Cell14;
        private System.Windows.Forms.FlowLayoutPanel Cell15;
        private System.Windows.Forms.FlowLayoutPanel Cell16;
        private System.Windows.Forms.FlowLayoutPanel Cell17;
        private System.Windows.Forms.FlowLayoutPanel Cell18;
        private System.Windows.Forms.FlowLayoutPanel Cell19;
        private System.Windows.Forms.FlowLayoutPanel Cell20;
        private System.Windows.Forms.ContextMenuStrip day_busy_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem day_detail_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem day_edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem day_del_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip day_free_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem day_add_ToolStripMenuItem;
    }
}

