using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeProductos {
    public partial class FormModal : Form {

        public String Producto { get; set; } //Propiedades empiezan por mayúscula
        public String Codigo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public String Desc { get; set; }
        public String Tipo { get; set; }
        public Image newImage { get; set; }
        public bool validacion { get; set; }

        public FormModal() {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, EventArgs e) {
                      
            try {
                Producto = tBAdd.Text;
                Codigo = tBAdd2.Text;
                Cantidad = Convert.ToInt16(tBAdd3.Text);
                if (tBAdd4.Text == "") //Si no hay nada, como no es un campo obligatorio pondrá 0
                    Precio = 0;
                else
                    Precio = Convert.ToDouble(tBAdd4.Text);
                Desc = tBAdd5.Text;
                Tipo = tBAdd6.Text;
                if (Codigo == "" || Producto == "") //No cerrará hasta que se rellenen los campos obligatorios
                    MessageBox.Show("Campos obligatorios", "Rellene los campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                else
                    DialogResult = DialogResult.OK;

            } catch (System.FormatException) {
                   
                MessageBox.Show("Valor incorrecto", "Precio debe ser númerico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
            }   

        }
        
        public void SetTittle(String t) {
            Tittle.Text = t;

        }

        private void tBAdd6_TextChanged(object sender, EventArgs e) {

        }

        private void btLoadImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Abrir imagen";
                dlg.Filter = "bmp files (*.bmp)|*.bmp| png files(*.png) | *.png|jpg files (*.jpg)|*.jpg " +
                    "| jpeg files (*.jpeg)|*.jpeg"; 

                if (dlg.ShowDialog() == DialogResult.OK)
                {                   
                    newImage = Image.FromFile(dlg.FileName);
                }
            }
        }
    }
}
