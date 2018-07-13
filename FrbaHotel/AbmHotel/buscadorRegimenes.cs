using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class buscadorRegimenes : Form
    {
        ListBox list;
        DataTable t;
        altaHotel ventana;
        buscadorRegimenes buscador;
        int regimenesCompletos=0;

        public int GetRegimenesCompletos() {
            return this.regimenesCompletos;
        }
        public void SetRegimenesCompletos(int valor) 
        {
            this.regimenesCompletos = valor;
        }
        
        public buscadorRegimenes()
        {
            InitializeComponent();
        }

        private void buscadorRegimenes_Load(object sender, EventArgs e)
        
       {
           if (list.Items.Count.Equals(0))
           {
               ListBox listBoxRegimenesDisponiblesAux = new ListBox();
               ConexionSQL c = new ConexionSQL();
               t = c.cargarTablaSQL("select regimen_id, descripcion from WHERE_EN_EL_DELETE_FROM.regimenes");

               for (int i = 0; i < t.Rows.Count; i++)
               {
                   listBoxRegimenesDisponiblesAux.Items.Add(t.Rows[i].ItemArray.GetValue(1).ToString());
               }
               for (int i = 0; i < listBoxRegimenesDisponiblesAux.Items.Count; i++)
               {
                   listBoxRegimenesDisponibles.Items.Add(listBoxRegimenesDisponiblesAux.Items[i].ToString());
               }
               //for (int i = 0; i < listBoxRegimenesDisponiblesAux.Items.Count; i++) 
               //{
               //    System.Windows.Forms.MessageBox.Show(listBoxRegimenesDisponiblesAux.Items[i].ToString());
               //}

           }
           else 
           {
               ListBox listBoxRegimenesDisponiblesAux = new ListBox();
               ConexionSQL c = new ConexionSQL();
               string consulta = "select regimen_id, descripcion from WHERE_EN_EL_DELETE_FROM.regimenes where ";
               
               if (list.Items.Count.Equals(1))
               {
                   consulta += "descripcion not like '" + list.Items[0].ToString() + "'";
               }
               else 
               {
                   consulta += "descripcion not like '" + list.Items[0].ToString() + "'";
                   for (int i = 1; i < list.Items.Count; i++)
                   {
                       consulta += " and descripcion not like '" + list.Items[i].ToString() + "'";
                   }
               }
               t = c.cargarTablaSQL(consulta);
               for (int i = 0; i < t.Rows.Count; i++)
               {
                   listBoxRegimenesDisponiblesAux.Items.Add(t.Rows[i].ItemArray.GetValue(1).ToString());
               }
               for (int i = 0; i < listBoxRegimenesDisponiblesAux.Items.Count; i++)
               {
                   listBoxRegimenesDisponibles.Items.Add(listBoxRegimenesDisponiblesAux.Items[i].ToString());
               }
           }

           if (listBoxRegimenesDisponibles.Items.Count.Equals(0)) 
           {
               System.Windows.Forms.MessageBox.Show("No hay más regímenes disponibles para agregarle a este hotel");
               
               this.Hide();
               
           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxRegimenesDisponibles.SelectedIndex == -1) { MessageBox.Show("No hay ningún regimen seleccionado para agregar"); }
            else
            {
                if (listBoxRegimenesDisponibles.Items.Count.Equals(0))
                {
                    System.Windows.Forms.MessageBox.Show("No hay más regímenes para seleccionar");
                }
                else
                {
                    listBoxRegimenesElegidos.Items.Add(listBoxRegimenesDisponibles.Text);
                    if (listBoxRegimenesDisponibles.Text.ToString().Equals("")) { }
                    else
                    {
                        int n = listBoxRegimenesDisponibles.FindString(listBoxRegimenesDisponibles.Text);
                        //t.Rows.RemoveAt(n);
                        listBoxRegimenesDisponibles.Items.RemoveAt(n);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //for (int i=0;i<this.listBoxRegimenesElegidos.Items.Count;i++)
            //{
            //    list.Items.Add(listBoxRegimenesElegidos.Items[i].ToString());
            //    int n = listBoxRegimenesElegidos.FindString(listBoxRegimenesElegidos.Items[i].ToString());
            //    listBoxRegimenesDisponibles.Items.RemoveAt(n);
            //}

            if (this.listBoxRegimenesDisponibles.Items.Count.Equals(0)) { buscador.SetRegimenesCompletos(1); }
            ventana.RecibirListBox(listBoxRegimenesElegidos, buscador.regimenesCompletos);
            
            this.Hide();
            ventana.Show();
        }

    

        internal void Enviarme(ListBox listBox, altaHotel altaHotel, buscadorRegimenes b)
        {
            foreach (var item in listBox.Items) 
            {
                listBoxRegimenesElegidos.Items.Add(item);
            }
            list = listBox;
            ventana = altaHotel;
            buscador = b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxRegimenesElegidos.SelectedIndex == -1)
            {
                MessageBox.Show("No hay regimen elegido para quitar");
            }
            else
            {
                if (listBoxRegimenesElegidos.Items.Count.Equals(0))
                {
                    MessageBox.Show("No hay regímenes para eliminar");
                }
                else
                {
                    listBoxRegimenesDisponibles.Items.Add(listBoxRegimenesElegidos.SelectedItem);
                    listBoxRegimenesElegidos.Items.Remove(listBoxRegimenesElegidos.SelectedItem);
                }
            }
        }
    }
}
