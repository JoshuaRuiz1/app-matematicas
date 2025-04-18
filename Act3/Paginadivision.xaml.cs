using System.Threading.Tasks;

namespace Act3;

public partial class Paginadivision : ContentPage
{
    public Paginadivision()
    {
        InitializeComponent();
    }
    private void Eventoregresar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    public async void Eventodivision(object sender, EventArgs e)
    {
        double num1 = Convert.ToDouble(txtn1.Text);
        double num2 = Convert.ToDouble(txtn2.Text);

        double div = num1 / num2;

        txtresultadodivi.Text = div.ToString();

        bool respuesta = await DisplayAlert("Titulo Del Sistema 1", "¿Seguro que desea elaborar la ejecucion?", "Aceptar/Si", "Cancelar/No");

        if (respuesta)
        {
            div = num1 / num2;
            txtresultadodivi.Text = div.ToString();
        }

        else
        {
            txtn1.Text = "";
            txtn2.Text = "";
            txtresultadodivi.Text = "";
            txtn1.Focus();
        }
    }

    private async void Nuevaoperacion(object sender,EventArgs e)
    {
        txtn1.Text = "";
        txtn2.Text = "";
        txtresultadodivi.Text = "";
        txtn1.Focus();
        await DisplayAlert("Titulo del Sistema 1", "Proceso Terminado", "Aceptar");
    }
}