using Hoimi_DapperUdemy.SqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hoimi_DapperUdemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //画面の真ん中に表示する
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void DataTableReadButton_Click(object sender, EventArgs e)
        {

            DataTable dataTable = ProductSqlServer.GetDataTable();
            dataGridView1.DataSource = dataTable;



        }

        private void ReaderReadButton_Click(object sender, EventArgs e)
        {
            var result=ProductSqlServer.GetDataReader();
            dataGridView1.DataSource = result;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBoxから値を取得する
            string name=productNameTextBox.Text;
            int price = Convert.ToInt32(productPriceTextBox.Text);
            ProductEntity product = new ProductEntity(name, price);

            //sqlの実行
            ProductSqlServer.insert(product);

            DataTable dataTable = ProductSqlServer.GetDataTable();
            dataGridView1.DataSource = dataTable;

            productNameTextBox.Clear();
            productPriceTextBox.Clear();
        }

        private void DapperReadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductSqlServer.GetDapperRead();
        }

        private void DapperInsertButton_Click(object sender, EventArgs e)
        {
            //textBoxから値を取得する
            string name = productNameTextBox.Text;
            int price = Convert.ToInt32(productPriceTextBox.Text);
            ProductEntity product = new ProductEntity(name, price);

            //sqlの実行
            ProductSqlServer.DapperInsert(product);

            DataTable dataTable = ProductSqlServer.GetDataTable();
            dataGridView1.DataSource = dataTable;

            productNameTextBox.Clear();
            productPriceTextBox.Clear();
        }
    }
}
