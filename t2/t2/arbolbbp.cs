using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    internal class arbolbbp
    {
        public nodop Primero;

        public arbolbbp()
        {
            Primero = null;
        }

        public void Agrega(empleado empleado)
        {
            nodop nuevo = new nodop(empleado);

            if (Primero == null)
            {
                Primero = nuevo;
                return;
            }

            nodop actual = Primero;

            while (true)
            {
                if (empleado.Codigo < actual.Valor.Codigo)
                {
                    if (actual.Izqu == null)
                    {
                        actual.Izqu = nuevo;
                        return;
                    }

                    actual = actual.Izqu;
                }
                else
                {
                    if (actual.Dere == null)
                    {
                        actual.Dere = nuevo;
                        return;
                    }

                    actual = actual.Dere;
                }
            }
        }

        public void MuestraInCodigo()
        {
            Console.WriteLine("\nLISTADO INORDEN POR CODIGO");
            InOrden(Primero);
        }

        private void InOrden(nodop nodo)
        {
            if (nodo != null)
            {
                InOrden(nodo.Izqu);
                Console.WriteLine(nodo.Valor);
                InOrden(nodo.Dere);
            }
        }

        public void MuestraPosAntiguedad()
        {
            Console.WriteLine("\nLISTADO POSORDEN");
            PosOrden(Primero);
        }

        private void PosOrden(nodop nodo)
        {
            if (nodo != null)
            {
                PosOrden(nodo.Izqu);
                PosOrden(nodo.Dere);
                Console.WriteLine(nodo.Valor);
            }
        }
        public int MayoresA(int antiguedad)
        {
            return ContarMayores(Primero, antiguedad);
        }

        private int ContarMayores(nodop nodo, int antiguedad)
        {
            if (nodo == null)
                return 0;

            int contador = 0;

            if (nodo.Valor.Antiguedad > antiguedad)
                contador++;

            contador += ContarMayores(nodo.Izqu, antiguedad);
            contador += ContarMayores(nodo.Dere, antiguedad);

            return contador;
        }
        public string Penultimo()
        {
            if (Primero == null)
                return "El árbol está vacío.";

            if (Primero.Dere == null)
                return "No existe penúltimo.";

            nodop actual = Primero;
            nodop anterior = null;

            while (actual.Dere != null)
            {
                anterior = actual;
                actual = actual.Dere;
            }

            return anterior.Valor.ToString();
        }

    }
}
