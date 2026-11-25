

using SAPU.Domain.Enum;

namespace SAPU.Domain;

public class DiaAgendado
{
    public int IdDiaAgendado { get; set; }
    public int IdAgendamento { get; set; }
    public DayOfWeek Dia { get; set; }
    public DateTime HoraInicio { get; set; }
    public DateTime HoraFim { get; set; }
    public Agendamento Agendamento{ get; set; }
    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }


    //construtor

    private DiaAgendado()
    {
    }
}