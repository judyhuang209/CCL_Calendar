namespace WindowsFormsApp2
{
    partial class Form_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "";
            this.startDatePicker.Location = new System.Drawing.Point(116, 12);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(107, 22);
            this.startDatePicker.TabIndex = 0;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "開始時間：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13F);
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "結束時間：";
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "";
            this.endDatePicker.Location = new System.Drawing.Point(116, 48);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(107, 22);
            this.endDatePicker.TabIndex = 0;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 13F);
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "內容：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(48, 129);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(95, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(202, 129);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(95, 23);
            this.button_confirm.TabIndex = 3;
            this.button_confirm.Text = "確定";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "tt hh:mm";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(229, 12);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(100, 22);
            this.startTimePicker.TabIndex = 4;
            this.startTimePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "tt hh:mm";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(229, 48);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(100, 22);
            this.endTimePicker.TabIndex = 4;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // Form_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 170);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Name = "Form_add";
            this.Text = "Form_add";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_add_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
    }
}