namespace ConversorDeUnidades
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcularDistancia(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputDistancia.Text))
            {
                double valor = double.Parse(inputDistancia.Text);
                string origem = OrigemDistancia.SelectedItem.ToString();
                string destino = DestinoDistancia.SelectedItem.ToString();

                double resultado = ConverterDistancia(valor, origem, destino);
                outputDistancia.Text = $"Resultado: {resultado} {destino}";
            }
        }

        private double ConverterDistancia(double valor, string origem, string destino)
        {
            double metros = valor;
            if (origem == "Kilometers") metros = valor * 1000;
            else if (origem == "Centimeters") metros = valor / 100;

            if (destino == "Kilometers") return metros / 1000;
            else if (destino == "Centimeters") return metros * 100;

            return metros;
        }

        private void OnCalcularPeso(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputPeso.Text))
            {
                double valor = double.Parse(inputPeso.Text);
                string origem = OrigemPeso.SelectedItem.ToString();
                string destino = DestinoPeso.SelectedItem.ToString();

                double resultado = ConverterPeso(valor, origem, destino);
                outputPeso.Text = $"Resultado: {resultado} {destino}";
            }
        }

        private double ConverterPeso(double valor, string origem, string destino)
        {
            double gramas = valor;
            if (origem == "Kg") gramas = valor * 1000;
            else if (origem == "Lbs") gramas = valor * 453.592;

            if (destino == "Kg") return gramas / 1000;
            else if (destino == "Lbs") return gramas / 453.592;

            return gramas;
        }

        private void OnCalcularTemperatura(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputTemperatura.Text))
            {
                double valor = double.Parse(inputTemperatura.Text);
                string origem = OrigemTemperatura.SelectedItem.ToString();
                string destino = DestinoTemperatura.SelectedItem.ToString();

                double resultado = ConverterTemperatura(valor, origem, destino);
                outputTemperatura.Text = $"Resultado: {resultado} {destino}";
            }
        }

        private double ConverterTemperatura(double valor, string origem, string destino)
        {
            double celsius = valor;
            if (origem == "Fahrenheit") celsius = (valor - 32) * 5 / 9;
            else if (origem == "Kelvin") celsius = valor - 273.15;

            if (destino == "Fahrenheit") return celsius * 9 / 5 + 32;
            else if (destino == "Kelvin") return celsius + 273.15;

            return celsius;
        }
    }
}
