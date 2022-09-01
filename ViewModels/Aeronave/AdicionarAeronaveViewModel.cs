//SEM ID
namespace VoeAirlines.ViewModels;
public class AdicionarAeronaveViewModel
{
    public AdicionarAeronaveViewModel(string fabricante, string modelo, string codigo, string celebridade)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Codigo = codigo;
        Celebridade = celebridade;
    }

    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public string Codigo { get; set; }
    public string Celebridade { get; set; }

}
