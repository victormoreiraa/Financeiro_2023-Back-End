using Entities.Entidades;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface ISistemaFinanceiroService
    {
        Task AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
        Task AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
    }
}
