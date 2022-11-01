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


        public TLista()
        {
            primero = null;
            ultimo = null;
            cursor = null;
        }

        public void inicializar()
        {
            primero = null;
            ultimo = null;
            cursor = null;
        }


        public bool vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }
        public void insertarinicio(TDobleNodo nodo)  // Insertar al principio de la lista
        {
            if (vacia())
            {
                primero = nodo;
                ultimo = nodo;
                cursor = nodo;
            }


            else
            {
                primero.qEnlace = nodo;
                nodo.pEnlace = primero;
                cursor = nodo;
                primero = nodo;
            };
            nodo.qEnlace = null;
        }
        public void insertarMedio(TDobleNodo nodo, int posicion)
        {
            if (posicion == 1)
                insertarinicio(nodo);
            else
            {
                int vcont = 2;
                TDobleNodo temp = primero;
                while (vcont < posicion)
                {
                    temp = temp.pEnlace;
                    vcont++;
                }
                nodo.pEnlace = temp.pEnlace;
                nodo.qEnlace = temp;
                temp.pEnlace.qEnlace = nodo;
                temp.pEnlace = nodo;
            }
        }
        public void insertarfinal(TDobleNodo nodo) //Inseratar al final de la lista  
        {
            if (vacia())
            {
                primero = nodo;
                ultimo = nodo;
                cursor = nodo;
            }


            else
            {
                ultimo.pEnlace = nodo;
                nodo.qEnlace = ultimo;
                cursor = nodo;
                ultimo = nodo;
            }
            nodo.pEnlace = null;
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
                        cursor = cursor.pEnlace;
                        primero = primero.pEnlace;
                        primero.qEnlace = null;
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
                    pTemp = cursor.qEnlace;
                    pTemp.pEnlace = cursor.pEnlace;
                    if (cursor == ultimo)
                    {
                        ultimo = pTemp;
                        cursor = pTemp.pEnlace;
                        return cursor;
                    }
                    cursor.pEnlace.qEnlace = pTemp;
                    return cursor;
                }
            }
        }
        public string mostrar()
        {
            string vProducto = "";
            TDobleNodo temp = primero;
            while (temp != null)
            {
                vProducto += temp.ToString() + Environment.NewLine;
                temp = temp.pEnlace;
            }
            return vProducto;
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

            if ((cursor != null) && (cursor != primero))
            {
                return cursor.qEnlace;
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