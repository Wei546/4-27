namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] change1 = new string[,] { { "³æ¼Æ ½Æ¼Æ" }, { "veo, vemos" }, { "ves, veis" }, { "Ve,ven" } };
        string verb="";
        int count = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            pictureBox1.Image = imageList1.Images[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            verb = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = "";
                if (verb == "ver")
                {
                    foreach (string answer in change1)
                    {
                        result += answer + "\n \t";
                    }
                    label1.Text = result;
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            catch
            {
                MessageBox.Show("error");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (count < 3)
                {
                    count++;
                    pictureBox1.Image = imageList1.Images[count];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (count > -1)
                {
                    count--;
                    pictureBox1.Image = imageList1.Images[count];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}