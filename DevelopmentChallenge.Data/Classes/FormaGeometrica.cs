/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Refactoring;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public static string GenerarReporte(List<IGeometricFigure> formas, IReport reporte, ILanguage lenguaje)
        {
            reporte.SetLanguage(lenguaje);

            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(reporte.GetEmptyText());

                return sb.ToString();
            }

            sb.Append(reporte.GetTitle());

            foreach (var items in formas.GroupBy(f => f.Type))
            {
                var area = items.Sum(i => i.CalcularArea());
                var perimetro = items.Sum(i => i.CalcularPerimetro());

                sb.Append(reporte.GetBody(items.Key, items.Count(), area, perimetro));
            }

            sb.Append(reporte.GetTotalTitle());
            sb.Append(reporte.GetTotalForms(formas.Count));
            sb.Append(reporte.GetTotalPerimeter(formas.Sum(f => f.CalcularPerimetro()).ToString("#.##")));
            sb.Append(reporte.GetTotalArea(formas.Sum(f => f.CalcularArea()).ToString("#.##")));

            return sb.ToString();
        }
    }
}