namespace myfinance_web_netcore_domain.Entities;

public class Transacao
{
    public int Id { get; set;}
    public string Descricao { get; set;}
    public string Tipo {g et; set;}
    public string Historico3 { get; set;}
    public DateTime Valor {g et; set;}
    public int PlanoContaId { get; set;}
    public PlanoConta PlanoConta { get; set; }

}
