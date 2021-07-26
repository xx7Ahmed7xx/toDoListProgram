using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace myToDoListProject
{
    public partial class Form1 : Form
    {
        public static string Frm2Title, Frm2Desc;
        public static DateTime Frm2DT;
        public static bool RefreshDB = true;
        //int countNotes = 0;
        List<(ListBox ListBoxToBeAdded, RadioButton RadioButtonToBeAdded)> _Notes = new List<(ListBox _myLB, RadioButton _myRB)>();
        List<(string Title, string Description, DateTime NoteDT, DateTime CreateDT)> _Values = new List<(string Title, string Description, DateTime NoteDT, DateTime CreateDT)>();
        public Form1()
        {
            // For Cross thread operation not valid
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        /* OLD not used anymore after disabling both MAXIMIZE AND MINIMIZE from form1.
        private const int GWL_STYLE = -16;
        private const int WS_CLIPSIBLINGS = 1 << 26;

        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowLong")]
        public static extern IntPtr SetWindowLongPtr32(HandleRef hWnd, int nIndex, HandleRef dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowLong")]
        public static extern IntPtr GetWindowLong32(HandleRef hWnd, int nIndex);

        protected override void OnLoad(EventArgs e)
        {
            this.Icon = Icon;
            int style = (int)((long)GetWindowLong32(new HandleRef(this, this.Handle), GWL_STYLE));
            SetWindowLongPtr32(new HandleRef(this, this.Handle), GWL_STYLE, new HandleRef(null, (IntPtr)(style & ~WS_CLIPSIBLINGS)));

            base.OnLoad(e);
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Add Button Click
        private void roundedButton21_Click(object sender, EventArgs e)
        {
            Form2 myF = new Form2() { StartPosition = this.StartPosition };
            myF.ShowDialog();
            AddNotes(myF.textBox1.Text, myF.textBox2.Text, myF.dateTimePicker1.Value, true);
            myF.Dispose();
            Cursor.Current = Cursors.Default;
        }

        // Adding Method
        private void AddNotes(string Title, string Description, DateTime NoteDT, bool Call, DateTime? CreateDT = null)
        {
            Cursor.Current = Cursors.WaitCursor;
            //MessageBox.Show("Add");
            DateTime NoteCreation = new DateTime();
            MultiLineListBox myLB = new MultiLineListBox() { Width = flowLayoutPanel1.Width - 25, Height = flowLayoutPanel1.Height / 4 };
            NoteCreation = DateTime.Now;
            myLB.Items.Add("Title: " + Title);
            myLB.Items.Add("Description: " + Description);
            myLB.Items.Add("Note Deadline: " + NoteDT);
            myLB.Items.Add("Create date: " + (CreateDT == null ? NoteCreation : CreateDT).ToString());
            if (Call && Title != "" && Description != "")
            {
                InsertSqlConnection(Title, Description, NoteDT, (DateTime)(CreateDT == null ? NoteCreation : CreateDT), 1); flowLayoutPanel1.Controls.Add(myLB);
                RadioButton myRB = new RadioButton() { Width = 15 };
                flowLayoutPanel1.Controls.Add(myRB);
                _Notes.Add((myLB, myRB));
                _Values.Add((Title, Description, NoteDT, (DateTime)(CreateDT == null ? NoteCreation : CreateDT)));
            }
            else if(Title != "" && Description != "")
            {
                flowLayoutPanel1.Controls.Add(myLB);
                RadioButton myRB = new RadioButton() { Width = 15 };
                flowLayoutPanel1.Controls.Add(myRB);
                _Notes.Add((myLB, myRB));
                _Values.Add((Title, Description, NoteDT, (DateTime)(CreateDT == null ? NoteCreation : CreateDT)));
            }
        }

        // Remove Button Click
        private void roundedButton22_Click(object sender, EventArgs e)
        {
            Thread _myThread = new Thread(MyFunc =>
            {
                int i = 0;
                foreach (var item in _Notes)
                {
                    if (item.RadioButtonToBeAdded.Checked)
                    {
                        //flowLayoutPanel1.Controls.Remove(item.ListBoxToBeAdded);
                        //flowLayoutPanel1.Controls.Remove(item.RadioButtonToBeAdded);
                        item.ListBoxToBeAdded.Dispose();
                        item.RadioButtonToBeAdded.Dispose();
                        //AlterNoteSqlConnection(item.ListBoxToBeAdded.Items[0].ToString().Substring(8), item.ListBoxToBeAdded.Items[1].ToString().Substring(14), Convert.ToDateTime(item.ListBoxToBeAdded.Items[2].ToString().Substring(13)), Convert.ToDateTime(item.ListBoxToBeAdded.Items[3].ToString().Substring(17)), 0);
                        AlterNoteSqlConnection(_Values[i].Title, _Values[i].Description, _Values[i].NoteDT, _Values[i].CreateDT, 0);
                    }
                    i++;
                }
            });
            _myThread.Start();
            //MessageBox.Show("Remove");
        }

        // DataBase Button CLick
        private void roundedButton23_Click(object sender, EventArgs e)
        {
            //Thread _myThread = new Thread(MyFunc => {
            CollectSqlConnection();
            //});
            //_myThread.Start();
            // System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();
            //MessageBox.Show("DB");
        }

        // Gathering Notes from DB
        private void CollectSqlConnection()
        {
            Cursor.Current = Cursors.WaitCursor;
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                SqlCommand command = new SqlCommand("Select * from Notes Order By NoteDate", connection);
                connection.Open();
                using (SqlDataReader dataRead = command.ExecuteReader())
                {
                    if (RefreshDB)
                    {
                        flowLayoutPanel1.Controls.Clear();
                        RefreshDB = false;
                        while (dataRead.Read())
                        {
                            if (Convert.ToInt16(dataRead["Showed"]) == 1)
                                AddNotes(dataRead["Title"].ToString(), dataRead["Description"].ToString(), Convert.ToDateTime(dataRead["NoteDate"]), false, Convert.ToDateTime(dataRead["CreateDate"]));
                        }
                    }

                    connection.Close();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        // Getting last ID form DB
        private int GetIDSqlConnection()
        {
            string connectionString = GetConnectionString();
            int a = -1;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                SqlCommand command = new SqlCommand("GetLastID", connection);
                connection.Open();
                using (SqlDataReader dataRead = command.ExecuteReader())
                {
                    while (dataRead.Read())
                    {
                        a = (int)dataRead[0];
                    }

                    connection.Close();
                }
            }
            return a;
        }

        // Inserting Into DB
        private void InsertSqlConnection(string s1, string s2, DateTime d1, DateTime d2, int Showedd)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                SqlCommand command = new SqlCommand("InsertValues @PM1 = \"" + s1 + "\", @PM2 = \"" + s2 + "\", @PM3 = \"" + d1 + "\", @PM4 = \"" + d2 + "\", @PM5 = " + Showedd, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Deleting From DB
        private void AlterNoteSqlConnection(string s1, string s2, DateTime d1, DateTime d2, int Showedd)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                SqlCommand command = new SqlCommand("HideValues @PM1 = \"" + s1 + "\", @PM2 = \"" + s2 + "\", @PM3 = \"" + d1 + "\", @PM4 = \"" + d2 + "\", @PM5 = " + Showedd, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Test for Connection SQL
        private static void OpenSqlConnection()
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                MessageBox.Show("State: " + connection.State);

                connection.Close();
            }
        }

        // Returns the sql string
        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            // PLEASE USE YOUR OWN SERVER AND DATABASE CONFIGURATION HERE.....
            return "Data Source={SERVER HERE};Initial Catalog={DB HERE};" + "Integrated Security=true;";
            // CHANGE ABOVE TO THE RIGHT SERVER NAME & DATABASE NAME !!
        }


        private void roundedButton21_MouseDown(object sender, MouseEventArgs e)
        {
            addBtn.BackgroundImage = Properties.Resources.PlusButtonShaded;
        }

        private void roundedButton21_MouseUp(object sender, MouseEventArgs e)
        {
            addBtn.BackgroundImage = Properties.Resources.PlusButton;
        }

        private void roundedButton22_MouseDown(object sender, MouseEventArgs e)
        {
            rmvBtn.BackgroundImage = Properties.Resources.MinusButtonShaded;
        }

        private void roundedButton22_MouseUp(object sender, MouseEventArgs e)
        {
            rmvBtn.BackgroundImage = Properties.Resources.MinusButton;
        }

        private void roundedButton23_MouseDown(object sender, MouseEventArgs e)
        {
            dtbBtn.BackgroundImage = Properties.Resources.DatabaseButton2Shaded;
        }

        private void roundedButton23_MouseUp(object sender, MouseEventArgs e)
        {
            dtbBtn.BackgroundImage = Properties.Resources.DatabaseButton2;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Close();
        }

        private void addBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip myTT = new ToolTip();
            myTT.SetToolTip(addBtn, "Add Note");
        }

        private void rmvBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip myTT = new ToolTip();
            myTT.SetToolTip(rmvBtn, "Hide/Remove Note");
        }

        private void dtbBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip myTT = new ToolTip();
            myTT.SetToolTip(dtbBtn, "Load from database");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_Notes.Count.ToString());
        }

    }
}
