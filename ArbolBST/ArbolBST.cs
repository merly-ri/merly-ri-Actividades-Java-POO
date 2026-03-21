public class ArbolBST
{
    public Nodo? Raiz;

    // INSERTAR
    public void Insertar(int valor)
    {
        Raiz = InsertarRec(Raiz, valor);
    }

    private Nodo InsertarRec(Nodo? raiz, int valor)
    {
        if (raiz == null)
            return new Nodo(valor);

        if (valor < raiz.Valor)
            raiz.Izquierdo = InsertarRec(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = InsertarRec(raiz.Derecho, valor);

        return raiz;
    }

    // BUSCAR
    public bool Buscar(int valor)
    {
        return BuscarRec(Raiz, valor);
    }

    private bool BuscarRec(Nodo? raiz, int valor)
    {
        if (raiz == null) return false;
        if (raiz.Valor == valor) return true;

        if (valor < raiz.Valor)
            return BuscarRec(raiz.Izquierdo, valor);
        else
            return BuscarRec(raiz.Derecho, valor);
    }

    // ELIMINAR
    public void Eliminar(int valor)
    {
        Raiz = EliminarRec(Raiz, valor);
    }

    private Nodo? EliminarRec(Nodo? raiz, int valor)
    {
        if (raiz == null) return raiz;

        if (valor < raiz.Valor)
            raiz.Izquierdo = EliminarRec(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = EliminarRec(raiz.Derecho, valor);
        else
        {
            // Nodo con un hijo o ninguno
            if (raiz.Izquierdo == null) return raiz.Derecho;
            else if (raiz.Derecho == null) return raiz.Izquierdo;

            // Nodo con dos hijos
            raiz.Valor = Minimo(raiz.Derecho);
            raiz.Derecho = EliminarRec(raiz.Derecho, raiz.Valor);
        }

        return raiz;
    }

    // MINIMO
    public int Minimo(Nodo? raiz)
    {
        while (raiz!.Izquierdo != null)
            raiz = raiz.Izquierdo;
        return raiz.Valor;
    }

    // MAXIMO
    public int Maximo(Nodo? raiz)
    {
        while (raiz!.Derecho != null)
            raiz = raiz.Derecho;
        return raiz.Valor;
    }

    // ALTURA
    public int Altura(Nodo? raiz)
    {
        if (raiz == null) return 0;

        int izq = Altura(raiz.Izquierdo);
        int der = Altura(raiz.Derecho);

        return Math.Max(izq, der) + 1;
    }

    // LIMPIAR
    public void Limpiar()
    {
        Raiz = null;
    }

    // RECORRIDOS
    public void Preorden(Nodo? raiz)
    {
        if (raiz != null)
        {
            Console.Write(raiz.Valor + " ");
            Preorden(raiz.Izquierdo);
            Preorden(raiz.Derecho);
        }
    }

    public void Inorden(Nodo? raiz)
    {
        if (raiz != null)
        {
            Inorden(raiz.Izquierdo);
            Console.Write(raiz.Valor + " ");
            Inorden(raiz.Derecho);
        }
    }

    public void Postorden(Nodo? raiz)
    {
        if (raiz != null)
        {
            Postorden(raiz.Izquierdo);
            Postorden(raiz.Derecho);
            Console.Write(raiz.Valor + " ");
        }
    }
}