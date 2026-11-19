
namespace SAPU.Domain;
public class Registro
{
    public int IdRegistro { get; set; }
    public string Sala { get; set; }
    public Professor Professor { get; set; }
    public List<RegistroPeriferico> Perifericos { get; set; }
    public DateTime HorarioRetirada { get; set; }
    public DateTime HorarioDevolucao { get; set; }
    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }

    //construtor
    private Registro()
    {
    }
}
