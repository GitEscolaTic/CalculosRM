using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
  /// <summary>
  /// Implementa operações aritméticas
  /// </summary>
    internal static class Aritmetica
    {    
        /// <summary>
        /// Operação Soma
        /// </summary>

        /// <returns>Retorna a soma de 2 números</returns>
        public static int somar(int x, int y)
        { 
            return x + y;
        }
        {/// <summary>
    /// Operação Subtrair
    /// </summary>
    
    /// <returns>Retorna a diferença de 2 números</returns>
        public static int subtrair(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Operação de multiplicação.
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de dois números.</returns>
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
    }
}
