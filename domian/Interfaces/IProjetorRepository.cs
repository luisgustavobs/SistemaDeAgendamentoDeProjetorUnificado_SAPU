using SAPU.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPU.Domain.Interfaces;

public interface IProjetorRepository
{
    Task<Projetor?> ObterPorIdAsync(int idProjetor);
    Task<Projetor?> ObterPorNumeroAsync(int numero);
    Task<List<Projetor>> ListarAtivosAsync();
    Task<List<Projetor>> ListarPorEstadoAsync(Estado estado);
    Task<bool> NumeroExisteAsync(int numero);
    Task AdicionarAsync(Projetor projetor);
    Task AtualizarAsync(Projetor projetor);
}
