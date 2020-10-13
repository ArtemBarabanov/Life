namespace WindowsFormsApp6
{
    partial class LifeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Rewind = new System.Windows.Forms.Button();
            this.GenerationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetsComboBox = new System.Windows.Forms.ComboBox();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.Cycle_Timer = new System.Windows.Forms.Timer(this.components);
            this.Start_Stop = new System.Windows.Forms.Button();
            this.Load_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.WhatButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rewind
            // 
            this.Rewind.Location = new System.Drawing.Point(854, 50);
            this.Rewind.Name = "Rewind";
            this.Rewind.Size = new System.Drawing.Size(75, 38);
            this.Rewind.TabIndex = 1;
            this.Rewind.Text = "Сброс";
            this.Rewind.UseVisualStyleBackColor = true;
            this.Rewind.Click += new System.EventHandler(this.Rewind_Click);
            // 
            // GenerationBox
            // 
            this.GenerationBox.Enabled = false;
            this.GenerationBox.Location = new System.Drawing.Point(828, 205);
            this.GenerationBox.Name = "GenerationBox";
            this.GenerationBox.ReadOnly = true;
            this.GenerationBox.Size = new System.Drawing.Size(100, 20);
            this.GenerationBox.TabIndex = 0;
            this.GenerationBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(825, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Счетчик поколений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(850, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Скорость";
            // 
            // SetsComboBox
            // 
            this.SetsComboBox.FormattingEnabled = true;
            this.SetsComboBox.Items.AddRange(new object[] {
            "Вертушка",
            "Галактика",
            "Космический корабль",
            "Крест",
            "Мигалка",
            "Пентадекатлон",
            "Планер",
            "Ружье",
            "Часы"});
            this.SetsComboBox.Location = new System.Drawing.Point(808, 373);
            this.SetsComboBox.Name = "SetsComboBox";
            this.SetsComboBox.Size = new System.Drawing.Size(121, 21);
            this.SetsComboBox.TabIndex = 5;
            this.SetsComboBox.SelectedIndexChanged += new System.EventHandler(this.SetsComboBox_SelectedIndexChanged);
            // 
            // SpeedBar
            // 
            this.SpeedBar.Location = new System.Drawing.Point(824, 290);
            this.SpeedBar.Maximum = 4;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(104, 45);
            this.SpeedBar.TabIndex = 6;
            this.SpeedBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SpeedBar.Value = 2;
            this.SpeedBar.Scroll += new System.EventHandler(this.SpeedBar_Scroll);
            // 
            // Cycle_Timer
            // 
            this.Cycle_Timer.Enabled = true;
            this.Cycle_Timer.Interval = 250;
            this.Cycle_Timer.Tick += new System.EventHandler(this.Cycle_Timer_Tick);
            // 
            // Start_Stop
            // 
            this.Start_Stop.Location = new System.Drawing.Point(853, 94);
            this.Start_Stop.Name = "Start_Stop";
            this.Start_Stop.Size = new System.Drawing.Size(75, 41);
            this.Start_Stop.TabIndex = 7;
            this.Start_Stop.Text = "Старт";
            this.Start_Stop.UseVisualStyleBackColor = true;
            this.Start_Stop.Click += new System.EventHandler(this.Start_Stop_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Location = new System.Drawing.Point(37, 60);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(75, 23);
            this.Load_Button.TabIndex = 8;
            this.Load_Button.Text = "Загрузить";
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(38, 31);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 9;
            this.Save_Button.Text = "Сохранить";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // WhatButton
            // 
            this.WhatButton.Location = new System.Drawing.Point(827, 13);
            this.WhatButton.Name = "WhatButton";
            this.WhatButton.Size = new System.Drawing.Size(101, 23);
            this.WhatButton.TabIndex = 10;
            this.WhatButton.Text = "Что это такое?";
            this.WhatButton.UseVisualStyleBackColor = true;
            this.WhatButton.Click += new System.EventHandler(this.WhatButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(831, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Выбрать колонию";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Save_Button);
            this.groupBox1.Controls.Add(this.Load_Button);
            this.groupBox1.Location = new System.Drawing.Point(808, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Колонию в файл";
            // 
            // LifeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 778);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WhatButton);
            this.Controls.Add(this.Start_Stop);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.SetsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerationBox);
            this.Controls.Add(this.Rewind);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LifeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Жизнь";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Rewind;
        private System.Windows.Forms.TextBox GenerationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SetsComboBox;
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.Timer Cycle_Timer;
        private System.Windows.Forms.Button Start_Stop;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button WhatButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

