using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloDeCargaDeProductos
{
    class CargaDeDatos
    {
        public string TipoDispositivo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set;  }
        public int NumSerie { get; set; }
        public int Precio { get; set; }

        public string ListadoPorTipo()
        {
            return "Listado por tipo: " + " Marca->" + this.Marca + "-Modelo-> " + this.Modelo;
        }

        public string ListadoCompleto()
        {
            return "Listado completo: " + "Tipo de Dispositivo->"+this.TipoDispositivo+"-Marca->" + this.Marca + "-Modelo-> " + this.Modelo + "-Precio->" + this.Precio;
        }
    }
}
