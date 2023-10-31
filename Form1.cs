namespace Practica8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Circuferencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radio1, area1, volumen1;
            radio1 = double.Parse(radioCirc.Text);
            area1 = 4 * 3.141592 * radio1 * radio1;
            volumen1 = 1.33333 * 3.141592 * radio1 * radio1 * radio1;
            areaCirc.Text = area1.ToString();
            VolumenCirc.Text = volumen1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioCirc.Text = "";
            areaCirc.Text = "";
            VolumenCirc.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(textBox1.Text);

            float valor2 = float.Parse(textBox2.Text);
            float valor3 = valor1 * valor2 / 2;

            textBox3.Text = valor3.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double lado1, area2, volumen2;
            lado1 = double.Parse(textBox4.Text);
            area2 = 6 * lado1 * lado1;
            volumen2 = lado1 * lado1 * lado1;
            textBox5.Text = area2.ToString();
            textBox6.Text = volumen2.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            double radio3, altura3, volumen3, area3;
            radio3 = double.Parse(textBox7.Text);
            altura3 = double.Parse(textBox8.Text);
            area3 = 2 * 3.141592 * radio3 * altura3 + 2 * 3.141592 * radio3 * radio3;
            volumen3 = 3.141592 * radio3 * radio3 * altura3;
            textBox9.Text = area3.ToString();
            textBox10.Text = volumen3.ToString();


        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
            textBox12.Text = "";
            textBox15.Text = "";


        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            double dimn4, area4, dimy4;
            dimn4 = double.Parse(textBox11.Text);
            dimy4 = double.Parse(textBox12.Text);
            area4 = dimy4 * dimn4 / 2;
            textBox15.Text = area4.ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double aris5, area5, volumen5;
            aris5 = double.Parse(textBox18.Text);
            area5 = 2 * 1.732 * aris5 * aris5;
            volumen5 = 1.414213 / 3 * aris5 * aris5 * aris5;
            textBox19.Text = area5.ToString();
            textBox20.Text = volumen5.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}