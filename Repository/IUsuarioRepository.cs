using ApiMySql.Model;
using System.Collections.Generic;

namespace ApiMySql.Repository
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> FindAll();
        void Add(Usuario item);
        void Remove(int id);
        void Update(Usuario item);
        Usuario FindByID(int id);
        IEnumerable<Usuario> GetAll();
        bool ExistsID(int id);
    }
}