using System;

namespace libRetoPalabra
{
    public class clsReto
    {
        //Atributos de la clase Reto
        #region Atributos
        private string sTexto, sTextoOri;
        private string sPalabra;
        private int iConteo;
        private string sMensaje;
        #endregion

        //Metodo constructori
        #region Constructor
        public clsReto() 
        {
            iConteo = 0;
            sTexto = "";
            sPalabra = "";
            sMensaje = "";
        }
        #endregion

        //Acessores de la clase
        #region Propiedades
        public string Texto { set => sTexto = value; }
        public string Palabra { get => sPalabra; set => sPalabra = value; }
        public int Conteo { get => iConteo; }
        public string Mensaje { get => sMensaje; set => sMensaje = value; }
        #endregion


        #region Metodos
        //Metodos encargado de hacer la separación del texto a procesar y de comparar las cadenas de texto obtenidas como resultado de la conversión en array.
        public bool obtenerDatos()
        {
            try
            {
                string[] aTexto;

                transformarDatos();

                aTexto = sTexto.Split(" ");

                foreach (string palabra in aTexto)
                {
                    if (palabra==this.sPalabra)
                    {
                        this.iConteo++;
                    }
                }
                this.Mensaje = "El proceso se ejecutó de manera correcta.";
                return true;
            }
            catch (Exception e)
            {
                this.sMensaje = "Hubo un error al tratar de ejecutar el proceso: " + e.Message;
                return false;
            }
        }

        //Metodo privado encargado de sanear los datos para facilitar las comparaciones
        private void transformarDatos()
        {
            this.sTexto = this.sTexto.Replace(".", "");
            this.sTexto = this.sTexto.Replace(",", "");
            this.sTexto = this.sTexto.Replace(";", "");
            this.sTexto = this.sTexto.ToLower();

            this.sPalabra = this.sPalabra.ToLower();
        }
        #endregion

    }
}
