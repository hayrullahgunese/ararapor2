using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol_Otomasyon
{
    public partial class giriş : Form
    {
        private string connectionString = "Server=DESKTOP-8FACNE8;Database=PetrolOtomasyon;Trusted_Connection=True;";
        private SqlConnection connection;

        public giriş()
        {
            InitializeComponent();
        }

        private void giriş_Load(object sender, EventArgs e)
        {
        }

        private void labelpozisyon_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPosition = comboBox1.SelectedItem.ToString();
            MessageBox.Show($"Seçilen pozisyon: {selectedPosition}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adSoyad = textBox1.Text;
            string pozisyon = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(adSoyad))
            {
                MessageBox.Show("Lütfen adınızı ve soyadınızı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(pozisyon))
            {
                MessageBox.Show("Lütfen bir pozisyon seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT COUNT(*) FROM Personel WHERE AdSoyad = @AdSoyad AND Pozisyon = @Pozisyon";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdSoyad", adSoyad);
                    command.Parameters.AddWithValue("@Pozisyon", pozisyon);

                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show($"Hoş geldiniz, {pozisyon} {adSoyad}!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (pozisyon == "Pompacı")
                        {
                            PompaciArayüzü pompaciArayuzu = new PompaciArayüzü();
                            pompaciArayuzu.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ad Soyad veya Pozisyon hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
