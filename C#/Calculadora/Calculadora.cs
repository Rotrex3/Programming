namespace calculadora
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClaseSum obj1 = new Clases.ClaseSum();
        Clases.ClaseRest obj2 = new Clases.ClaseRest();
        Clases.ClaseMult obj3 = new Clases.ClaseMult();
        Clases.ClaseDiv obj4 = new Clases.ClaseDiv();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Boton0_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "0";
        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "1";
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "2";
        }

        private void Boton3_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "3";
        }
        private void Boton4_Click_1(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "4";
        }

        private void Boton5_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "5";
        }

        private void Boton6_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "6";
        }

        private void Boton7_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "7";
        }

        private void Boton8_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "8";
        }

        private void Boton9_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "9";
        }

        private void BotonPoint_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + ",";
        }

        private void BotonSum_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void BotonRest_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void BotonMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void BotonDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void BotonResult_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Screen.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch(operador)
            {
                case "+":
                    Sum = obj1.Sumar((primero), (segundo));
                    Screen.Text = Sum.ToString();
                    break;
            }
        }
    }
}
