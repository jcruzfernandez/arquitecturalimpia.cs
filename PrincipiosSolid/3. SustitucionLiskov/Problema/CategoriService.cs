using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.SustitucionLiskov.Problema
{
    public class CategoriService: EntityService
    {
        public virtual void Create()
        {
            // Codigo para crear una entidad
            Console.WriteLine("Ejecuta EntityService.Create");
        }
    }
}
