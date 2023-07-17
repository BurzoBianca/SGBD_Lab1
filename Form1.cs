using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGBD_Lab1
{
    public partial class Form1 : Form
    {
        static string connectionString = "Data Source=LAPTOP-957DU9BE\\SQLEXPRESS;Initial Catalog=Konditorei;" + "Integrated Security=true";
        SqlConnection connection = new SqlConnection(connectionString);
        private int param;

        private int get() { return param; }
        private void set(int p) { param = p; }

        public Form1()
        {
            InitializeComponent();

        }

        private void BindGridShops()
        {
            string connectionString = "Data Source=LAPTOP-957DU9BE\\SQLEXPRESS;Initial Catalog=Konditorei;" + "Integrated Security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (connection)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Shops", connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridViewShops.DataSource = dt;
                            }
                        }
                    }
                }
            }
        }


        private void BindGridAngestellte()
        {
            string connectionString = "Data Source=LAPTOP-957DU9BE\\SQLEXPRESS;Initial Catalog=Konditorei;" + "Integrated Security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (connection)
                {
                    int shopID = (int)dataGridViewShops.Rows[get()].Cells[2].Value;
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Angestellte WHERE ShopID = @shopID", connection))
                    {
                        cmd.Parameters.AddWithValue("@shopID", shopID);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridViewAngestellte.DataSource = dt;
                            }
                        }
                    }
                }
            }
        }

        private void connButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-957DU9BE\\SQLEXPRESS;Initial Catalog=Konditorei;" + "Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    BindGridShops();

                    MessageBox.Show("yay");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }


        }


        private void dataGridViewShops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            set(e.RowIndex);
            dataGridViewAngestellte_CellClick(sender, e);
            //connectShopsAngestellte();

        }

        private void connectShopsAngestellte()
        {
            string connectionString = "Data Source=LAPTOP-957DU9BE\\SQLEXPRESS;Initial Catalog=Konditorei;" + "Integrated Security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlConnection connect = new SqlConnection(connectionString);


                DataSet shopAngestellte = new DataSet();

                SqlDataAdapter shopAdapter = new SqlDataAdapter("SELECT * FROM Shops", conn);
                SqlDataAdapter angestellteAdapter = new SqlDataAdapter("SELECT * FROM Angestellte", connect);


                shopAdapter.Fill(shopAngestellte, "Shops");
                angestellteAdapter.Fill(shopAngestellte, "Angestellte");

                DataRelation relation = shopAngestellte.Relations.Add("Shops_Angestellte",
                  shopAngestellte.Tables["Shops"].Columns["ID"],
                  shopAngestellte.Tables["Angestellte"].Columns["ShopID"]);

                BindingSource bsShops = new BindingSource();
                bsShops.DataSource = shopAngestellte;
                bsShops.DataMember = "Shops";

                BindingSource bsAngestellte = new BindingSource();
                bsAngestellte.DataSource = bsShops;
                bsAngestellte.DataMember = "Shops_Angestellte";

                dataGridViewShops.DataSource = bsShops;
                dataGridViewAngestellte.DataSource = bsAngestellte;
            }
        }

        private void dataGridViewAngestellte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindGridAngestellte();
            //exception handler for not binding the second pressed cell with the first one
            if (txtName.DataBindings.Count > 0)
                txtName.DataBindings.RemoveAt(0);

            //binds cell to text box (zeigt Name)
            Binding b1 = new Binding("Text", dataGridViewAngestellte[0, e.RowIndex], "Value", false);
            txtName.DataBindings.Add(b1);


            if (txtVorname.DataBindings.Count > 0)
                txtVorname.DataBindings.RemoveAt(0);

            //binds cell to text box (zeigt Vorname)
            Binding b2 = new Binding("Text", dataGridViewAngestellte[1, e.RowIndex], "Value", false);
            txtVorname.DataBindings.Add(b2);


            if (txtCNP.DataBindings.Count > 0)
                txtCNP.DataBindings.RemoveAt(0);

            //binds cell to text box (zeigt CNP)
            Binding b3 = new Binding("Text", dataGridViewAngestellte[2, e.RowIndex], "Value", false);
            txtCNP.DataBindings.Add(b3);

            if (txtMatNr.DataBindings.Count > 0)
                txtMatNr.DataBindings.RemoveAt(0);

            //binds cell to text box (zeigt MatNr)
            Binding b4 = new Binding("Text", dataGridViewAngestellte[3, e.RowIndex], "Value", false);
            txtMatNr.DataBindings.Add(b4);

            if (txtLohn.DataBindings.Count > 0)
                txtLohn.DataBindings.RemoveAt(0);

            //binds cell to text box (zeigt Lohn)
            Binding b5 = new Binding("Text", dataGridViewAngestellte[4, e.RowIndex], "Value", false);
            txtLohn.DataBindings.Add(b5);

        }

        private void GetData()
        {
            string sql = "select * from Angestellte ";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewAngestellte.DataSource = dt;
        }
        void InitData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (connection)
                {
                    int shopID = (int)dataGridViewShops.Rows[get()].Cells[2].Value;
                    using (SqlCommand cmd = new SqlCommand("select * from Angestellte where ShopID = @shopID", connection))
                    {
                        cmd.Parameters.AddWithValue("@ShopID", shopID);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridViewAngestellte.DataSource = dt;
                            }
                        }
                    }

                }
            }
        } 

        private void frmContact_Load(object sender, EventArgs e)
        {
            InitData();
        }
        void Clear()
        {
            txtCNP.Text = string.Empty;
            txtName.Text = string.Empty;
            txtMatNr.Text = string.Empty;
            txtLohn.Text = string.Empty;
            txtVorname.Text = string.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (String.IsNullOrEmpty(txtLohn.Text) && String.IsNullOrEmpty(txtMatNr.Text) && String.IsNullOrEmpty(txtName.Text) && String.IsNullOrEmpty(txtVorname.Text))
                    {
                        MessageBox.Show("Please fill all the fields in");
                    }
                    else
                    {
                        int shopID = (int)dataGridViewShops.Rows[get()].Cells[2].Value;
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        bool matNrIsUnique = CheckUniqueValueInsert(txtMatNr.Text);
                        if (matNrIsUnique == false)
                        {
                            MessageBox.Show("MatNr must be unique");
                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("insert into angestellte(MatNr, Lohn, ShopID, Name, Vorname, CNP) values(@MatNr, @Lohn, @ShopID, @Name, @Vorname, @CNP)", connection))
                            {
                                cmd.Parameters.AddWithValue("ShopID", shopID);
                                cmd.Parameters.AddWithValue("@MatNr", txtMatNr.Text);
                                cmd.Parameters.AddWithValue("@Lohn", txtLohn.Text);
                                cmd.Parameters.AddWithValue("@Vorname", txtVorname.Text);
                                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                                cmd.Parameters.AddWithValue("@CNP", txtCNP.Text);
                                cmd.ExecuteNonQuery();
                                InitData();
                                Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewAngestellte.Rows[dataGridViewAngestellte.CurrentRow.Index] as DataGridViewRow;
                if (row != null)
                {
                    if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            int param = Int32.Parse(txtMatNr.Text);
                            if (connection.State == ConnectionState.Closed)
                                connection.Open();
                            using (SqlCommand cmd = new SqlCommand("delete from Angestellte where MatNr = @p", connection))
                            {
                                cmd.Parameters.AddWithValue("@p", param);
                                cmd.ExecuteNonQuery();
                                InitData();
                                Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    int shopID = (int)dataGridViewShops.Rows[get()].Cells[2].Value;
                    int matNr = Int32.Parse(txtMatNr.Text);
                    bool matNrIsUnique = CheckUniqueValueUpdate(txtMatNr.Text);
                    if (matNrIsUnique == false)
                    {
                        MessageBox.Show("MatNr must be unique");
                    }
                    else
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        using (SqlCommand cmd = new SqlCommand("update Angestellte set CNP = @CNP, Lohn = @Lohn, Vorname = @Vorname, Name = @Name where ShopID = @shopID and MatNr = @matNr", connection))
                        {
                            DataGridViewRow row = dataGridViewAngestellte.Rows[dataGridViewAngestellte.CurrentRow.Index] as DataGridViewRow;
                            if (row != null)
                            {
                                cmd.Parameters.AddWithValue("@shopID", shopID);
                                cmd.Parameters.AddWithValue("@matNr", matNr);
                                cmd.Parameters.AddWithValue("@Lohn", txtLohn.Text);
                                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                                cmd.Parameters.AddWithValue("@Vorname", txtVorname.Text);
                                cmd.Parameters.AddWithValue("@CNP", txtCNP.Text);
                                cmd.ExecuteNonQuery();
                                InitData();
                                Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool CheckUniqueValueUpdate(string matNr)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from Angestellte where MatNr = @MatNr ", connection))
                {
                    cmd.Parameters.AddWithValue("@MatNr", matNr);
                    cmd.ExecuteNonQuery();

                    var result = Convert.ToUInt16(cmd.ExecuteScalar());
                    connection.Close();

                    if (result == 1)
                        return true;
                    else
                        return false;
                }

            }
        }public bool CheckUniqueValueInsert(string matNr)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from Angestellte where MatNr = @MatNr ", connection))
                {
                    cmd.Parameters.AddWithValue("@MatNr", matNr);
                    cmd.ExecuteNonQuery();

                    var result = Convert.ToUInt16(cmd.ExecuteScalar());
                    connection.Close();

                    if (result == 0)
                        return true;
                    else
                        return false;
                }

            }
        }
    }
}
