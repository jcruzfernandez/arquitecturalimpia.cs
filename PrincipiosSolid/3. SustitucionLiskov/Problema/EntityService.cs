using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.SustitucionLiskov.Problema
{
    public abstract class EntityService
    {
        public virtual void Create() { 
        // Codigo para crear una entidad
        Console.WriteLine("Ejecuta EntityService.Create");
        }
        public virtual void Update()
        {
            // Codigo para crear una entidad
            Console.WriteLine("Ejecuta EntityService.Update");
        }
        public virtual void Delete()
        {
            // Codigo para crear una entidad
            Console.WriteLine("Ejecuta EntityService.Delete");
        }
    }
}
