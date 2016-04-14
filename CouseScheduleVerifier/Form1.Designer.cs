namespace CouseScheduleVerifier
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.courseTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.time = new System.Windows.Forms.ComboBox();
            this.instructor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // courseTitle
            // 
            this.courseTitle.Location = new System.Drawing.Point(64, 49);
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.Size = new System.Drawing.Size(121, 20);
            this.courseTitle.TabIndex = 1;
            this.courseTitle.TextChanged += new System.EventHandler(this.courseTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instructor";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(269, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(327, 329);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // time
            // 
            this.time.FormattingEnabled = true;
            this.time.Location = new System.Drawing.Point(64, 362);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(121, 21);
            this.time.TabIndex = 4;
            this.time.SelectedIndexChanged += new System.EventHandler(this.time_SelectedIndexChanged);
            // 
            // instructor
            // 
            this.instructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructor.FormattingEnabled = true;
            this.instructor.Location = new System.Drawing.Point(64, 124);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(121, 21);
            this.instructor.TabIndex = 5;
            this.instructor.SelectedIndexChanged += new System.EventHandler(this.instructor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // room
            // 
            this.room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.room.FormattingEnabled = true;
            this.room.Location = new System.Drawing.Point(64, 201);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(121, 21);
            this.room.TabIndex = 7;
            this.room.SelectedIndexChanged += new System.EventHandler(this.room_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Day";
            // 
            // day
            // 
            this.day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day.FormattingEnabled = true;
            this.day.Location = new System.Drawing.Point(64, 285);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(121, 21);
            this.day.TabIndex = 9;
            this.day.SelectedIndexChanged += new System.EventHandler(this.day_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Time";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(64, 432);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 11;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(491, 432);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 12;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Classes";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(410, 432);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 14;
            this.importButton.Text = "Import...";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 527);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.room);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.instructor);
            this.Controls.Add(this.time);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseTitle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Course Schedule Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox time;
        private System.Windows.Forms.ComboBox instructor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox room;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox day;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button importButton;
    }
}

