namespace DesktopTimeClock
{
    partial class FrmDesktopTimeClock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblEnterHours = new Label();
            LblExitHours = new Label();
            LblTotalHours = new Label();
            LblHoursBalance = new Label();
            BtnClear = new Button();
            BtnPrint = new Button();
            TimeEnterHour1 = new DateTimePicker();
            TimeEnterHour2 = new DateTimePicker();
            TimeEnterHour3 = new DateTimePicker();
            TimeEnterHour4 = new DateTimePicker();
            TimeExitHour4 = new DateTimePicker();
            TimeExitHour3 = new DateTimePicker();
            TimeExitHour2 = new DateTimePicker();
            TimeExitHour1 = new DateTimePicker();
            TimeHoursBalance = new DateTimePicker();
            TimeTotalHour4 = new DateTimePicker();
            TimeTotalHour3 = new DateTimePicker();
            TimeTotalHour2 = new DateTimePicker();
            TimeTotalHour1 = new DateTimePicker();
            SuspendLayout();
            // 
            // LblEnterHours
            // 
            LblEnterHours.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEnterHours.Location = new Point(12, 30);
            LblEnterHours.Name = "LblEnterHours";
            LblEnterHours.Size = new Size(63, 26);
            LblEnterHours.TabIndex = 16;
            LblEnterHours.Text = "Entrada";
            LblEnterHours.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblExitHours
            // 
            LblExitHours.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblExitHours.Location = new Point(212, 30);
            LblExitHours.Name = "LblExitHours";
            LblExitHours.Size = new Size(63, 26);
            LblExitHours.TabIndex = 17;
            LblExitHours.Text = "Saída";
            LblExitHours.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblTotalHours
            // 
            LblTotalHours.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTotalHours.Location = new Point(412, 30);
            LblTotalHours.Name = "LblTotalHours";
            LblTotalHours.Size = new Size(63, 26);
            LblTotalHours.TabIndex = 18;
            LblTotalHours.Text = "Total";
            LblTotalHours.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblHoursBalance
            // 
            LblHoursBalance.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblHoursBalance.Location = new Point(12, 280);
            LblHoursBalance.Name = "LblHoursBalance";
            LblHoursBalance.Size = new Size(63, 26);
            LblHoursBalance.TabIndex = 15;
            LblHoursBalance.Text = "Total";
            LblHoursBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(212, 280);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(63, 26);
            BtnClear.TabIndex = 13;
            BtnClear.Text = "Limpar";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnPrint
            // 
            BtnPrint.Location = new Point(412, 280);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(63, 26);
            BtnPrint.TabIndex = 14;
            BtnPrint.Text = "Imprimir";
            BtnPrint.UseVisualStyleBackColor = true;
            // 
            // TimeEnterHour1
            // 
            TimeEnterHour1.CustomFormat = "HH:mm";
            TimeEnterHour1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeEnterHour1.Format = DateTimePickerFormat.Custom;
            TimeEnterHour1.Location = new Point(12, 80);
            TimeEnterHour1.Name = "TimeEnterHour1";
            TimeEnterHour1.ShowUpDown = true;
            TimeEnterHour1.Size = new Size(63, 26);
            TimeEnterHour1.TabIndex = 0;
            TimeEnterHour1.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            TimeEnterHour1.ValueChanged += TimeEnterHour1_ValueChanged;
            // 
            // TimeEnterHour2
            // 
            TimeEnterHour2.CustomFormat = "HH:mm";
            TimeEnterHour2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeEnterHour2.Format = DateTimePickerFormat.Custom;
            TimeEnterHour2.Location = new Point(12, 130);
            TimeEnterHour2.Name = "TimeEnterHour2";
            TimeEnterHour2.ShowUpDown = true;
            TimeEnterHour2.Size = new Size(63, 26);
            TimeEnterHour2.TabIndex = 3;
            TimeEnterHour2.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            TimeEnterHour2.ValueChanged += TimeEnterHour2_ValueChanged;
            // 
            // TimeEnterHour3
            // 
            TimeEnterHour3.CustomFormat = "HH:mm";
            TimeEnterHour3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeEnterHour3.Format = DateTimePickerFormat.Custom;
            TimeEnterHour3.Location = new Point(12, 180);
            TimeEnterHour3.Name = "TimeEnterHour3";
            TimeEnterHour3.ShowUpDown = true;
            TimeEnterHour3.Size = new Size(63, 26);
            TimeEnterHour3.TabIndex = 6;
            TimeEnterHour3.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            TimeEnterHour3.ValueChanged += TimeEnterHour3_ValueChanged;
            // 
            // TimeEnterHour4
            // 
            TimeEnterHour4.CustomFormat = "HH:mm";
            TimeEnterHour4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeEnterHour4.Format = DateTimePickerFormat.Custom;
            TimeEnterHour4.Location = new Point(12, 230);
            TimeEnterHour4.Name = "TimeEnterHour4";
            TimeEnterHour4.ShowUpDown = true;
            TimeEnterHour4.Size = new Size(63, 26);
            TimeEnterHour4.TabIndex = 9;
            TimeEnterHour4.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            TimeEnterHour4.ValueChanged += TimeEnterHour4_ValueChanged;
            // 
            // TimeExitHour4
            // 
            TimeExitHour4.CustomFormat = "HH:mm";
            TimeExitHour4.Enabled = false;
            TimeExitHour4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeExitHour4.Format = DateTimePickerFormat.Custom;
            TimeExitHour4.Location = new Point(212, 230);
            TimeExitHour4.Name = "TimeExitHour4";
            TimeExitHour4.ShowUpDown = true;
            TimeExitHour4.Size = new Size(63, 26);
            TimeExitHour4.TabIndex = 10;
            TimeExitHour4.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            TimeExitHour4.ValueChanged += TimeExitHour4_ValueChanged;
            // 
            // TimeExitHour3
            // 
            TimeExitHour3.CustomFormat = "HH:mm";
            TimeExitHour3.Enabled = false;
            TimeExitHour3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeExitHour3.Format = DateTimePickerFormat.Custom;
            TimeExitHour3.Location = new Point(212, 180);
            TimeExitHour3.Name = "TimeExitHour3";
            TimeExitHour3.ShowUpDown = true;
            TimeExitHour3.Size = new Size(63, 26);
            TimeExitHour3.TabIndex = 7;
            TimeExitHour3.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            TimeExitHour3.ValueChanged += TimeExitHour3_ValueChanged;
            // 
            // TimeExitHour2
            // 
            TimeExitHour2.CustomFormat = "HH:mm";
            TimeExitHour2.Enabled = false;
            TimeExitHour2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeExitHour2.Format = DateTimePickerFormat.Custom;
            TimeExitHour2.Location = new Point(212, 130);
            TimeExitHour2.Name = "TimeExitHour2";
            TimeExitHour2.ShowUpDown = true;
            TimeExitHour2.Size = new Size(63, 26);
            TimeExitHour2.TabIndex = 4;
            TimeExitHour2.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            TimeExitHour2.ValueChanged += TimeExitHour2_ValueChanged;
            // 
            // TimeExitHour1
            // 
            TimeExitHour1.CustomFormat = "HH:mm";
            TimeExitHour1.Enabled = false;
            TimeExitHour1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeExitHour1.Format = DateTimePickerFormat.Custom;
            TimeExitHour1.Location = new Point(212, 80);
            TimeExitHour1.Name = "TimeExitHour1";
            TimeExitHour1.ShowUpDown = true;
            TimeExitHour1.Size = new Size(63, 26);
            TimeExitHour1.TabIndex = 1;
            TimeExitHour1.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            TimeExitHour1.ValueChanged += TimeExitHour1_ValueChanged;
            // 
            // TimeHoursBalance
            // 
            TimeHoursBalance.CustomFormat = "HH:mm";
            TimeHoursBalance.Enabled = false;
            TimeHoursBalance.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeHoursBalance.Format = DateTimePickerFormat.Custom;
            TimeHoursBalance.Location = new Point(82, 280);
            TimeHoursBalance.Name = "TimeHoursBalance";
            TimeHoursBalance.Size = new Size(63, 26);
            TimeHoursBalance.TabIndex = 12;
            TimeHoursBalance.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            // 
            // TimeTotalHour4
            // 
            TimeTotalHour4.CustomFormat = "HH:mm";
            TimeTotalHour4.Enabled = false;
            TimeTotalHour4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeTotalHour4.Format = DateTimePickerFormat.Custom;
            TimeTotalHour4.Location = new Point(412, 230);
            TimeTotalHour4.Name = "TimeTotalHour4";
            TimeTotalHour4.Size = new Size(63, 26);
            TimeTotalHour4.TabIndex = 11;
            TimeTotalHour4.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            // 
            // TimeTotalHour3
            // 
            TimeTotalHour3.CustomFormat = "HH:mm";
            TimeTotalHour3.Enabled = false;
            TimeTotalHour3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeTotalHour3.Format = DateTimePickerFormat.Custom;
            TimeTotalHour3.Location = new Point(412, 180);
            TimeTotalHour3.Name = "TimeTotalHour3";
            TimeTotalHour3.Size = new Size(63, 26);
            TimeTotalHour3.TabIndex = 8;
            TimeTotalHour3.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            // 
            // TimeTotalHour2
            // 
            TimeTotalHour2.CustomFormat = "HH:mm";
            TimeTotalHour2.Enabled = false;
            TimeTotalHour2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeTotalHour2.Format = DateTimePickerFormat.Custom;
            TimeTotalHour2.Location = new Point(412, 130);
            TimeTotalHour2.Name = "TimeTotalHour2";
            TimeTotalHour2.Size = new Size(63, 26);
            TimeTotalHour2.TabIndex = 5;
            TimeTotalHour2.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            // 
            // TimeTotalHour1
            // 
            TimeTotalHour1.CustomFormat = "HH:mm";
            TimeTotalHour1.Enabled = false;
            TimeTotalHour1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeTotalHour1.Format = DateTimePickerFormat.Custom;
            TimeTotalHour1.Location = new Point(412, 80);
            TimeTotalHour1.Name = "TimeTotalHour1";
            TimeTotalHour1.Size = new Size(63, 26);
            TimeTotalHour1.TabIndex = 2;
            TimeTotalHour1.Value = new DateTime(2024, 2, 18, 0, 0, 0, 0);
            // 
            // FrmDesktopTimeClock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 334);
            Controls.Add(TimeTotalHour4);
            Controls.Add(TimeTotalHour3);
            Controls.Add(TimeTotalHour2);
            Controls.Add(TimeTotalHour1);
            Controls.Add(TimeHoursBalance);
            Controls.Add(TimeExitHour4);
            Controls.Add(TimeExitHour3);
            Controls.Add(TimeExitHour2);
            Controls.Add(TimeExitHour1);
            Controls.Add(TimeEnterHour4);
            Controls.Add(TimeEnterHour3);
            Controls.Add(TimeEnterHour2);
            Controls.Add(TimeEnterHour1);
            Controls.Add(BtnPrint);
            Controls.Add(BtnClear);
            Controls.Add(LblHoursBalance);
            Controls.Add(LblTotalHours);
            Controls.Add(LblExitHours);
            Controls.Add(LblEnterHours);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDesktopTimeClock";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folha de ponto eletrônica";
            ResumeLayout(false);
        }

        #endregion

        private Label LblEnterHours;
        private Label LblExitHours;
        private Label LblTotalHours;
        private Label LblHoursBalance;
        private Button BtnClear;
        private Button BtnPrint;
        private DateTimePicker TimeEnterHour1;
        private DateTimePicker TimeEnterHour2;
        private DateTimePicker TimeEnterHour3;
        private DateTimePicker TimeEnterHour4;
        private DateTimePicker TimeExitHour4;
        private DateTimePicker TimeExitHour3;
        private DateTimePicker TimeExitHour2;
        private DateTimePicker TimeExitHour1;
        private DateTimePicker TimeHoursBalance;
        private DateTimePicker TimeTotalHour4;
        private DateTimePicker TimeTotalHour3;
        private DateTimePicker TimeTotalHour2;
        private DateTimePicker TimeTotalHour1;
    }
}
