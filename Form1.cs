using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Geroinchik
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Учеба\\ООП Данчика\\Geroinchik\\Access.mdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accessDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.accessDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accessDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.accessDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accessDataSet.Категории_товара". При необходимости она может быть перемещена или удалена.
            this.категории_товараTableAdapter.Fill(this.accessDataSet.Категории_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accessDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.accessDataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accessDataSet.Покупки". При необходимости она может быть перемещена или удалена.
            this.покупкиTableAdapter.Fill(this.accessDataSet.Покупки);

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
