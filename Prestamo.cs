using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion
{
    class Prestamo
    {
        static void Main (String[] args)
        {
            FacturaCancha cancha = new FacturaCancha();
            Console.WriteLine("Ingrese cuál cancha desea usar:" + "futbol,fulbito,indor,basquet");
            string nombre = Console.ReadLine();
            cancha.Cancha = nombre;
            float n = cancha.Costo;
            if (n > 0)
            {
                Console.WriteLine("Ingrese cuantas horas desea usar la cancha");
                float horas = Convert.ToSingle(Console.ReadLine());
                cancha.Hora = horas;
                if (horas <= 3)
                {
                    Console.WriteLine("Ingrese el descuento que desea realizar, 0,1 para 10%, un 0,2 para el 20% ó 0 para no dar descuento");
                    cancha.Descuento = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("La cancha que uso es: {0}", nombre);
                    Console.WriteLine("El costo de la cancha por hora es: {0}", cancha.Costo);
                    Console.WriteLine("Subtotal: {0}", cancha.Subtotal);
                    Console.WriteLine("Subtotal con descuento: {0}", cancha.SubtotalDescuento);
                    Console.WriteLine("Iva: {0}", cancha.Iva);
                    Console.WriteLine("Total facturado: {0}", cancha.Total);
                    Console.WriteLine("Ingrese el pago");
                    cancha.Pagado = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Saldo pendiente: {0}", cancha.SaldoPendiente);
                    Console.WriteLine("Estado: {0}", cancha.Estado);
                }
                else
                { Console.WriteLine("No se puede usar la cancha por más de 3 horas"); }
            }
            if (nombre == "futbol" || nombre == "fulbito" || nombre == "indor" || nombre == "basquet")
            {
            else { Console.WriteLine("No contamos con ese servicio"); }
                Console.ReadKey();
            }
        }
    }
}

        }
    }
}
  public class FacturaCancha
{
    private string cancha;

    public string Cancha
    {
        get { return cancha; }
        set { cancha = value; }
    }

    private float costo;

    public float Costo
    {
        get
        {
            if (this.Cancha == "futbol")
                return 20;
            else if (this.Cancha == "fulbito")
                return 15;
            else if (this.Cancha == "indor")
                return 5;
            else if (this.Cancha == "basquet")
                return 5;
            else
                return 0;
        }
    }

    private float hora;

    public float Hora
    {
        get { return hora; }
        set { hora = value; }
    }

    private float subtotal;

    public float Subtotal
    {
        get { return this.Costo * this.Hora; }
    }

    private float descuento;

    public float Descuento
    {
        get { return descuento; }
        set { descuento = value; }
    }

    private float subtotalDescuento;

    public float SubtotalDescuento
    {
        get { return this.Subtotal * (1 - this.Descuento); }
    }

    private float iva;

    public float Iva
    {
        get { return this.SubtotalDescuento * 0.12f; }
    }
    private float total;

    public float Total
    {
        get { return this.SubtotalDescuento * 1.12f; }
    }

    private float pagado;

    public float Pagado
    {
        get { return pagado; }
        set { pagado = value; }
    }
    private float saldoPendiente;

    public float SaldoPendiente
    {
        get { return this.Total - this.Pagado; }
    }

    private string estado;

    public string Estado
    {
        get
        {
            if ((this.Total - this.Pagado) != 0)
                return "PENDIENTE";
            else
                return "PAGADO";
        }
    }


}

