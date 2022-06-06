using System;

namespace ListaDE
{
    class TDobleNodo
    {
        public TDobleNodo pEnlace;
        public TDobleNodo qEnlace;


        public TDobleNodo()
        {
            pEnlace = null;
            qEnlace = null;
        }
    }

    class TLista
    {

        public TDobleNodo primero;
        public TDobleNodo ultimo;
        public TDobleNodo cursor;
        public TDobleNodo nuevo;



        public TLista()
        {
            primero = null;
            ultimo = null;
            cursor = null;
            //nuevo = null;
        }

        public void inicializar()
        {
            primero = null;
            ultimo = null;
            cursor = null;
            //nuevo = null;
        }


        public bool vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }
        public void insertar(TDobleNodo nodo)
        {
            if (vacia())
            {
                primero = nodo;
                ultimo = nodo;
                cursor = nodo;
                //nuevo = nodo;
            }


            else
            {
                ultimo.pEnlace = nodo;
                //nuevo.qEnlace = nodo;
                //nuevo.qEnlace = ultimo;
                ultimo = nodo;
                cursor = nodo;
            }
            //nuevo = null;
            nodo.pEnlace = null;
            //nodo.qEnlace = null;
        }

        public TDobleNodo eliminarprimero()
        {
            if (vacia())
                return null;
            else
            {
                if (primero == ultimo)
                    inicializar();
                else
                {
                    if (cursor == primero)
                    {
                        cursor = getProxCursor();
                        primero = primero.pEnlace;

                    }
                }
                return primero;
            }

        }

        public TDobleNodo eliminar()
        {
            TDobleNodo pTemp;
            if (cursor == null)
                return null;
            else
            {
                if (cursor == primero)
                    return eliminarprimero();
                else
                {
                    pTemp = getAntCursor();
                    pTemp.pEnlace = cursor.pEnlace;
                    if (cursor == ultimo)
                        ultimo = pTemp;
                    cursor = pTemp.pEnlace;
                    return cursor;
                }
            }
        }


        public TDobleNodo getPrimero()
        {
            return primero;
        }

        public TDobleNodo getUltimo()
        {
            return ultimo;
        }

        public TDobleNodo getCursor()
        {
            return cursor;
        }
        public TDobleNodo getProxCursor()
        {
            if (cursor != null)
                return cursor.pEnlace;
            else
                return null;

        }
        public TDobleNodo getAntCursor()
        {
            TDobleNodo pTemp;

            if ((cursor != null) && (cursor != primero))
            {
                pTemp = primero;
                while (pTemp.pEnlace != cursor)
                    pTemp = pTemp.pEnlace;
                return pTemp;
            }
            else
                return null;

        }

        public void setCursor(TDobleNodo p)
        {
            cursor = p;
        }

    }
}
