class Program
{
    static void Main()
    {
        ArbolBST arbol = new ArbolBST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n--- MENÚ ÁRBOL BST ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Recorridos");
            Console.WriteLine("5. Mínimo, Máximo y Altura");
            Console.WriteLine("6. Limpiar árbol");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione: ");

            opcion = int.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    valor = int.Parse(Console.ReadLine()!);
                    arbol.Insertar(valor);
                    Console.WriteLine("Insertado correctamente");
                    break;

                case 2:
                    Console.Write("Valor a buscar: ");
                    valor = int.Parse(Console.ReadLine()!);
                    Console.WriteLine(arbol.Buscar(valor) ? "Sí existe" : "No existe");
                    break;

                case 3:
                    Console.Write("Valor a eliminar: ");
                    valor = int.Parse(Console.ReadLine()!);
                    arbol.Eliminar(valor);
                    Console.WriteLine("Eliminado");
                    break;

                case 4:
                    Console.WriteLine("Preorden:");
                    arbol.Preorden(arbol.Raiz);
                    Console.WriteLine("\nInorden:");
                    arbol.Inorden(arbol.Raiz);
                    Console.WriteLine("\nPostorden:");
                    arbol.Postorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 5:
                    if (arbol.Raiz != null)
                    {
                        Console.WriteLine("Mínimo: " + arbol.Minimo(arbol.Raiz));
                        Console.WriteLine("Máximo: " + arbol.Maximo(arbol.Raiz));
                        Console.WriteLine("Altura: " + arbol.Altura(arbol.Raiz));
                    }
                    else
                    {
                        Console.WriteLine("El árbol está vacío");
                    }
                    break;

                case 6:
                    arbol.Limpiar();
                    Console.WriteLine("Árbol limpiado");
                    break;

            }

        } while (opcion != 7);
    }
}