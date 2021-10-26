using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Restaurante
{
    public class AgOrdenesBL
    {
        public BindingList<Orden> ListaOrdenes { get; set; }


        public AgOrdenesBL()
        {
            ListaOrdenes = new BindingList<Orden>();

            var Orden1 = new Orden();
            Orden1.id = 001;
            Orden1.descripcion = "Hamburguesa Clasica";
            Orden1.precio = 120.00;
            Orden1.existencia = 50;
            Orden1.activo = true;

            ListaOrdenes.Add(Orden1);

            var Orden2 = new Orden();
            Orden2.id = 002;
            Orden2.descripcion = "Alitas BBQ";
            Orden2.precio = 120.00;
            Orden2.existencia = 100;
            Orden2.activo = true;

            ListaOrdenes.Add(Orden2);

            var Orden3 = new Orden();
            Orden3.id = 003;
            Orden3.descripcion = "Arroz Frito ";
            Orden3.precio = 140.00;
            Orden3.existencia = 30;
            Orden3.activo = true;

            ListaOrdenes.Add(Orden3);

        }

        public BindingList<Orden> ObtenerOrdenes()
        {
            return ListaOrdenes;
        }

        public Resultado GuardarOrden(Orden orden)
        {

            var resultado = validar(orden);
            if (resultado.Exitoso == false)

            {
                return resultado;
            }

            if (orden.id == 0)
            {
                orden.id = ListaOrdenes.Max(item => item.id) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void agregarOrden()
        {
            var nuevaOrden = new Orden();

            ListaOrdenes.Add(nuevaOrden);
        }

        public bool eliminarOrden(int id)
        {
            foreach (var item in ListaOrdenes)
            {
                if (item.id == id)
                {
                    ListaOrdenes.Remove(item);
                    return true;
                }
            }
            return false;

        }

        private Resultado validar(Orden orden)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(orden.descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }

            if (orden.existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (orden.precio < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }


            return resultado;
        }

        public class Orden
        {
            public int id { get; set; }
            public string descripcion { get; set; }
            public double precio { get; set; }
            public int existencia { get; set; }
            public bool activo { get; set; }
        }
        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }
    }
}

