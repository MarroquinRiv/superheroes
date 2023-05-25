using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superheroes.clases
{
    internal class superheroeDB
    {
        public readonly string cadenaConexion = "Data Source=c:\\tmp\\superheroeDB.db";
        private readonly SQLiteConnection conexion;

        public superheroeDB()
        {
            conexion = new SQLiteConnection(cadenaConexion);
        }

        public void crearTablaHeroe()
        {
            try
            {
                conexion.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS SuperHeroe (id INTEGER PRIMARY KEY AUTOINCREMENT, nombre VARCHAR(20), 
            fuerza INTEGER, agilidad INTEGER)";
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
                Console.WriteLine("Tabla Superheroe creada correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la tabla superheroe: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void insertarHeroe(Isuperheroe heroe)
        {
            try
            {
                conexion.Open();
                string sql = "INSERT INTO SuperHeroe (nombre, fuerza, agilidad) VALUES ('" + heroe.Nombre + "', " + heroe.fuerza + ", " + heroe.agilidad + ")";
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
                Console.WriteLine("SuperHeroe insertado correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el SuperHeroe: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
