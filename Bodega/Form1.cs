using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instancia de la clase bodega
            Bodega bodega = new Bodega();

            //creamos un objeto
            bodega.set_bodegaId(1);
            bodega.set_nombre("seguridad en SGDB");
            bodega.set_ubicacion("seguridad de los datos");


            //mostrar los datos de bodega
            /* MessageBox.Show(
                 "Datos de Bodega: " +
                 "ID:" + bodega.get_bodegaId() +
                 "nombre:" + bodega.get_nombre() +
                 "ubicacion: " + bodega.get_ubicacion()
                 );*/


        }

        private void btn_Click(object sender, EventArgs e)
        {
            //Instancia de la clase utilizando constructores 

            //Utilizando constructor vacio 
            Bodega bodega = new Bodega();
            bodega.set_bodegaId (Convert.ToInt32(txtbodegaId.Text));
            bodega.set_nombre(txtnombre.Text);
            bodega.set_ubicacion(txtubicacion.Text);

            //Constructor que inicializa todas las propiedades
            Bodega bodegaI = new Bodega(Convert.ToInt32(txtbodegaId.Text),
                txtnombre.Text, txtubicacion.Text);


            //agregar los datos a listbox
            lstBodegaInfo.Items.Add("Mediante constructor vacío: " + bodega.getBodegaInfo());
            lstBodegaInfo.Items.Add("Mediante constructor inicializando las propiedades: " + bodegaI.getBodegaInfo());
        }
    }
}
   