using OpenCvSharp.Extensions;
using OpenCvSharp;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Personelkayit
{
    public partial class gorevtkpprog : Form
    {
        private VideoCapture videoCapture;
        private CascadeClassifier faceCascade;
        private Mat frame;
        private readonly string connectionString = "Data Source=AVCU\\SQLEXPRESS;Initial Catalog=LoginVeri;Integrated Security=TRUE";
        private SqlConnection connection;
        private Timer timer;

        public gorevtkpprog()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            InitializeCamera();
        }

        private void InitializeCamera()
        {
            videoCapture = new VideoCapture(0); // Varsayılan kamerayı başlat
            faceCascade = new CascadeClassifier("haarcascade_frontalface_default.xml"); // Yüz algılama modeli
            frame = new Mat();

            timer = new Timer();
            timer.Interval = 100; // 100 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            videoCapture?.Release();
            base.OnFormClosing(e);
        }

        private void gorevtkpprog_Load(object sender, EventArgs e)
        {
            try
            {
                this.görevKTableAdapter2.Fill(this.loginVeriDataSet9.görevK);
                this.görevKTableAdapter1.Fill(this.loginVeriDataSet8.görevK);
                this.görevKTableAdapter.Fill(this.loginVeriDataSet7.görevK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yükleme hatası: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string personelId = txtıd.Text.Trim();
            string alınacakizin = txtizin.Text.Trim();
            string mesaiSaatleri = txtmsaat.Text.Trim();
            string of = txtof.Text.Trim();

            if (string.IsNullOrEmpty(personelId) || string.IsNullOrEmpty(alınacakizin) || string.IsNullOrEmpty(mesaiSaatleri) || string.IsNullOrEmpty(of))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM görevK WHERE PersonelID = @PersonelID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@PersonelID", personelId);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Girilen PersonelID'ye ait bir kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string updateQuery = @"
                        UPDATE görevK 
                        SET Alınacakizin = @Alınacakizin, 
                            MesaiSaatleri = @MesaiSaatleri,
                            Of = @Of
                        WHERE PersonelID = @PersonelID";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@PersonelID", personelId);
                        updateCommand.Parameters.AddWithValue("@Alınacakizin", alınacakizin);
                        updateCommand.Parameters.AddWithValue("@MesaiSaatleri", mesaiSaatleri);
                        updateCommand.Parameters.AddWithValue("@Of", of);

                        updateCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Bilgiler başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Ad = dataGridView1.SelectedRows[0].Cells["AdDataGridViewTextBoxColumn"].Value.ToString();

                var result = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        string silSorgusu = "DELETE FROM görevK WHERE Ad = @Ad";
                        SqlCommand silKomut = new SqlCommand(silSorgusu, connection);
                        silKomut.Parameters.AddWithValue("@Ad", Ad);

                        int affectedRows = silKomut.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Kullanıcı başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bulunamadı veya silinemedi.");
                        }

                        this.görevKTableAdapter.Fill(this.loginVeriDataSet7.görevK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir kullanıcıyı seçin.");
            }
        }
    }
}
