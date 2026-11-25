using SAPU.Domain.Enum;

namespace SAPU.Domain;

public class Periferico
{
    public int IdPeriferico { get; set; }
    public TipoPerifericos Tipo { get; set; }
    public Estado Estado { get; set; }
    public int Numero { get; set; }
    public List<RegistroPeriferico> RegistroPerifericos { get; set; }
    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }
    //construtor
    private Periferico()
    {
    }
}
