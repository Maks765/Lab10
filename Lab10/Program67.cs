using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LR10
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TabControl tabControl = new TabControl();
            tabControl.Size = new System.Drawing.Size(1800, 1000); // Встановлюємо розмір контролера вкладок

            // Вкладка "Метод 1"
            TabPage tabPage1 = new TabPage("Метод 1");
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns.Add("Number", "№");
            dataGridView1.Columns.Add("Method", "Метод");

            dataGridView1.Rows.Add("1", "DES");
            dataGridView1.Rows.Add("2", "LUCIFER");
            dataGridView1.Rows.Add("3", "KHUFU");
            dataGridView1.Rows.Add("4", "LOKI");
            dataGridView1.Rows.Add("5", "REDOC");
            dataGridView1.Rows.Add("6", "FEAL");
            dataGridView1.Rows.Add("7", "Newdes");
            dataGridView1.Rows.Add("8", "MADRYGA");
            dataGridView1.Rows.Add("9", "KHAFRE");
            // Add the rest of the rows as needed

            tabPage1.Controls.Add(dataGridView1);
            tabControl.TabPages.Add(tabPage1);

            // Вкладка "Метод 2"
            TabPage tabPage2 = new TabPage("Метод 2");
            DataGridView dataGridView2 = new DataGridView();
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;

            dataGridView2.Columns.Add("Number", "№");
            dataGridView2.Columns.Add("Method", "Метод");

            dataGridView2.Rows.Add("1", "Snefru");
            dataGridView2.Rows.Add("2", "N-Хэш");
            dataGridView2.Rows.Add("3", "MD-4");
            dataGridView2.Rows.Add("4", "SHA");
            dataGridView2.Rows.Add("5", "RIPE-MD");
            dataGridView2.Rows.Add("6", "HAVAL");
            dataGridView2.Rows.Add("7", "N-Хеш");
            dataGridView2.Rows.Add("8", "ONG-SCHNORRSHAMIR");
            dataGridView2.Rows.Add("9", "ESIGN");
            // Add the rest of the rows as needed

            tabPage2.Controls.Add(dataGridView2);
            tabControl.TabPages.Add(tabPage2);

            // Вкладка "Метод 3"
            TabPage tabPage3 = new TabPage("Метод 3");
            DataGridView dataGridView3 = new DataGridView();
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.ReadOnly = true;
            dataGridView3.AllowUserToAddRows = false;

            dataGridView3.Columns.Add("Number", "№");
            dataGridView3.Columns.Add("Method", "Метод");

            dataGridView3.Rows.Add("1", "Алгоритми Рюкзака");
            dataGridView3.Rows.Add("2", "RSA");
            dataGridView3.Rows.Add("3", "Rabin");
            dataGridView3.Rows.Add("4", "Eigamal");
            dataGridView3.Rows.Add("5", "Mceliece");
            dataGridView3.Rows.Add("6", "LUC");
            dataGridView3.Rows.Add("7", "DSA");
            dataGridView3.Rows.Add("8", "Алгоритм цифрового підпису");
            dataGridView3.Rows.Add("9", "ДЕРЖСТАНДАРТ");
            // Add the rest of the rows as needed

            tabPage3.Controls.Add(dataGridView3);
            tabControl.TabPages.Add(tabPage3);

            Form form = new Form();
            form.Text = "Моя програма";
            form.Controls.Add(tabControl);

            Application.Run(form);
        }
    }
}
