namespace VoeAirlines.ViewModels.Piloto
{

    public class AtualizarPilotoViewModel
    {
        public AtualizarPilotoViewModel(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
        public string Nome { get; set; }
        public string Matricula { get; set; }

    }
}

