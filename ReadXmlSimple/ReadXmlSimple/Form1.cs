using System.Data;

namespace ReadXmlSimple
{
    public partial class Form1 : Form
    {

        DataSet ds;

        public Form1()
        {
            InitializeComponent();

            this.ds = new DataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ds.ReadXml("table.xml");
            this.dataGridView1.DataSource = this.ds.Tables["table1"];
            MessageBox.Show(this.ds.DataSetName.ToString());

        }

    }

}
