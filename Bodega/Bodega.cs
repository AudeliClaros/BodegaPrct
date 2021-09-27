using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodega
{
    class Bodega
    {

        private int _bodegaId;
        private string _nombre;
        private string _ubicacion;



        //Metodo constructor
        //Metodo vacio 
        public Bodega()
        { }

        public Bodega(int bodegaId, string nombre, string ubicacion)
        {
            _bodegaId = bodegaId;
            _nombre = nombre;
            _ubicacion = ubicacion;

        }

        //bodega 
        public int get_bodegaId()
        {
            return _bodegaId;
        }
        public void set_bodegaId(int bodegaId)
        {
            _bodegaId = bodegaId;
        }

        //nombre de la bodega
        public string get_nombre()
        {
            return _nombre;
        }
        public void set_nombre(string nombre)
        {
            _nombre = nombre;
        }

        //ubicacion de  la bodega
        public string get_ubicacion()
        {
            return _ubicacion;
        }
        public void set_ubicacion(string ubicacion)
        {
            _ubicacion = ubicacion;
        }

        //Metodo para mostrar información del reporte
        public string getBodegaInfo()
        {
            return "ID:   " + _bodegaId + "Nombre:  " + _nombre + "Ubicación:  " + _ubicacion;




        }
    }

}