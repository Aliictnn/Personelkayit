using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Form1
{
    public partial class Personel : Form
    {
        private VideoCapture videoCapture;
        private CascadeClassifier faceCascade;
        private Mat frame;
        private readonly string connectionString = "Data Source=AVCU\\SQLEXPRESS;Initial Catalog=LoginVeri;Integrated Security=TRUE";

        public Personel()
        {
            InitializeComponent();
            InitializeCamera();
        }

        private void InitializeCamera()
        {
            try
            {
                videoCapture = new VideoCapture(0);
                string cascadePath = Path.Combine(Application.StartupPath, "haarcascade_frontalface_default.xml");
                if (!File.Exists(cascadePath))
                    throw new FileNotFoundException($"Yüz tanıma dosyası bulunamadı: {cascadePath}");

                faceCascade = new CascadeClassifier(cascadePath);
                Timer timer = new Timer { Interval = 100 };
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kamera başlatılamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                frame = new Mat();
                if (!videoCapture.Read(frame) || frame.Empty()) return;

                Cv2.Flip(frame, frame, FlipMode.Y);
                var grayFrame = new Mat();
                Cv2.CvtColor(frame, grayFrame, ColorConversionCodes.BGR2GRAY);
                var faces = faceCascade.DetectMultiScale(grayFrame, 1.1, 4, HaarDetectionTypes.ScaleImage);

                var processedFrame = frame.Clone();
                foreach (var face in faces)
                    Cv2.Rectangle(processedFrame, face, Scalar.Red, 2);

                pictureBox1.Image = BitmapConverter.ToBitmap(processedFrame);
                pictureBox3.Image = BitmapConverter.ToBitmap(frame);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kamera işlemi sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            string Ad = txtad.Text.Trim();
            string Soyad = txtsoyad.Text.Trim();
            string Departman = txtdepartman.Text.Trim();
            string görev = txtgörev.Text.Trim();

            if (string.IsNullOrEmpty(Ad) || string.IsNullOrEmpty(Soyad) || string.IsNullOrEmpty(Departman) || string.IsNullOrEmpty(görev))
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekmektedir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO personelkayit (Ad, Soyad, Departman, Görev) VALUES (@Ad, @Soyad, @Departman, @Görev)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", Ad);
                        command.Parameters.AddWithValue("@Soyad", Soyad);
                        command.Parameters.AddWithValue("@Departman", Departman);
                        command.Parameters.AddWithValue("@Görev", görev);
                        command.ExecuteNonQuery();
                    }
                }

                SavePhoto(Ad);
                MessageBox.Show("Kayıt başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePhoto(string ogrenciNumarasi)
        {
            try
            {
                string savePath = @"C:\Users\avcua\Desktop\deneme";

                if (!Directory.Exists(savePath))
                    Directory.CreateDirectory(savePath);

                string fileName = Path.Combine(savePath, $"{ogrenciNumarasi}.jpg");
                if (File.Exists(fileName))
                {
                    MessageBox.Show("Bu isimle bir fotoğraf zaten mevcut. Lütfen başka bir numara girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (pictureBox2.Image != null)
                {
                    pictureBox2.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO KullaniciFotograflar (ad, FotoYolu) VALUES (@ad, @FotoYolu)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ad", ogrenciNumarasi);
                            cmd.Parameters.AddWithValue("@FotoYolu", fileName);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Fotoğraf başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kaydedilecek bir fotoğraf yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fotoğraf kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CaptureImageToPictureBox2()
        {
            if (pictureBox3.Image != null)
            {
                Bitmap capturedImage = new Bitmap(pictureBox3.Image);
                pictureBox2.Image = new Bitmap(capturedImage, pictureBox2.Width, pictureBox2.Height);
            }
        }

        private void button1_Click(object sender, EventArgs e) => CaptureImageToPictureBox2();
        private void button2_Click(object sender, EventArgs e) => CaptureImageToPictureBox2();

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            videoCapture?.Release();
            videoCapture?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
