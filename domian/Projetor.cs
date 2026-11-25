using SAPU.Domain.Enum;

namespace SAPU.Domain;

public class Projetor
{
    public int IdProjetor { get; set; }
    public int IdRegistro { get; set; }
    public List<Registro> Registros { get; set; }
    public TipoProjetor Tipo { get; set; }
    public Estado Estado { get; set; }
    public int Numero { get; set; }
    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }

    //construtor

    private Projetor()
    {
    }

}
