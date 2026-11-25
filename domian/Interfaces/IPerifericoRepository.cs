using SAPU.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPU.Domain.Interfaces;

public interface IPerifericoRepository
{
    Task<Periferico?> ObterPorIdAsync(int idPeriferico);
    Task<List<Periferico>> ListarAtivosAsync();
    Task<List<Periferico>> ListarPorTipoEEstadoAsync(TipoPerifericos tipo, Estado estado);
    Task<bool> NumeroExisteAsync(TipoPerifericos tipo, int numero);
    Task AdicionarAsync(Periferico periferico);
    Task AtualizarAsync(Periferico periferico);
}
