using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace actividad3_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)//ESTE CODIGO MUESTRA LA TABLA PERO SIN CLASE
        {
            string nombre = textBox1.Text;
            string id = textBox2.Text;
            string sql = $@"
            SELECT UserID, UserName ,Email
            FROM Usuarios 
            WHERE UserID <= 3 AND UserName = '{nombre}' AND UserID = '{id}'";//USUARIOS MENORES O IGUALES A 3

            // selec * from la tabla pasa toda la tabla 
            // si le pongo ProductID AS CODIGO se le cambia el nombre de la columna ID
            string cadena = "Data Source=Parejas.db";
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(sql, cadena);//crea el adaptador se le pasa la base de datos y la ruta
            DataTable Tabla = new DataTable();
            adaptador.Fill(Tabla);
            dataGridView1.DataSource = Tabla;
        }

        private void button2_Click(object sender, EventArgs e)//ESTE CODIGO MUESTRA LA TABLA PERO CON  CLASE
        {
            // Crear una instancia de la clase 'problema' para manejar la lógica de la base de datos
            problema p = new problema();

            // Consulta SQL para obtener los datos específicos de la tabla Usuarios
            string sql = @"
            SELECT UserID, UserName, Email
            FROM Usuarios";

            // Obtener los datos de la base de datos utilizando el método GetTabla de la clase 'problema'
            DataTable tablaUsuarios = p.GetTabla(sql);

            // Asignar los datos obtenidos al control DataGridView para visualización en la interfaz de usuario
            dataGridView1.DataSource = tablaUsuarios;



        }

        private void button3_Click(object sender, EventArgs e)//ESTE CODIGO BORRA
        {
            dataGridView1.DataSource = null; // Establecer DataSource como null
            dataGridView1.Rows.Clear(); // Limpiar las filas del DataGridView
            dataGridView1.Columns.Clear(); // Limpiar las columnas del DataGridView
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            

            

        }
    } 
}
