using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeProductos
{
    public partial class FormChooseDel : Form
    {
        public string Producto { get; set; }
        public string Codigo { get; set; }
        public int selRow { get; set; }
        public FormChooseDel()
        {
            InitializeComponent();
            listArticulos.MultiColumn = true;
            selRow = -1;
        }
        
        public void MuestraLista()
        {
            
            listArticulos.Items.Add(Codigo + "  |  " + Producto);
            
        }

        private void listArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listArticulos.GetSelected();
            selRow = listArticulos.SelectedIndex;
            //label1.Text = (string) listArticulos.SelectedItem;
            

        }

        private void btnFCDCanc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFCDElim_Click(object sender, EventArgs e)
        {

        }

        
    }
}
