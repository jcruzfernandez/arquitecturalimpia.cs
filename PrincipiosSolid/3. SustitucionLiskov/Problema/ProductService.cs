using PrincipiosSolid.SustitucionLiskov.Problema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid._3._SustitucionLiskov.Problema
{
    internal class ProductService: EntityService
    {
        public override void Create()
        {
            // Codigo para crear una entidad
            Console.WriteLine("Ejecuta EntityService.Create");
        }
        public override void Update()
        {
            // Codigo para crear una entidad
            Console.WriteLine("Ejecuta EntityService.Update");
        }
        public override void Delete()
        {
            // Codigo para crear una entidad
            Console.WriteLine("Ejecuta EntityService.Delete");
        }
    }
}
