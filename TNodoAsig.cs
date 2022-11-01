using System;

namespace ListaDE
{
    struct nodoAsig
    {
        public string nomb;
        public int cantHrs;
    }
    class TNodoAsig : TDobleNodo
    {
        public nodoAsig info;
        public TNodoAsig(string nom, int ch) : base()
        {
            info.nomb = nom;
            info.cantHrs = ch;
        }

        public string dameAsig()
        {
            return info.nomb;
        }

        public int dameHoras()
        {
            return info.cantHrs;
        }
    }

    class TLisAsig : TLista
    {
        public TLisAsig() : base() { }

        public void crearListaFinal(string a, int hr)
        {
            insertarfinal(new TNodoAsig(a, hr));
        }
        public void crearListaMedio(string a, int hr, int posicion)
        {
            insertarMedio(new TNodoAsig(a, hr), posicion);
        }
        public void crearListaInicio(string a, int hr)
        {
            insertarinicio(new TNodoAsig(a, hr));
        }
        public string mostraLista()
        {
            return mostrar();
        }
        public TDobleNodo sucessor()
        {
            return getProxCursor();
        }

        public TDobleNodo antecessor(string a)
        {
            return getAntCursor();
        }

        public bool eliminarLista(String a)
        {
            eliminar();
            return true;
        }
        public bool BuscarAsig(String nom)
        {
            bool bus = false;
            TDobleNodo p;
            p = primero;
            while (p != null && bus == false)
            {
                if (((TNodoAsig)p).dameAsig().Equals(nom))
                    bus = true;
                else
                    p = p.pEnlace;
            }
            if (bus)
                cursor = p;
            return bus;
        }
    }
}
