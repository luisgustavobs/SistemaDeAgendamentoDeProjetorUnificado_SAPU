using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPU.Domain.Interfaces;

public interface IAgendamentoRepository
{
    Task<Agendamento?> ObterPorIdAsync(int idAgendamento);
    Task<List<Agendamento>> ListarAtivosPorProfessorAsync(int idProfessor);
    Task<List<Agendamento>> ListarVigentesAsync();
    Task<List<Agendamento>> ListarPorDataAsync(DateTime data);

    //Horario com Horario
    Task<List<Agendamento>> ListarConflitantesAsync(
        DateTime dataInicio, DateTime dataFim,
        DayOfWeek dia, DateTime horaInicio, DateTime horaFim);

    Task AdicionarAsync(Agendamento agendamento);
    Task AtualizarAsync(Agendamento agendamento);

}
