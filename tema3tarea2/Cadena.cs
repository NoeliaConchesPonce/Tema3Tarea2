using System;
using System.Collections.Generic;
using System.Text;

namespace tema3tarea2

{
    /// <summary>
    /// Habilitamos la clase Cadena.cs
    /// </summary>
    public class Cadena
    {
        

        #region Atributos
        public string cadena = "hola";
        
        #endregion

        #region Contructor
        public Cadena(string cad)
        {
            cadena = cad;


        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo para sacar la primera letra de un string
        /// </summary>
        /// <param name="cad">parametro con la cadena ver</param>
        /// <returns>Devuelve la primera letra del string</returns>
        public string ExtraerPrimer(string cad)
        {
            return cad.Substring(0,1);
        }


        /// <summary>
        /// Metodo para sacar la ultima letra de un string
        /// </summary>
        /// <param name="cad">parametro con la cadena ver</param>
        /// <returns>Devuelve la primera letra del string</returns>
        public string ExtraerUltimo(string cad)
        {
            return cad.Substring(cad.Length - 1, 1);
        }


        /// <summary>
        /// Metodo para sacar una letra de un string pasada por parametro al metodo
        /// </summary>
        /// <param name="cad">parametro con la cadena ver</param>
        /// <param name="num"></param>
        /// <returns>Devuelve la letra equivalente al numero pasado por parametro</returns>
        public string ExtraerCualquier(string cad)
        {
            return cad.Substring(3,1);

        }
        #endregion
    }
}
