using Form1;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Personelkayit
{
    public partial class VeriT : Form
    {
        // SQL bağlantı dizesi
        static string con = "Data Source=AVCU\\SQLEXPRESS;Initial Catalog=LoginVeri;Integrated Security=TRUE";
        private SqlConnection connection = new SqlConnection(con); // Global bağlantı nesnesi

        public VeriT()
        {
            InitializeComponent();
        }

        private void VeriT_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'loginVeriDataSet4.PersonelVt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelVtTableAdapter3.Fill(this.loginVeriDataSet4.PersonelVt);
            // TODO: Bu kod satırı 'loginVeriDataSet3.PersonelVt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelVtTableAdapter2.Fill(this.loginVeriDataSet3.PersonelVt);
            // TODO: Bu kod satırı 'loginVeriDataSet2.PersonelVt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelVtTableAdapter1.Fill(this.loginVeriDataSet2.PersonelVt);
            // TODO: Bu kod satırı 'loginVeriDataSet.PersonelVt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelVtTableAdapter.Fill(this.loginVeriDataSet.PersonelVt);
            try
            {
                // 'PersonelVt' tablosunu doldur
                this.personelVtTableAdapter.Fill(this.loginVeriDataSet.PersonelVt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tablo yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0) // Seçili satır var mı kontrolü
            {
                string Ad = dataGridView1.SelectedRows[0].Cells["AdDataGridViewTextBoxColumn"].Value.ToString();

                // Silme işlemi için onay al
                var result = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();

                        // SQL DELETE sorgusu
                        string silSorgusu = "DELETE FROM PersonelVt WHERE Ad = @Ad";
                        SqlCommand silKomut = new SqlCommand(silSorgusu, connection);
                        silKomut.Parameters.AddWithValue("@Ad", Ad);

                        int affectedRows = silKomut.ExecuteNonQuery(); // Etkilenen satır sayısını al
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Kullanıcı başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bulunamadı veya silinemedi.");
                        }

                        // DataGridView'i güncelle
                        this.personelVtTableAdapter.Fill(this.loginVeriDataSet.PersonelVt);
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

  

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
