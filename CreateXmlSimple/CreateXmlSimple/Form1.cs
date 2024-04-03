using System.Data;

namespace CreateXmlSimple
{
    public partial class Form1 : Form
    {

        DataSet ds;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();

            this.ds = new DataSet("ds");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dt = GetTable("table1");
            this.ds.Tables.Add(this.dt);
            this.dataGridView1.DataSource = this.dt;
        }

        public DataTable GetTable(string nametable)
        {

            DataTable table = new DataTable(nametable);
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Diagnosis", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            table.Rows.Add(25, "Drug A", "Disease A", DateTime.Now);
            table.Rows.Add(50, "Drug Z", "Problem Z", DateTime.Now);
            table.Rows.Add(10, "Drug Q", "Disorder Q", DateTime.Now);
            table.Rows.Add(21, "Medicine A", "Diagnosis A", DateTime.Now);
            return table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dt.WriteXml("table.xml");
            /*
            string result;
            using (StringWriter sw = new StringWriter())
            {
                this.dt.WriteXml(sw);
                result = sw.ToString();
                MessageBox.Show(result);
            }
            */
        }


    }

}
