namespace memo
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ID1 = new DataGridViewTextBoxColumn();
            WorkName1 = new DataGridViewTextBoxColumn();
            WorkTime1 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            ID2 = new DataGridViewTextBoxColumn();
            WorkName2 = new DataGridViewTextBoxColumn();
            WorkTime2 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Once";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(6, 273);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 114);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(457, 36);
            button1.Name = "button1";
            button1.Size = new Size(143, 53);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID1, WorkName1, WorkTime1 });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(772, 267);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // ID1
            // 
            ID1.DataPropertyName = "ID1";
            ID1.HeaderText = "ID";
            ID1.MinimumWidth = 6;
            ID1.Name = "ID1";
            ID1.Width = 125;
            // 
            // WorkName1
            // 
            WorkName1.DataPropertyName = "WorkName1";
            WorkName1.HeaderText = "WorkName";
            WorkName1.MinimumWidth = 6;
            WorkName1.Name = "WorkName1";
            WorkName1.Width = 300;
            // 
            // WorkTime1
            // 
            WorkTime1.DataPropertyName = "WorkTime1";
            WorkTime1.HeaderText = "WorkTime";
            WorkTime1.MinimumWidth = 6;
            WorkTime1.Name = "WorkTime1";
            WorkTime1.Width = 300;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Daily";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(669, 110);
            panel2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(444, 34);
            button2.Name = "button2";
            button2.Size = new Size(129, 50);
            button2.TabIndex = 0;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ID2, WorkName2, WorkTime2 });
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(762, 271);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // ID2
            // 
            ID2.DataPropertyName = "ID2";
            ID2.HeaderText = "ID";
            ID2.MinimumWidth = 6;
            ID2.Name = "ID2";
            ID2.Width = 125;
            // 
            // WorkName2
            // 
            WorkName2.DataPropertyName = "WorkName2";
            WorkName2.HeaderText = "WorkName";
            WorkName2.MinimumWidth = 6;
            WorkName2.Name = "WorkName2";
            WorkName2.Width = 300;
            // 
            // WorkTime2
            // 
            WorkTime2.DataPropertyName = "WorkTime2";
            WorkTime2.HeaderText = "WorkTime";
            WorkTime2.MinimumWidth = 6;
            WorkTime2.Name = "WorkTime2";
            WorkTime2.Width = 300;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            Resize += Form1_Resize;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn ID1;
        private DataGridViewTextBoxColumn WorkName1;
        private DataGridViewTextBoxColumn WorkTime1;
        private DataGridViewTextBoxColumn ID2;
        private DataGridViewTextBoxColumn WorkName2;
        private DataGridViewTextBoxColumn WorkTime2;
    }
}
