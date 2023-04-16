using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Home_Ass_MOVIE
{
    public partial class Form1 : Form
    {
        List<PictureBox> listgambar = new List<PictureBox>();
        List<film> judul = new List<film>() { };
        List<string> pukul = new List<string>() { "07.30", "09.00", "10.50", "11.40", "12.10", "13.20", "15.30", "18.50", "19.20", "20.10", "21.30", "22.10", "07.30", "09.00", "10.50", "11.40", "12.10", "13.20", "15.30", "18.50", "19.20", "20.10", "21.30", "22.10" };
        //List<String> judulfilm = new List<string>() { "Hulk", "Monster Inc", "Bullet Train", "Minion", "Good Dinosaur", "Dilan", "Toy Story", "Avenger" };
        ComboBox boxjam = new ComboBox();
        List<ComboBox> BoxJam = new List<ComboBox>();
        List<string> pesankursi = new List<string>();
        int tagfilm = 0;
        Random merah = new Random();
        Button submit = new Button();
        Button reset = new Button();
        int pilihbaru = 0;
        int kuning = 0;
        Label pesanan = new Label();

        string ambil = Properties.Resources.movie;
        string[] belah = null;


        string[] susah = null;
        string[] susahbanget = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            belah = ambil.Split('-');
            susah = belah[0].Split(',');
            susahbanget = belah[1].Split(',');

            film mboh = new film();
            jam yee = new jam();

            int count = 0;

            int x = 0;
            int count2 = 0;


            submit.Location = new Point(20, 650);
            submit.Text = "Submit";
            submit.Size = new Size(140, 40);
            submit.Click += Submit_Click;

            reset.Location = new Point(200, 650);
            reset.Text = "Reset";
            reset.Size = new Size(140, 40);
            reset.Click += Reset_klik;

            pesanan.Location = new Point( 10, 20);
            pesanan.Text = "Kursi yang anda pilih:   " ;
            pesanan.AutoSize = true;





            for (int i = 0; i < 8; i++)
            {

               

                PictureBox poster = new PictureBox();
                string fileName = susahbanget[i]; // Specify the file name of the image
                try
                {
                    string imagePath = Application.StartupPath + "\\" + fileName; // Combine the file name with the application startup path 
                    poster.Image = Image.FromFile(imagePath); // Load the image from the file
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }

                poster.Tag = i.ToString();
                poster.Location = new Point(5 + x, 5);
                poster.Size = new Size(160, 210);
                poster.SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(poster);
                listgambar.Add(poster);
                poster.Click += poster_klik;
                boxjam = new ComboBox();

                for (int s = 0; s < 3; s++)
                {
                    boxjam.Items.Add(pukul[count2]);
                    count2++;
                }
               
                boxjam.Location = new Point(5 + x, 250);
                boxjam.Size = new Size(50, 10);

                boxjam.SelectionChangeCommitted += boxpilih;
                
                BoxJam.Add(boxjam);
                x += 200;
                this.Controls.Add(boxjam);
                boxjam.Visible = false;

            }
            for (int i = 0; i < 8; i++)
            {
                mboh = new film();
                
                for (int j = 0; j < 3; j++)
                {
                    yee = new jam();
                    yee.waktu = pukul[count];
                    int tag1 = 0;
                    int t = 0;
                    int y = 0;
                    for (int a = 0; a< 10; a++)
                    {
                        for (int b = 0; b < 10; b++)
                        {
                            Button kursi = new Button();
                            kursi.Location = new Point(20 + t, 50 + y);
                            kursi.Size = new Size(50, 50);
                            kursi.BackColor = Color.DarkGray;
                            kursi.Tag = tag1.ToString();
                            //panel1.Controls.Add(kursi);
                            kursi.Click += Kursi_Click;
                            yee.tempat.Add(kursi);
                        
                            tag1++;
                            t += 55;
                        }
                        y += 55;
                        t = 0;
                    }


                    for (int k = 0; k < 70; k++)
                    {
                        yee.tempat[merah.Next(0, yee.tempat.Count)].BackColor = Color.Tomato;
                    }
                    mboh.jamfilm.Add(yee);
                    count++;
                }
                mboh.namafilm = susah[i];
                judul.Add(mboh);
            }
        }
        private void Reset_klik(object sender, EventArgs e)
        {
            pesanan.Text = "Kursi yang anda pilh:   ";
            pesankursi.Clear();
            kuning = 0;
            for (int i = 0; i < judul[tagfilm].jamfilm[pilihbaru].tempat.Count; i++)
            {
               judul[tagfilm].jamfilm[pilihbaru].tempat[i].BackColor = Color.DarkGray;
            }
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            pesanan.Text = "Kursi yang anda pilh:   ";
            pesankursi.Clear();
            kuning = 0;
            for (int i = 0; i < 100; i++)
            {
               if ( judul[tagfilm].jamfilm[pilihbaru].tempat[i].BackColor == Color.Yellow)
                {
                    judul[tagfilm].jamfilm[pilihbaru].tempat[i].BackColor = Color.Tomato;
                    kuning++;
                }
            }
            MessageBox.Show("kon dah milih " + kuning + "kursi", "Yoooo", MessageBoxButtons.OK);
        }

        private void Kursi_Click(object sender, EventArgs e)
        {
            Button seat = sender as Button;
            pesanan.Text = "Kursi yang anda pilih:   ";
            if (  seat.BackColor == Color.DarkGray  )
            {
                seat.BackColor = Color.Yellow;
                pesankursi.Add(seat.Tag.ToString());
                
            }
            
            else if (seat.BackColor == Color.Yellow)
            {
                seat.BackColor = Color.DarkGray;
                pesankursi.Remove(seat.Tag.ToString());
            }

            for ( int i = 0; i < pesankursi.Count; i++)
            {
                pesanan.Text += pesankursi[i] + ", " ;
            }
            pesanan.Text = pesanan.Text.Remove(pesanan.Text.Length-2);
        }

        private void poster_klik(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PictureBox tombol = sender as PictureBox;
            for ( int i = 0; i < 8; i ++)
            {
                BoxJam[i].Visible = false;
                if (tombol == listgambar[i] )
                {
                    BoxJam[i].Visible = true;
                    tagfilm = Convert.ToInt32(listgambar[i].Tag);
                }
            }
        }
        private void boxpilih(object sender, EventArgs e)
        {
            ComboBox pilihan = sender as ComboBox;
            pilihbaru = pilihan.SelectedIndex;
            panel1.Controls.Clear();
            for (int i = 0; i < 100; i++)
            {
                panel1.Controls.Add(judul[tagfilm].jamfilm[pilihan.SelectedIndex].tempat[i]);
               
                
            }
            panel1.Controls.Add(submit);
            panel1.Controls.Add(pesanan);
            panel1.Controls.Add(reset);

        }


    }
}

