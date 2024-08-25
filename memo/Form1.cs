using System.Data;
using System.Drawing.Text;
using memo.Class;
using memo.DAL;



namespace memo
{
    public partial class Form1 : Form
    {
        private System.Threading.Timer timer;
        
        private List<MemoW> memoList = new List<MemoW>();
        

        private DateTimePicker datetime = new DateTimePicker();
        private DateTimePicker timePicker = new DateTimePicker();
        private Rectangle rectPanel;

        DataTable dtgv1_Source;
        DataTable dtgv2_Source;

        MemoOnceBLL mmOnce = new MemoOnceBLL();
        MemoDailyBLL mmDaily = new MemoDailyBLL();



        public Form1()
        {
            InitializeComponent();
            autoSize();

            dataGridView1.Controls.Add(datetime);
            datetime.Visible = false;
            datetime.Format = DateTimePickerFormat.Custom;
            datetime.CustomFormat = "M/d/yyyy h:mm tt";
            datetime.ShowUpDown = true;
            datetime.TextChanged += new EventHandler(datetime_textchanged);

            dataGridView2.Controls.Add(timePicker);
            timePicker.Visible = false;
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "h:mm tt";
            timePicker.ShowUpDown = true;
            timePicker.TextChanged += new EventHandler(timePicker_textchanged);
            

        }

        public void TerminateAll()
        {
            this.timer = new System.Threading.Timer((x) => { });
            memoList.Clear();
        }

        public void StartAll()
        {
            foreach (DataRow row in dtgv1_Source.Rows)
            {
                memoList.Add(new MemoW(row[1].ToString(), DateTime.Parse(row[2].ToString())));
            }

            foreach (DataRow row in dtgv2_Source.Rows)
            {
                memoList.Add(new MemoW(row[1].ToString(), DateTime.Parse(row[2].ToString())));
            }

            foreach (MemoW memo in memoList)
            {
                RunAtTime(memo.memoName, memo.memoTime);
            }
        }
        public void RunAtTime(string work, DateTime alertTime)
        {
            
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = alertTime - now;
            
            if (timeSpan < TimeSpan.Zero)
            {
                //MessageBox.Show("Time Passed");
            }
            else
            {
                this.timer = new System.Threading.Timer((x) => { MessageBox.Show("OK " + work + " at " + alertTime.ToString(), "Alarm!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); }, null, timeSpan, Timeout.InfiniteTimeSpan);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //memoList.Add(new MemoW("wake", DateTime.Now.AddSeconds(20)));
            //foreach (MemoW memo in memoList)
            //{
            //    RunAtTime(memo.memoName, memo.memoTime);
            //}
            
        }

        private void autoSize()
        {
            int tabWidth = this.Width * 95 / 100;
            int tabHeight = this.Height * 9 / 10;
            int tabPageWidth = tabWidth;
            int tabPageHeight = tabHeight * 5 / 10;
            int gridWidth = tabPageWidth - 10;
            int gridHeight = tabPageHeight;
            int idWidth = 50;
            int workNameWidth = gridWidth * 3 / 10;
            int workTimeWidth = gridWidth - workNameWidth - idWidth - 55;


            this.tabControl1.Size = new Size(tabWidth, tabHeight);
            this.tabPage1.Size = new Size(tabPageWidth, tabPageHeight);
            this.tabPage2.Size = new Size(tabPageWidth, tabPageHeight);
            this.dataGridView1.Size = new Size(gridWidth, gridHeight);
            this.dataGridView2.Size = new Size(gridWidth, gridHeight);

            this.ID1.Width = idWidth;
            this.WorkName1.Width = workNameWidth;
            this.WorkTime1.Width = workTimeWidth;
            this.WorkName1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            this.WorkTime1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ID2.Width = idWidth;
            this.WorkName2.Width = workNameWidth;
            this.WorkTime2.Width = workTimeWidth;

            this.panel1.Width = this.dataGridView1.Width;
            this.panel1.Location = new Point(this.dataGridView1.Location.X, this.tabPage1.Height - this.panel1.Height - 10);
            this.panel2.Width = this.dataGridView2.Width;
            this.panel2.Location = new Point(this.dataGridView2.Location.X, this.tabPage2.Height - this.panel2.Height - 10);

            this.button1.Width = this.panel1.Width * 4 / 10;
            this.button1.Height = this.panel1.Height * 5 / 10;
            this.button1.Location = new Point(this.panel1.Width / 2 - this.button1.Width / 2, this.panel1.Height / 2 - this.panel1.Height / 2);

            this.button2.Width = this.panel2.Width * 4 / 10;
            this.button2.Height = this.panel2.Height * 5 / 10;
            this.button2.Location = new Point(this.panel2.Width / 2 - this.button2.Width / 2, this.panel2.Height / 2 - this.panel2.Height / 2);
            this.MinimumSize = new Size(700, 500);
            this.MaximumSize = new Size(1000, 700);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            autoSize();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mmOnce.createTable();
            mmDaily.createTable();
            datagrid1_DataBind();
            datagrid2_DataBind();
            autoSize();

            StartAll();
        }

        private void datetime_textchanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = datetime.Text.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "WorkTime1")
            {
                rectPanel = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                datetime.Size = new Size(rectPanel.Width, rectPanel.Height);
                datetime.Location = new Point(rectPanel.X, rectPanel.Y);
                datetime.Visible = true;

            }
        }

        private void timePicker_textchanged(object sender, EventArgs e)
        {

            if (DateTime.Now > timePicker.Value)
            {
                dataGridView2.CurrentCell.Value = timePicker.Value.AddDays(1).ToString();
                return;
            }
            dataGridView2.CurrentCell.Value = timePicker.Text.ToString();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "WorkTime2")
            {
                rectPanel = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                timePicker.Size = new Size(rectPanel.Width, rectPanel.Height);
                timePicker.Location = new Point(rectPanel.X, rectPanel.Y);
                timePicker.Visible = true;
            }
        }

        private void datagrid1_DataBind()
        {
            dtgv1_Source = mmOnce.getDataDAL();
            dataGridView1.DataSource = dtgv1_Source;
            

        }
        private void datagrid2_DataBind() 
        {

            dtgv2_Source = mmDaily.getDataDAL();
            foreach (DataRow row in dtgv2_Source.Rows)
            {
                DateTime dt = DateTime.Parse(row["WorkTime2"].ToString());
                if (DateTime.Now > dt)
                {
                    while(DateTime.Now > dt)
                    {
                        dt = dt.AddDays(1);
                    }
                    row["WorkTime2"] = dt.ToString();
                }
                
            }
            dataGridView2.DataSource = dtgv2_Source;
            mmDaily.updateTable(dtgv2_Source);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable Changes = ((DataTable)dataGridView2.DataSource).GetChanges();
            if (Changes != null)
            {
                mmDaily.updateTable(dtgv2_Source);
                datagrid2_DataBind();
            }
            TerminateAll();
            StartAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable Changes = ((DataTable)dataGridView1.DataSource).GetChanges();
            if (Changes != null) 
            {
                mmOnce.updateTable(dtgv1_Source);
                datagrid1_DataBind();
            }
            TerminateAll();
            StartAll();
        }
    }
}
