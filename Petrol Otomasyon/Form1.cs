using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Petrol_Otomasyon
{
    public partial class dgvSubeler : Form
    {
        public dgvSubeler()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=DESKTOP-8FACNE8;Database=PetrolOtomasyon;Trusted_Connection=True;";
        private SqlConnection connection;

        private void dgvSubeler_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadSubeler();
            LoadReservations();
            LoadPersonel();
            LoadSalesData();
        }

        private void LoadSubeler()
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Subeler";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                lblBilgi.Text = "Şubeler başarıyla yüklendi.";
            }
            catch (Exception ex)
            {
                lblBilgi.Text = "Hata: " + ex.Message;
            }
        }

        private void LoadReservations()
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Rezervasyonlar";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView2.DataSource = table;
                }
                lblBilgi.Text = "Rezervasyonlar başarıyla yüklendi.";
            }
            catch (Exception ex)
            {
                lblBilgi.Text = "Hata: " + ex.Message;
            }
        }

        private void LoadPersonel()
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Personel";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewpersonel.DataSource = table;
                }
                lblBilgi.Text = "Personel tablosu başarıyla yüklendi.";
            }
            catch (Exception ex)
            {
                lblBilgi.Text = "Hata: " + ex.Message;
            }
        }

        // Satış Verilerini Yükleme
        private void LoadSalesData()
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Satislar";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                }
                lblBilgi.Text = "Satış verileri başarıyla yüklendi.";
            }
            catch (Exception ex)
            {
                lblBilgi.Text = "Hata: " + ex.Message;
            }
        }


        private void ClearForm()
        {
            txtSubeAdi.Clear();
            txtSehir.Clear();
            txtFirmaID.Clear();
            txtSefID.Clear();
            lblBilgi.Text = "Form temizlendi.";
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Subeler (SubeAdi, Sehir, FirmaID, SefID) VALUES (@SubeAdi, @Sehir, @FirmaID, @SefID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SubeAdi", txtSubeAdi.Text);
                    command.Parameters.AddWithValue("@Sehir", txtSehir.Text);
                    command.Parameters.AddWithValue("@FirmaID", txtFirmaID.Text);
                    command.Parameters.AddWithValue("@SefID", txtSefID.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                lblBilgi.Text = "Yeni şube başarıyla eklendi.";
                ClearForm();
                LoadSubeler();
            }
            catch (Exception ex)
            {
                lblBilgi.Text = "Hata: " + ex.Message;
            }
        }

       
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int subeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    using (connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Subeler WHERE SubeID = @SubeID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SubeID", subeID);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    lblBilgi.Text = "Şube başarıyla silindi.";
                    LoadSubeler();
                }
                else
                {
                    lblBilgi.Text = "Lütfen silinecek bir satır seçin.";
                }
            }
            catch (Exception ex)
            {
                lblBilgi.Text = "Hata: " + ex.Message;
            }
        }

      
        private void btnpompa_Click(object sender, EventArgs e)
        {
            PompaciArayüzü pompaciArayüzü = new PompaciArayüzü();
            pompaciArayüzü.Show();
        }

        private void buttongirisyap_Click(object sender, EventArgs e)
        {
            giriş giriş = new giriş();
            giriş.Show();
        }
    }
}
        