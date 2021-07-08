using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeProductos {

    public partial class pSideMenu : Form
    {
        private int cursor = 0;
        public pSideMenu()
        {
            InitializeComponent();
            SubMenus();

        }

        private void SubMenus()
        {
            AddSubMenu.Visible = false;
            ModSubMenu.Visible = false;
            DelSubMenu.Visible = false;
            otrosSubMenu.Visible = false;
            //..
        }
        private void HideSubMenu()
        {
            if (AddSubMenu.Visible == true)
                AddSubMenu.Visible = false;
            if (ModSubMenu.Visible == true)
                ModSubMenu.Visible = false;
            if (DelSubMenu.Visible == true)
                DelSubMenu.Visible = false;
            if (otrosSubMenu.Visible == true)
                otrosSubMenu.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu(); //Por si hay algún otro sub-menú abierto
                subMenu.Visible = true;
            }
            else //Si ya estaba abierto, se cierra
            {
                subMenu.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Al seleccionar una fila, tomaremos la tomaremos como íncide, para poder hacer operaciones con dicha fila:
            cursor = e.RowIndex;
            infoCursor.Text = (cursor + 1).ToString();

            if (e.ColumnIndex == 8) //borrar la fila a la que pertenece el botón
            {

                try
                {
                    dataGridView1.Rows.RemoveAt(cursor);
                    MessageBox.Show((e.RowIndex + 1) + "  Fila ha sido eliminada con éxito. ");
                }
                catch (System.InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.ColumnIndex == 7) //Modificar la fila a la que pertenece el botón
            {
                FormModalMod nVentana = new FormModalMod();
                nVentana.modTitle.Text = "Modificando fila " + (e.RowIndex + 1);
                modificaFila(nVentana);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            FormModal nVentana = new FormModal();
            nVentana.SetTittle("Añadir Producto");
            if (nVentana.ShowDialog() == DialogResult.OK)
            {

                dataGridView1.Rows.Add(nVentana.Producto, nVentana.Codigo, nVentana.Cantidad, nVentana.Precio, nVentana.Desc, nVentana.Tipo, nVentana.newImage);
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {

            if (cursor > -1)
            {
                FormModalMod nVentana = new FormModalMod();
                nVentana.modTitle.Text = "Modificando fila " + (cursor + 1);

                modificaFila(nVentana);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (cursor >= 0)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(cursor);
                    MessageBox.Show((cursor + 1) + "  Fila ha sido eliminada con éxito. ");
                }
                catch (System.InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //MÉTODO necesario para modificar una fila, usado en todos los botones que modifican:
        private void modificaFila(FormModalMod nVentana)
        {
            try
            {
                // if: Precio puede devolver null y el control ordinario de la excep. no funciona
                if (dataGridView1.Rows[cursor].Cells[3].Value != null)
                {
                    //Para Mostrar al usuario los datos actuales antes de cambiarlo:
                    nVentana.Producto = (string)dataGridView1.Rows[cursor].Cells[0].Value;
                    nVentana.Codigo = (string)dataGridView1.Rows[cursor].Cells[1].Value;
                    nVentana.Cantidad = (int)dataGridView1.Rows[cursor].Cells[2].Value;
                    nVentana.Precio = (double)dataGridView1.Rows[cursor].Cells[3].Value; //Devuelve null??
                    nVentana.Desc = (string)dataGridView1.Rows[cursor].Cells[4].Value;
                    nVentana.Tipo = (string)dataGridView1.Rows[cursor].Cells[5].Value;
                    nVentana.Img = (Image)dataGridView1.Rows[cursor].Cells[6].Value;
                    nVentana.setPropierties();
                }
                else
                {// Lanza la excepción manualmente:
                    throw new Exception();
                }
                if (nVentana.ShowDialog() == DialogResult.OK)
                {
                    //Para recoger los nuevos datos:
                    dataGridView1.Rows[cursor].Cells[0].Value = nVentana.Producto;
                    dataGridView1.Rows[cursor].Cells[1].Value = nVentana.Codigo;
                    dataGridView1.Rows[cursor].Cells[2].Value = nVentana.Cantidad;
                    dataGridView1.Rows[cursor].Cells[3].Value = nVentana.Precio;
                    dataGridView1.Rows[cursor].Cells[4].Value = nVentana.Desc;
                    dataGridView1.Rows[cursor].Cells[5].Value = nVentana.Tipo;
                    dataGridView1.Rows[cursor].Cells[6].Value = nVentana.Img;
                    MessageBox.Show((cursor + 1) + "  Fila ha sido modificada con éxito. ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona una fila apta \n" + ex.Message);
            }
        }

        // MÉTODOS que abren sus correspondientes submenus en el menú:
        #region Despliegue de sub-menús
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ShowSubMenu(AddSubMenu);
        }
        private void btnModificaciones_Click(object sender, EventArgs e)
        {
            ShowSubMenu(ModSubMenu);
        }
        private void btnEliminaciones_Click(object sender, EventArgs e)
        {
            ShowSubMenu(DelSubMenu);
        }
        private void btnOtros_Click(object sender, EventArgs e)
        {
            ShowSubMenu(otrosSubMenu);
        }

        #endregion

        private void btnSubAdd1_Click(object sender, EventArgs e)
        {
            FormModal nVentana = new FormModal();
            nVentana.SetTittle("Añadir Producto");
            if (nVentana.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(nVentana.Producto, nVentana.Codigo, nVentana.Cantidad, nVentana.Precio, nVentana.Desc, nVentana.Tipo);
            }
            HideSubMenu();
        }

        private void btnSubAdd2_Click(object sender, EventArgs e)
        {

            HideSubMenu();
        }

        // METODO click del primer botón de modificar fila en el submenu (modificación pre-selección):
        private void btnSubMod1_Click(object sender, EventArgs e)
        {
            if (cursor > -1)
            {
                FormModalMod nVentana = new FormModalMod();
                nVentana.modTitle.Text = "Modificando fila " + (cursor + 1);

                modificaFila(nVentana);
            }
            HideSubMenu();
        }

        // METODO de click del segundo botón de modificar fila en el submenu (modificación post-selección):
        private void btnSubMod2_Click(object sender, EventArgs e)
        {
            FormChooseDel nForm = new FormChooseDel();
            nForm.tittle.Text = "Selecciona un producto para modificar:";
            nForm.btnFCDElim.Text = "Modificar los datos";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                nForm.Producto = (string)dataGridView1.Rows[i].Cells[0].Value;
                nForm.Codigo = (string)dataGridView1.Rows[i].Cells[1].Value;
                nForm.MuestraLista();
            }


            if (nForm.ShowDialog() == DialogResult.OK)
            {
                FormModalMod nFormMod = new FormModalMod();
                cursor = nForm.selRow; /*Para llamar al sigueinte método el cursor debe de estar en la fila que se 
                 ha seleccionado en el FormChooseDel.*/
                modificaFila(nFormMod);

            }
            else
            {
                HideSubMenu();
            }

        }

        // METODO click del primer botón de eliminar filas en el submenu (eliminación pre-selección):
        private void btnSubDel1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(cursor);
                MessageBox.Show((cursor + 1) + "  Fila ha sido eliminada con éxito. ");
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideSubMenu();
        }

        // METODO click del segundo botón de eliminar filas en el submenu (eliminación post-selección):
        private void btnSubDel2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                FormChooseDel nForm = new FormChooseDel();
                // Le pasamos al formulario el código y nombre de cada fila que tengamos:
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    nForm.Producto = (string)dataGridView1.Rows[i].Cells[0].Value;
                    nForm.Codigo = (string)dataGridView1.Rows[i].Cells[1].Value;
                    nForm.MuestraLista();
                }


                if (nForm.ShowDialog() == DialogResult.OK)
                {
                    if (nForm.selRow >= 0)
                    {
                        dataGridView1.Rows.RemoveAt(nForm.selRow);
                        MessageBox.Show((nForm.selRow + 1) + "  Fila ha sido eliminada con éxito. ");
                    }
                    


                }
                else
                {
                    HideSubMenu();
                }
            }
            else
            {
                MessageBox.Show(" No hay datos que borrar ");
            }
            

        }

        //Salida formal de la app por btnExit:
        private void btnExit_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            DialogResult dialog = MessageBox.Show("¿Seguro que quieres salir de la aplicación?",
                "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                Application.Exit();


        }
        //MÉTODO click para exportar los datos a un fichero .csv
        private void button11_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) //Si hay info en las tablas
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Productos.csv";
                bool error = false;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName)) //Si ya existe un archivo con ese nombre, lo sobreescrivimos
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            error = true;
                            MessageBox.Show("No ha sido posible crear el archivo");
                        }
                    }
                    if (!error)
                    {
                        try
                        {
                            int colCount = dataGridView1.Columns.Count;
                            string colNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count];

                            for (int i = 0; i < colCount - 3; i++) // -2, pues las dos últimas son de botones
                            {
                                //Coge los nombres de las columnas en una sola valiable
                                colNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += colNames;

                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count - 1; i++) //Bucle fila (-1, pues la útlima está en blanco)
                            {
                                for (int j = 0; j < colCount - 3; j++) //Bucle columna
                                {
                                    //Cada posición del array tendra la fila completa, separada por , 
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    MessageBox.Show("Primera parte completada" + outputCsv[i]);
                                }
                            }
                            MessageBox.Show("Primera parte completada" + outputCsv[0]);
                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Datos exportados exitosamente");
                        }
                        catch (Exception ex)
                        { //Referencia a objeto no establecida como instancia de un objeto
                            MessageBox.Show("Error 1 : " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tabla vacia, añada productos primero");
            }
        }

        //MÉTODO click para importar datos al DataGridView desde un fichero .csv
        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1) //Si  hay info en las tablas
            { //He decidido sustituir los datos, y no añadirlos a los ya existentes
                dataGridView1.Rows.Clear();
            }

            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var lector = new StreamReader(sfd.FileName))
                {
                    /*El siguente if es para no reflejar los nombres de las columnas como datos en el DGV, pues la
                     * exportación de esta app escribe dichos títulos como la primera fila: */
                    if (!lector.EndOfStream)
                    {
                        var colNames = lector.ReadLine(); 
                    }
                    while (!lector.EndOfStream)
                    {
                        var line = lector.ReadLine();
                        string[] values = line.Split(',');
                        //Falta la 7ª columna, que es la imagen:
                        dataGridView1.Rows.Add(values[0], values[1], Int32.Parse(values[2]), Double.Parse(values[3]), values[4], values[5]);
                        
                    }
                }
            }
        }
    }
}
