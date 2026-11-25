using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPU.Domain.Interfaces;

public interface IRegistroRepository
{
    Task<Registro?> ObterPorIdAsync(int idRegistro);
    Task<Registro?> ObterEmAbertoPorProjetorAsync(int idProjetor);
    Task<List<Registro>> ListarEmAbertoAsync();
    Task<List<Registro>> ListarPorProfessorAsync(int idProfessor);
    Task<List<Registro>> ListarPorPeriodoAsync(DateTime inicio, DateTime fim);
    Task AdicionarAsync(Registro registro);
    Task AtualizarAsync(Registro registro);
}
