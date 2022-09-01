namespace VoeAirlines.Entities;

public class Voo{
    public Voo(string origem, string destino, DateTime dataHoraPartida, DateTime dataHoraChegada, int aeronaveId, int pilotoId)
    {
        Origem = origem;
        Destino = destino;
        DataHoraPartida = dataHoraPartida;
        DataHoraChegada = dataHoraChegada;
        AeronaveId = aeronaveId;
        PilotoId = pilotoId;
    }

    public int Id { get; set; }
     
     //GERA CONTRUTOR
     public string Origem { get; set; }
     public string Destino { get; set; }

     public DateTime DataHoraPartida { get; set; }

     public DateTime DataHoraChegada { get; set; }

     public int AeronaveId { get; set; }

     public int PilotoId { get; set; }
     
     //NÃOOOOOOOO GERE

     public Aeronave Aeronave { get; set; }=null!;
     public Piloto Piloto { get; set; }=null!;

     public Cancelamento? Cancelamento { get; set; }



}