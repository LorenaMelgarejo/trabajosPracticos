using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto //falto agregar public
    {
        public enum ETipo { Entera, Descremada }
        private ETipo tipo;

        ///// <summary>
        ///// Por defecto, TIPO será ENTERA
        ///// </summary>
        ///// <param name="marca"></param>
        ///// <param name="patente"></param>
        ///// <param name="color"></param>

        public Leche(EMarca marca, string codigo, ConsoleColor color) :this(marca,codigo, color, ETipo.Entera)
        { }

        public Leche(EMarca marca, string codigo, ConsoleColor color,ETipo tipo) : base(codigo, marca, color) //faltaba la propiedad tipo
        {
            tipo = ETipo.Entera;
        }
       

        ///// <summary>
        ///// Las leches tienen 20 calorías
        ///// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;      //this.CantidadCaloria --> debe retornar 20
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar()); //(this) deberia llamar al metodo mostrar de la base
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias);// se reemplazo la coma por el signo +
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString(); //falto llamar al método ToString.
        }
    }
}
