using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIHATFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDbDataSet4.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter4.Fill(this.localDbDataSet4.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDbDataSet3.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter3.Fill(this.localDbDataSet3.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDbDataSet2.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter2.Fill(this.localDbDataSet2.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDbDataSet1.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter1.Fill(this.localDbDataSet1.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDbDataSet.User". При необходимости она может быть перемещена или удалена.

        }
    }
}
