using System;
using System.Linq;
using Dominio.Interfaces;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Infraestrutura
{
    public class UnidadeTrabalho : DbContext, IUnidadeTrabalho
    {

        public UnidadeTrabalho(string conexao)
            : base(conexao)
        {
        }

        public void RegistrarAlterado(object objeto)
        {
            if (!ExisteNoContexto(objeto))
            {
                Set(objeto.GetType()).Attach(objeto);
            }

            Entry(objeto).State = EntityState.Modified;
        }

        public void RegistrarNovo(object objeto)
        {
            Set(objeto.GetType()).Add(objeto);
        }

        public void RegistrarRemovido(object objeto)
        {
            if (!ExisteNoContexto(objeto))
            {
                Set(objeto.GetType()).Attach(objeto);
            }

            Entry(objeto).State = EntityState.Deleted;
        }

        public void RemoverContexto(object objeto)
        {
            if (ExisteNoContexto(objeto))
            {
                Entry(objeto).State = EntityState.Detached;
            }
        }

        private bool ExisteNoContexto(object objeto)
        {
            ObjectContext contexto = (this as IObjectContextAdapter).ObjectContext;

            Type entityType = ObjectContext.GetObjectType(objeto.GetType());

            EntityContainer container = contexto.MetadataWorkspace.
                GetEntityContainer(contexto.DefaultContainerName, DataSpace.CSpace);
            EntitySetBase entitySet = container.BaseEntitySets.
                Where(s => s.ElementType.Name == entityType.Name).SingleOrDefault();
            EntityKey key = contexto.CreateEntityKey(entitySet.Name, objeto);

            ObjectStateEntry entry;

            if (contexto.ObjectStateManager.TryGetObjectStateEntry(key, out entry))
            {
                return (entry.State != EntityState.Detached);
            }
            return false;
        }

        public void Salvar()
        {
            try
            {
                SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
 
    }
}
