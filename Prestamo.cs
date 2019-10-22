using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public class Prestamo
    {
        private String cancha;

        public String Cancha
        {
            get { return cancha; }
            set { cancha = value; }
        }

        private float costo;

        public float Costo
        {
            get
            {
                if (Cancha == "FUTBOL")
                    return 20;
                else if (Cancha == "FULBITO")
                    return 15;
                else
                    return 5;
            }

        }
        private int horas;

        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }

        private float subtotal;

        public float Subtotal
        {
            get
            {

                return costo * horas;
            }
        }
        private float descuento;

        public float Descuento
        {
            get { return descuento; }
            set
            {
                if (value != 10 && value != 20)
                {
                    throw new Exception("Ingrese un descuento del 10% o 20%");
                }
                descuento = value;
            }
        }


        private float subtotal_2;

        public float Subtotal_2
        {
            get
            {
                return Subtotal - (Subtotal * Descuento / 100);


            }

        }

        private float iva;

        public float Iva
        {
            get { return (Subtotal_2 * 12 / 100); ; }

        }

        private float final;

        public float Final
        {
            get { return subtotal_2 + iva; }

        }

        private float pagado;

        public float Pagado
        {
            get { return pagado; }
            set
            {
                if (value >= (final / 2))
                {
                    pagado = value;
                }
                else
                {
                    throw new Exception("Debe pagar el 50% o más del valor final");
                }
            }
        }


        private float pendiente;

        public float Pendiente
        {
            get { return final - pagado; }
        }

        private String estado;

        public String Estado
        {
            get
            {
                if (pendiente == 0)
                {
                    return ("PAGADO");
                }
                else
                {
                    return ("Pendiente");
                }
                    ;
            }

        }





    }
}
