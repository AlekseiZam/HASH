namespace HASH
{
    partial class Form1
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
            LAbel23 = new Label();
            value = new Label();
            Label16 = new Label();
            password = new TextBox();
            hash = new TextBox();
            labbel = new Label();
            label3 = new Label();
            genHashButton = new Button();
            monoTask = new Button();
            button3 = new Button();
            label4 = new Label();
            passwordText1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            timeStart1 = new Label();
            timeEnd1 = new Label();
            time1 = new Label();
            label10 = new Label();
            passwordText2 = new Label();
            time2 = new Label();
            timeStart2 = new Label();
            timeEnd2 = new Label();
            trackBar = new TrackBar();
            minValue = new Label();
            maxValue = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // LAbel23
            // 
            LAbel23.AutoSize = true;
            LAbel23.Location = new Point(34, 24);
            LAbel23.Name = "LAbel23";
            LAbel23.Size = new Size(39, 15);
            LAbel23.TabIndex = 0;
            LAbel23.Text = "min =";
            // 
            // value
            // 
            value.AutoSize = true;
            value.Location = new Point(152, 25);
            value.Name = "value";
            value.Size = new Size(13, 15);
            value.TabIndex = 2;
            value.Text = "0";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Location = new Point(243, 24);
            Label16.Name = "Label16";
            Label16.Size = new Size(41, 15);
            Label16.TabIndex = 3;
            Label16.Text = "max =";
            // 
            // password
            // 
            password.Location = new Point(430, 20);
            password.Name = "password";
            password.Size = new Size(107, 23);
            password.TabIndex = 4;
            // 
            // hash
            // 
            hash.Location = new Point(430, 49);
            hash.Name = "hash";
            hash.Size = new Size(205, 23);
            hash.TabIndex = 5;
            // 
            // labbel
            // 
            labbel.AutoSize = true;
            labbel.Location = new Point(375, 24);
            labbel.Name = "labbel";
            labbel.Size = new Size(49, 15);
            labbel.TabIndex = 6;
            labbel.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 52);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 7;
            label3.Text = "Hash";
            // 
            // genHashButton
            // 
            genHashButton.Location = new Point(682, 17);
            genHashButton.Name = "genHashButton";
            genHashButton.Size = new Size(83, 23);
            genHashButton.TabIndex = 8;
            genHashButton.Text = "Ген. HASH";
            genHashButton.UseVisualStyleBackColor = true;
            genHashButton.Click += genHashButton_click;
            // 
            // monoTask
            // 
            monoTask.Location = new Point(682, 46);
            monoTask.Name = "monoTask";
            monoTask.Size = new Size(83, 23);
            monoTask.TabIndex = 9;
            monoTask.Text = "Одна задача";
            monoTask.UseVisualStyleBackColor = true;
            monoTask.Click += monoTaskButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(682, 75);
            button3.Name = "button3";
            button3.Size = new Size(83, 23);
            button3.TabIndex = 10;
            button3.Text = "Две задачи";
            button3.UseVisualStyleBackColor = true;
            button3.Click += duoTaskButton_click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 121);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 11;
            label4.Text = "Задача 1";
            // 
            // passwordText1
            // 
            passwordText1.AutoSize = true;
            passwordText1.Location = new Point(34, 140);
            passwordText1.Name = "passwordText1";
            passwordText1.Size = new Size(0, 15);
            passwordText1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(651, 140);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 13;
            label5.Text = "Найденный пароль";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(651, 166);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 14;
            label6.Text = "Время начала(тик)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(651, 193);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 15;
            label7.Text = "Время окончания(тик)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(651, 218);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 16;
            label8.Text = "Длительность(мс)";
            // 
            // timeStart1
            // 
            timeStart1.AutoSize = true;
            timeStart1.Location = new Point(34, 166);
            timeStart1.Name = "timeStart1";
            timeStart1.Size = new Size(0, 15);
            timeStart1.TabIndex = 17;
            // 
            // timeEnd1
            // 
            timeEnd1.AutoSize = true;
            timeEnd1.Location = new Point(34, 193);
            timeEnd1.Name = "timeEnd1";
            timeEnd1.Size = new Size(0, 15);
            timeEnd1.TabIndex = 18;
            // 
            // time1
            // 
            time1.AutoSize = true;
            time1.Location = new Point(34, 218);
            time1.Name = "time1";
            time1.Size = new Size(0, 15);
            time1.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(430, 121);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 20;
            label10.Text = "Задача 2";
            // 
            // passwordText2
            // 
            passwordText2.AutoSize = true;
            passwordText2.Location = new Point(359, 140);
            passwordText2.Name = "passwordText2";
            passwordText2.Size = new Size(0, 15);
            passwordText2.TabIndex = 21;
            // 
            // time2
            // 
            time2.AutoSize = true;
            time2.Location = new Point(359, 218);
            time2.Name = "time2";
            time2.Size = new Size(0, 15);
            time2.TabIndex = 22;
            // 
            // timeStart2
            // 
            timeStart2.AutoSize = true;
            timeStart2.Location = new Point(359, 166);
            timeStart2.Name = "timeStart2";
            timeStart2.Size = new Size(0, 15);
            timeStart2.TabIndex = 23;
            // 
            // timeEnd2
            // 
            timeEnd2.AutoSize = true;
            timeEnd2.Location = new Point(359, 193);
            timeEnd2.Name = "timeEnd2";
            timeEnd2.Size = new Size(0, 15);
            timeEnd2.TabIndex = 24;
            // 
            // trackBar
            // 
            trackBar.Location = new Point(34, 52);
            trackBar.Maximum = 999999;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(283, 45);
            trackBar.TabIndex = 25;
            trackBar.Scroll += handleScroll;
            // 
            // minValue
            // 
            minValue.AutoSize = true;
            minValue.Location = new Point(69, 24);
            minValue.Name = "minValue";
            minValue.Size = new Size(38, 15);
            minValue.TabIndex = 26;
            minValue.Text = "label1";
            // 
            // maxValue
            // 
            maxValue.AutoSize = true;
            maxValue.Location = new Point(281, 24);
            maxValue.Name = "maxValue";
            maxValue.Size = new Size(38, 15);
            maxValue.TabIndex = 27;
            maxValue.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maxValue);
            Controls.Add(minValue);
            Controls.Add(trackBar);
            Controls.Add(timeEnd2);
            Controls.Add(timeStart2);
            Controls.Add(time2);
            Controls.Add(passwordText2);
            Controls.Add(label10);
            Controls.Add(time1);
            Controls.Add(timeEnd1);
            Controls.Add(timeStart1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(passwordText1);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(monoTask);
            Controls.Add(genHashButton);
            Controls.Add(label3);
            Controls.Add(labbel);
            Controls.Add(hash);
            Controls.Add(password);
            Controls.Add(Label16);
            Controls.Add(value);
            Controls.Add(LAbel23);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LAbel23;
        private Label value;
        private Label Label16;
        private TextBox password;
        private TextBox hash;
        private Label labbel;
        private Label label3;
        private Button genHashButton;
        private Button monoTask;
        private Button button3;
        private Label label4;
        private Label passwordText1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label timeStart1;
        private Label timeEnd1;
        private Label time1;
        private Label label10;
        private Label passwordText2;
        private Label time2;
        private Label timeStart2;
        private Label timeEnd2;
        private TrackBar trackBar;
        private Label minValue;
        private Label maxValue;
    }
}
