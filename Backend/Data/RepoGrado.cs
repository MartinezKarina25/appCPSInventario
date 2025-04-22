using Backend.Models;
using MySql.Data.MySqlClient;


namespace Backend.Data
{
    public class RepoGrado : DB_Conexion
    {
        public List<Grado> Mostrar()
        {
            List<Grado> grado = new List<Grado>();
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("SELECT id_grado, abreviatura, grado FROM grados", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            grado.Add(new Grado
                            {
                                _idGrado = reader.GetInt32("id_grado"),
                                _abreviatura = reader.GetString("abreviatura"),
                                _grado = reader.GetString("grado")
                            });
                        }
                    }
                }
            }
            return grado;
        }

        public bool Insertar(int idGrado, string abreviatura, string grado)
        {
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("INSERT INTO grados (abreviatura, grado) VALUES (@abreviatura, '@grado') WHERE id_grado = @idGrado", connection))
                {
                    command.Parameters.AddWithValue("@idGrado", idGrado);
                    command.Parameters.AddWithValue("@abreviatura", abreviatura);
                    command.Parameters.AddWithValue("@grado", grado);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al modificar grado: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public bool Modificar(int idGrado, string abreviatura, string grado)
        {
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("UPDATE grados SET abreviatura = @abreviatura, grado = @grado WHERE id_grado = @idGrado", connection))
                {
                    command.Parameters.AddWithValue("@idGrado", idGrado);
                    command.Parameters.AddWithValue("@abreviatura", abreviatura);
                    command.Parameters.AddWithValue("@grado", grado);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al modificar grado: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public bool Eliminar(int idGrado)
        {
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("DELETE FROM grados WHERE id_grado = @idGrado", connection))
                {
                    command.Parameters.AddWithValue("@idGrado", idGrado);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al eliminar grado: {ex.Message}");
                        return false;
                    }
                }
            }
        }
    }
}