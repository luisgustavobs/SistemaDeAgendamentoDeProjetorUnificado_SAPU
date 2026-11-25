
namespace SAPU.Domain;

public class Professor
{
    public int IdProfessor { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }

    public List<Agendamento> Agendamentos { get; set; }
    public List<Registro> Registros { get; set; }

    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }

    // construtor
    private Professor()
    {
    }

}

