namespace Act3;

public partial class Paginaresta : ContentPage
{
    public Paginaresta()
    {
        InitializeComponent();
    }
    private void Eventoregresar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    public async void  Eventoresta(object sender, EventArgs e)
    {
        double num1 = Convert.ToDouble(txtn1.Text);
        double num2 = Convert.ToDouble(txtn2.Text);

        double resta = num1 - num2;

        txtresultadoresta.Text = resta.ToString();

        bool respuesta = await DisplayAlert("Titulo Del Sistema 1", "¿Seguro que desea elaborar la ejecucion?", "Aceptar/Si", "Cancelar/No");

        if (respuesta)
        {
            resta = num1 - num2;
            txtresultadoresta.Text = resta.ToString();
        }

        else
        {
            txtn1.Text = "";
            txtn2.Text = "";
            txtresultadoresta.Text = "";
            txtn1.Focus();
        }
    }

    private async void Nuevaoperacion(object sender, EventArgs e)
    {
        txtn1.Text = "";
        txtn2.Text = "";
        txtresultadoresta.Text = "";
        txtn1.Focus();
        await DisplayAlert("Titulo del Sistema 1", "Proceso Terminado", "Aceptar");
    }
}