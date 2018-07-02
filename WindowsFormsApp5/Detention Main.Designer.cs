namespace WindowsFormsApp5
{
    partial class MainDetention
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unservedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roboCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overRideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearbookDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dayS = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 276);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 399);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "John B. Doe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unserved:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Detentions:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Custom_F:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tardy To School",
            "Hallway Sweep",
            "Classroom Disrubtion",
            "Dress Code",
            "Profanity",
            "Cellphone",
            "Defience",
            "Eating In Class",
            "Because I Feel Like It"});
            this.comboBox1.Location = new System.Drawing.Point(376, 398);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit Detention";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.customFieldToolStripMenuItem,
            this.studentDatabaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "Menu Bar";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unservedToolStripMenuItem,
            this.roboCallToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // unservedToolStripMenuItem
            // 
            this.unservedToolStripMenuItem.Name = "unservedToolStripMenuItem";
            this.unservedToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.unservedToolStripMenuItem.Text = "Unserved";
            // 
            // roboCallToolStripMenuItem
            // 
            this.roboCallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.nonAdminToolStripMenuItem});
            this.roboCallToolStripMenuItem.Name = "roboCallToolStripMenuItem";
            this.roboCallToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.roboCallToolStripMenuItem.Text = "Robo Call";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // nonAdminToolStripMenuItem
            // 
            this.nonAdminToolStripMenuItem.Name = "nonAdminToolStripMenuItem";
            this.nonAdminToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.nonAdminToolStripMenuItem.Text = "Non-Admin";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.xmlToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.xmlToolStripMenuItem.Text = "Xml";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overRideToolStripMenuItem,
            this.appendToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // overRideToolStripMenuItem
            // 
            this.overRideToolStripMenuItem.Name = "overRideToolStripMenuItem";
            this.overRideToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.overRideToolStripMenuItem.Text = "OverRide";
            // 
            // appendToolStripMenuItem
            // 
            this.appendToolStripMenuItem.Name = "appendToolStripMenuItem";
            this.appendToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.appendToolStripMenuItem.Text = "Append";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverRequestToolStripMenuItem,
            this.localRequestToolStripMenuItem});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // serverRequestToolStripMenuItem
            // 
            this.serverRequestToolStripMenuItem.Name = "serverRequestToolStripMenuItem";
            this.serverRequestToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.serverRequestToolStripMenuItem.Text = "Server Request";
            // 
            // localRequestToolStripMenuItem
            // 
            this.localRequestToolStripMenuItem.Name = "localRequestToolStripMenuItem";
            this.localRequestToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.localRequestToolStripMenuItem.Text = "Local Request";
            // 
            // customFieldToolStripMenuItem
            // 
            this.customFieldToolStripMenuItem.Name = "customFieldToolStripMenuItem";
            this.customFieldToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.customFieldToolStripMenuItem.Text = "Custom Field";
            // 
            // studentDatabaseToolStripMenuItem
            // 
            this.studentDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatePicturesToolStripMenuItem,
            this.updateStudentListToolStripMenuItem});
            this.studentDatabaseToolStripMenuItem.Name = "studentDatabaseToolStripMenuItem";
            this.studentDatabaseToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.studentDatabaseToolStripMenuItem.Text = "Student Database";
            // 
            // updatePicturesToolStripMenuItem
            // 
            this.updatePicturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.allToolStripMenuItem});
            this.updatePicturesToolStripMenuItem.Name = "updatePicturesToolStripMenuItem";
            this.updatePicturesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.updatePicturesToolStripMenuItem.Text = "Update Pictures";
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.singleToolStripMenuItem.Text = "Single";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // updateStudentListToolStripMenuItem
            // 
            this.updateStudentListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearbookDatabaseToolStripMenuItem,
            this.schoolDatabaseToolStripMenuItem,
            this.singleToolStripMenuItem1});
            this.updateStudentListToolStripMenuItem.Name = "updateStudentListToolStripMenuItem";
            this.updateStudentListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.updateStudentListToolStripMenuItem.Text = "Update Student List";
            // 
            // yearbookDatabaseToolStripMenuItem
            // 
            this.yearbookDatabaseToolStripMenuItem.Name = "yearbookDatabaseToolStripMenuItem";
            this.yearbookDatabaseToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.yearbookDatabaseToolStripMenuItem.Text = "Yearbook Database";
            // 
            // schoolDatabaseToolStripMenuItem
            // 
            this.schoolDatabaseToolStripMenuItem.Name = "schoolDatabaseToolStripMenuItem";
            this.schoolDatabaseToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.schoolDatabaseToolStripMenuItem.Text = "School Database";
            // 
            // singleToolStripMenuItem1
            // 
            this.singleToolStripMenuItem1.Name = "singleToolStripMenuItem1";
            this.singleToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.singleToolStripMenuItem1.Text = "Single";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(20, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Student ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 370);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Reason";
            // 
            // dayS
            // 
            this.dayS.Location = new System.Drawing.Point(630, 350);
            this.dayS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayS.Name = "dayS";
            this.dayS.Size = new System.Drawing.Size(39, 20);
            this.dayS.TabIndex = 17;
            this.dayS.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // MainDetention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 484);
            this.Controls.Add(this.dayS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainDetention";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unservedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roboCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overRideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePicturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearbookDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonAdminToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown dayS;
    }
}

