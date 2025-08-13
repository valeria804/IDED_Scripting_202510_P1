using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        private static bool EsPrimo(uint num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (uint i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        internal static uint StackFirstPrime(Stack<uint> stack)
        {
            foreach (var item in stack)
            {
                if (EsPrimo(item))
                    return item;
            }
            return 0;
        }

        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            Stack<uint> temp = new Stack<uint>();
            bool eliminado = false;

            while (stack.Count > 0)
            {
                uint actual = stack.Pop();
                if (!eliminado && EsPrimo(actual))
                {
                    eliminado = true;
                }
                else
                {
                    temp.Push(actual);
                }
            }

            Stack<uint> resultado = new Stack<uint>();
            while (temp.Count > 0)
            {
                resultado.Push(temp.Pop());
            }

            return resultado;
        }

        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            Queue<uint> cola = new Queue<uint>();
            foreach (var item in stack)
            {
                cola.Enqueue(item);
            }
            return cola;
        }

        internal static List<uint> StackToList(Stack<uint> stack)
        {
            List<uint> lista = new List<uint>();
            foreach (var item in stack)
            {
                lista.Add(item);
            }
            return lista;
        }

        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            foreach (var item in list)
            {
                if (item == value) return true;
            }
            return false;
        }
    }
}