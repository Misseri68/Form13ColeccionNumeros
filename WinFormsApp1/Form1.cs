namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode =
                SelectionMode.MultiExtended;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                this.lstElementos.Items.Add(new Random().Next(1, 100));
            }

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            int sumaTotal = 0;
            int sumaPares = 0;
            int sumaImpares = 0;

            foreach (var elemento in this.lstElementos.Items)
            {
                int numero = int.Parse(elemento.ToString());
                sumaTotal += numero;
                if (numero % 2 == 0) {
                    sumaPares += numero;
                }
                else
                {
                    sumaImpares += numero;
                }
            }


            this.txtSuma.Text = sumaTotal.ToString();
            this.txtSumaPares.Text = sumaPares.ToString();
            this.txtSumaImpares.Text = sumaImpares.ToString();
        }
    }
}
