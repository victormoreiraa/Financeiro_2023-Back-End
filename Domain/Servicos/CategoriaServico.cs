using Domain.Interfaces.ICategoria;
using Domain.Interfaces.InterfaceServicos;
using Entities.Entidades;

namespace Domain.Servicos
{
    public class CategoriaServico : ICategoriaService
    {

        private readonly InterfaceCategoria _interfaceCategoria;
        public CategoriaServico(InterfaceCategoria interfaceCategoria)
        {
            _interfaceCategoria = interfaceCategoria;
        }

        public async Task AdicionarCategoria(Categoria catagoria)
        {
            var valido = catagoria.ValidarPropriedadeString(catagoria.Nome, "Nome");
            if (valido)
                await _interfaceCategoria.Add(catagoria);
        }

        public async Task AtualizarCategoria(Categoria catagoria)
        {
            var valido = catagoria.ValidarPropriedadeString(catagoria.Nome, "Nome");
            if (valido)
                await _interfaceCategoria.Update(catagoria);
        }
    }
}
