
namespace SAPU.Domain;

public class Agendamento
{
    public int IdAgendamento { get; set; }
    public Professor Professor { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public List<DiaAgendado> DiaAgendados { get; set; } = new List<DiaAgendado>();
    public List<Registro> Registros { get; set; } = new List<Registro>();
    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }


    //construtor
    private Agendamento()
    {

    }

    public Agendamento(Professor professor, DateTime dataInicio, DateTime dataFim)
    {
        Professor = professor;
        DataInicio = dataInicio;
        DataFim = dataFim;
        DataCadastro = DateTime.Now;
        Ativo = true;
    }
}