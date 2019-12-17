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
    public partial class Statitistics : Form
    {
        private string connString;
        private string entity;
        private string operation;
        private StatisticsHandler statHandler;

        public Statitistics(String connString)
        {
            InitializeComponent();
            this.connString = connString;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            entity = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            operation = comboBox2.Text;
        }

        private void Statitistics_Load(object sender, EventArgs e)
        {

        }

        private void lLoginBtn_Click(object sender, EventArgs e)
        {
            statHandler = new StatisticsHandler(connString);
            string output = "";

            switch(entity)
            {
                case "Users":
                    switch(operation)
                    {
                        case "sum":
                            output  = statHandler.SumUser().ToString();
                            break;
                        case "max":
                            output = statHandler.MaxUser();
                            break;
                        case "min":
                            output = statHandler.MinUser();
                            break;
                        case "avg":
                            output = statHandler.AvgUser();
                            break;
                    }
                    break;
                case "Products":
                    switch (operation)
                    {
                        case "sum":
                            output = statHandler.SumProduct().ToString();
                            break;
                        case "max":
                            output = statHandler.MaxProduct();
                            break;
                        case "min":
                            output = statHandler.MinProduct();
                            break;
                        case "avg":
                            output = statHandler.AvgProduct();
                            break;
                    }
                    break;
            }

            StatisticsView statView = new StatisticsView(connString, entity, operation, output);
            statView.Show();
        }
    }
}
