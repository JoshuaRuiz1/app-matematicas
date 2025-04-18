namespace Act3;

public partial class Paginamultiplicar : ContentPage
{
    public Paginamultiplicar()
    {
        InitializeComponent();
    }
    private void Eventoregresar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    public async void Eventomultiplicar(object sender, EventArgs e)
    {
        double num1 = Convert.ToDouble(txtn1.Text);
        double num2 = Convert.ToDouble(txtn2.Text);

        double multi = num1 * num2;

        txtresultadomulti.Text = multi.ToString();

        bool respuesta = await DisplayAlert("Titulo Del Sistema 1", "¿Seguro que desea elaborar la ejecucion?", "Aceptar/Si", "Cancelar/No");

        if (respuesta)
        {
            multi = num1 * num2;
            txtresultadomulti.Text = multi.ToString();
        }

        else
        {
            txtn1.Text = "";
            txtn2.Text = "";
            txtresultadomulti.Text = "";
            txtn1.Focus();
        }
    }

    private async void Nuevaoperacion(object sender, EventArgs e)
    {
        txtn1.Text = "";
        txtn2.Text = "";
        txtresultadomulti.Text = "";
        txtn1.Focus();
        await DisplayAlert("Titulo del Sistema 1", "Proceso Terminado", "Aceptar");
    }
}