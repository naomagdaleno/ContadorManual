using ContadorManual.Maui.models;

namespace ContadorManual.Maui.Views;

public partial class MainPage : ContentPage
{
    private Comtador _contador;
	public MainPage()
	{
		InitializeComponent();

        _contador = new Comtador();
        ConteoLabel.Text = _contador.Conteo.ToString();
	}

    private void OnContadorButtonClicked(object sender, EventArgs e)
    {
        _contador.Contar();
        ConteoLabel.Text = _contador.Conteo.ToString();
    }

    private void OnReiniciarButtonClicked(object sender, EventArgs e)
    {
        _contador.Reiniciar();
        ConteoLabel.Text = _contador.Conteo.ToString();
    }
}