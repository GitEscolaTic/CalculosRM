﻿using System;
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
    {    /// <summary>
         /// Tipo de conversão de temperatura a executar.
         /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }


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

        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }

            return -1;
        }
    }
}
