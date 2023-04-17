using MauiCursoFipe.Models;
using MauiCursoFipe.Repositorios;

namespace MauiCursoFipe;

public partial class MainPage : ContentPage
{
    // picker tipo tem que carregar o pickerfabricantes

    private static string sTipoVeiculo;
    private static string CodModelo;
    private static string AnoCarro;
    private static string anoSelPesquisado;

    public MainPage()
    {
        InitializeComponent();
        CarregarTipos();


    }

    public void CarregarTipos()
    {
        pickerTipo.Title = "Selecione um tipo de veiculo";
        pickerTipo.ItemsSource = VeiculoRepositorios.ListarVeiculos();
        pickerTipo.ItemDisplayBinding = new Binding("Tipo");

    }

    void SelTipo(object sender, EventArgs e)
    {
        var pickerTipo = (Picker)sender;
        int selectedIndex = pickerTipo.SelectedIndex;

        if (selectedIndex != -1)
        {
            Veiculo veiculos = (Veiculo)pickerTipo.ItemsSource[selectedIndex];
            sTipoVeiculo = veiculos.Tipo;

            CarregarFabricantes(sTipoVeiculo);
        }

    }

    private void CarregarFabricantes(string TipoVeiculo)
    {
        pickerFabricantes.Title = "Selecione um fabricante";
        pickerFabricantes.ItemsSource = FabricanteRespositorio.ListarFabricantes(TipoVeiculo);
        pickerFabricantes.ItemDisplayBinding = new Binding("Nome");

    }

    void SelFabricantes(object sender, EventArgs e)
    {
        var pickerFabricantes = (Picker)sender;
        int selectedIndex = pickerFabricantes.SelectedIndex;

        if (selectedIndex != -1)
        {
            Fabricante fabri = (Fabricante)pickerFabricantes.ItemsSource[selectedIndex];
            CodModelo = fabri.Codigo;


            CarregarModelos(CodModelo);
        }

    }

    private void CarregarModelos(string codigo)
    {
        pickerModeloCarro.Title = "Selecione um modelo de carro";
        pickerModeloCarro.ItemsSource = ModeloRepositorio.ListarModelos(codigo, sTipoVeiculo);
        pickerModeloCarro.ItemDisplayBinding = new Binding("nome");



    }

    void SelModelos(object sender, EventArgs e)
    {
        var pickerModeloCarro = (Picker)sender;
        int selectedIndex = pickerModeloCarro.SelectedIndex;

        if (selectedIndex != -1)
        {
            modelos Ano = (modelos)pickerModeloCarro.ItemsSource[selectedIndex];
            AnoCarro = Ano.codigo;


            CarregarAnos(AnoCarro);
        }

    }

    private void CarregarAnos(string CodAno)
    {
        pickerAnoCarro.Title = "Selecione o ano do veículo";
        pickerAnoCarro.ItemsSource = AnoRepositorio.ListarAnoCarro(CodModelo, sTipoVeiculo, CodAno);
        pickerAnoCarro.ItemDisplayBinding = new Binding("Nome");
    }


    void SelAnoPesquisado(object sender, EventArgs e)
    {
        var pickerAnoCarro = (Picker)sender;
        int selectedIndex = pickerAnoCarro.SelectedIndex;

        if (selectedIndex != -1)
        {
            Ano pAno = (Ano)pickerAnoCarro.ItemsSource[selectedIndex];
            anoSelPesquisado = pAno.Codigo;


        }

    }

    private void CarregaDadosPesquisado(object sender, EventArgs e)
    {
        lpreco.Text = PesquisaRepositorio.
            RetonaDadosCarro(CodModelo, sTipoVeiculo, AnoCarro, anoSelPesquisado).Valor;
    }


}

