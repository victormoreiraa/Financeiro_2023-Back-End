using Entities.Entidades;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface IDespesaService
    {
        Task AdicionarDespesa(Despesa despesa);
        Task AtualizarDespesa(Despesa despesa);

        Task<object> CarregaGraficos(string emailUsuario);
    }
}
