using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.SegregacionInterfaces.Problema
{
    public interface IRepository<Entity>
    {
        void Create(Entity entity);
    }
   
}
