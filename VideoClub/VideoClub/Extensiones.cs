using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClub
{
    /// <summary>
    /// Clase que contiene las extensiones adicionales que necesito en mi proyecto
    /// </summary>
    public static class Extensiones
    {
        /// <summary>
        /// Este método extiende la clase List de string para devolver una cadena
        /// formateada con el nº de elementos.
        /// </summary>
        /// <param name="fuente"></param>
        /// <returns></returns>
        public static string CantidadElementos(this List<string> fuente)
        {
            int Cantidad = fuente.Count();
            return ("La lista tiene " + Cantidad.ToString() + " elementos.");
        }

        /// <summary>
        /// Esta función sirve para ampliar la funcionalidad de un DataGridView
        /// </summary>
        /// <param name="dgv">Instancia del DataGridView</param>
        /// <returns> Devuelve un DataSet a partir de un DataGridView</returns>
        public static DataSet ObtenerDataSet(this DataGridView dgv)
        {
            var ds = new DataSet();
            var dt = new DataTable();

            foreach (var column in dgv.Columns.Cast<DataGridViewColumn>())
            {
                if (column.Visible)
                {
                    dt.Columns.Add(column.Name);
                }
            }
            var cellValues = new object[dgv.Columns.Count];
            foreach (var row in dgv.Rows.Cast<DataGridViewRow>())
            {
                int pos = 0;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (dgv.Columns[i].Visible) 
                    {
                        cellValues[pos] = row.Cells[i].Value;
                        pos++;
                    }                    
                }
                dt.Rows.Add(cellValues);
            }
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
