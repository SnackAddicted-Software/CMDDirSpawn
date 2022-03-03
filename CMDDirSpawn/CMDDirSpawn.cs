namespace CMDDirSpawn
{
    public partial class CMDDirSpawn : Form
    {
        public CMDDirSpawn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string directory = textBox1.Text;
        }
    }
}