using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
namespace actividad3_sql
{
    internal class problema
    {
        public DataTable GetTabla(string sql)
        {
            // Este método recibe una consulta SQL como parámetro 'sql'

            DataTable tablaP = new DataTable();
            // Se crea un nuevo objeto DataTable llamado 'tablaP' para almacenar los datos

            SQLiteDataAdapter Adaptador = new SQLiteDataAdapter(sql, "Data Source=Parejas.db");
            // Se crea un objeto SQLiteDataAdapter, que es un puente entre el origen de datos y el objeto DataTable.
            // Se le pasa la consulta SQL 'sql' y la cadena de conexión "Data Source=Parejas.db" que indica el archivo de la base de datos SQLite

            Adaptador.Fill(tablaP);
            // El método Fill de SQLiteDataAdapter llena el DataTable 'tablaP' con los resultados de la consulta SQL ejecutada en la base de datos

            return tablaP;
            // Devuelve el DataTable lleno con los resultados de la consulta
        }


    }
}
