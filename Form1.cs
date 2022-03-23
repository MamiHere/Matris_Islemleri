namespace Matris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        int[,] matris1;
        int[,] matris2;
        int[,] matris3;
        void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            matris1 = new int[a, a];
            matris2 = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {

                    matris1[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox((i + 1) + ".satýr" + (j + 1) + ".sütunu giriniz.", "sayý giriniz", "", 40, 40));
                    textBox1.Text = textBox1.Text + matris1[i, j] + " ";
                    matris2[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox((i + 1) + ".satýr" + (j + 1) + ".sütunu giriniz.", "sayý giriniz", "", 40, 40));
                    textBox2.Text = textBox2.Text + matris2[i, j] + " ";
                }
                textBox1.Text = textBox1.Text + "\r\n";
                textBox2.Text = textBox2.Text + "\r\n";

            }
        }
        void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            matris3 = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    int v = matris1[i, j] + matris2[i, j];
                    matris3[i, j] = v;
                    textBox4.Text = textBox4.Text + matris3[i, j] + " ";
                }
                textBox4.Text = textBox4.Text + "\r\n";
            }
        }

        void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            matris3 = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    matris3[i, j] = matris1[i, j] - matris2[i, j];
                    textBox4.Text = textBox4.Text + matris3[i, j] + " ";
                }
                textBox4.Text = textBox4.Text + "\r\n";
            }

        }

        void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            matris3 = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    for (int k = 0; k < a; k++)
                    {
                        matris3[i, j] += matris1[i, k] * matris2[k, j];
                    }
                    textBox4.Text = textBox4.Text + matris3[i, j]+" ";
                }
                textBox4.Text = textBox4.Text + "\r\n";
            }
        }
    }
}