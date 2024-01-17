using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace _9ocak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable tablo = new DataTable();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("ID",typeof(int));
            tablo.Columns.Add("Gider",typeof(string));
            tablo.Columns.Add("Tutar",typeof(double));

            dataGridView1.DataSource = tablo;
        }
        private int ID = 1;
      private void button1_Click(object sender, EventArgs e)
        {
            //ID dışarıdan girilerek yazılan kod bloğu//
            /*
            tablo.Rows.Add(textBox1.Text,textBox2.Text,textBox3.Text);
            dataGridView1.DataSource = tablo; //tabloyu datagrid'e bagla
            double toplam = 0;
            for (int i = 0; 1 < dataGridView1.Rows.Count; i++)
                toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            label4.Text = "ToplamTutar:" + toplam.ToString();
            */
            //TexBox'tan değerleri al
            //ID program tarafından otomatik atanan yazılım bloğu
            string gider = textBox2.Text;
            string tutar = textBox3.Text;

            tablo.Rows.Add(ID,gider,tutar);
            dataGridView1.DataSource = tablo;

            //ID'yi arttır
            ID++;
            UpdateID();
            Temizle();
        
        }

        public void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Satırn index nosuna göre siler
                //yani kaçıncısatırı kaldırmak istediğimizi belirtmemiz gerekir.
                //selected içindeki 0 değeri, tek satır seçmek için
                int indis = dataGridView1.SelectedRows[0].Index;
                //seçilen satırı DataGridView'den kaldır
                dataGridView1.Rows.RemoveAt(indis);

                UpdateID();
            }

            else
                MessageBox.Show("Lütfen Silinecek Satırı Silin!");
        }

        public void UpdateID()
        {
            /*for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Cells[0].Value = i + 1;*/
            int id = 1;

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = id;
                id++;
            }
        }
    }
}
