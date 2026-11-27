using Microsoft.EntityFrameworkCore;
using SAPU.Domain;
using SAPU.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPU.Infra.Data.Repositories;

public class ProfessorRepository : IProfessorRepository
{
    private readonly SAPUDbContext _context;

    // interface
    public Task AdicionarAsync(Professor professor)
    {
        throw new NotImplementedException();
    }

    public Task AtualizarAsync(Professor professor)
    {
        throw new NotImplementedException();
    }

    public Task<List<Professor>> ListarAtivosAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> MatriculaExisteAsync(string matricula)
    {
        var retorno = await _context.Professores.AnyAsync(p => matricula == p.Matricula);
        return retorno;
    }

    public async Task<Professor?> ObterPorIdAsync(int idProfessor)
    {
        var retorno = await _context.Professores.FindAsync(idProfessor);
        return retorno;
    }

    public Task<Professor?> ObterPorMatriculaAsync(string matricula)
    {
        throw new NotImplementedException();
    }
    // construtor
    public ProfessorRepository(SAPUDbContext context) 
    {
        _context = context;
    }
}
