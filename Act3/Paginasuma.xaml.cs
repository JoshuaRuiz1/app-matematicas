namespace Act3;

public partial class Paginasuma : ContentPage
{
	public Paginasuma()
	{
		InitializeComponent();
	}
    private void Eventoregresar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    public async void Eventosumar(object sender, EventArgs e)
    {
        double num1 = Convert.ToDouble(txtn1.Text);
        double num2 = Convert.ToDouble(txtn2.Text);

        double suma = num1 + num2;
        double resta = num1 - num2;
        double multi = num1 * num2;
        double divi = num1 / num2;

        txtresultado.Text = suma.ToString();
        txtresultadoresta.Text = resta.ToString();
        txtresultadomulti.Text = multi.ToString();
        txtresultadodivi.Text = divi.ToString();

        bool respuesta = await DisplayAlert("Titulo Del Sistema 1", "¿Seguro que desea elaborar la ejecucion?", "Aceptar/Si", "Cancelar/No");

        if (respuesta)
        {
            suma = num1 + num2;
            txtresultado.Text = suma.ToString();
        }

        else
        {
            txtn1.Text = "";
            txtn2.Text = "";
            txtresultado.Text = "";
            txtn1.Focus();
        }
    }


    private async void Nuevaoperacion(object sender, EventArgs e)
    {
        txtn1.Text = "";
        txtn2.Text = "";
        txtresultado.Text = "";
        txtn1.Focus();
        await DisplayAlert("Titulo del Sistema 1", "Proceso Terminado", "Aceptar");
    }
}