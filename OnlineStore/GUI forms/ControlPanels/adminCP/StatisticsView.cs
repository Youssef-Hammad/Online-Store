using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class StatisticsView : Form
    {
        private string connString;

        public StatisticsView(string connString, string entity, string operation, string stat)
        {
            InitializeComponent();
            this.connString = connString;
            textBox1.Text = entity;
            textBox3.Text = operation;
            textBox2.Text = stat;
        }

        private void StatisticsView_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
