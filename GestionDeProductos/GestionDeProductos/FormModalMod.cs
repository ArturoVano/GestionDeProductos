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
    public partial class FormModalMod : Form
    {
        public String Producto { get; set; } 
        public String Codigo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public String Desc { get; set; }
        public String Tipo { get; set; }
        public Image Img { get; set; }

        public FormModalMod()
        {
            InitializeComponent();

        }

        public void setPropierties()
        {
            tBMod.Text = Producto;
            tBMod2.Text = Codigo;
            tBMod3.Text = Convert.ToString(Cantidad);
            tBMod4.Text = Convert.ToString(Precio);
            tBMod5.Text = Desc;
            tBMod6.Text = Tipo;
        }
      

        private void btnConfMod_Click(object sender, EventArgs e)
        {   //Codigo de verificación casi idéntico al FormModal de añadir productos:
            try
            {
                Producto = tBMod.Text;
                Codigo = tBMod2.Text;
                Cantidad = Convert.ToInt16(tBMod3.Text);
                if (tBMod4.Text == "") //Si no hay nada, como no es un campo obligatorio pondrá 0
                    Precio = 0;
                else
                    Precio = Convert.ToDouble(tBMod4.Text);
                Desc = tBMod5.Text;
                Tipo = tBMod6.Text;
                if (Codigo == "" || Producto == "") //No cerrará hasta que se rellenen los campos obligatorios
                    MessageBox.Show("Campos obligatorios", "Rellene los campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                    DialogResult = DialogResult.OK;

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Valor incorrecto", "Precio debe ser númerico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancMod_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btLoadImg_Click(object sender, EventArgs e)
        {   
            //using eliminará el objeto una vez el contexto este completo.
            using (OpenFileDialog dlg = new OpenFileDialog()) 
            {
                dlg.Title = "Abrir imagen";
                dlg.Filter = "bmp files (*.bmp)|*.bmp| png files(*.png) | *.png|jpg files (*.jpg)|*.jpg " +
                    "| jpeg files (*.jpeg)|*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Img = Image.FromFile(dlg.FileName);
                }
            }
        }
    }
}
