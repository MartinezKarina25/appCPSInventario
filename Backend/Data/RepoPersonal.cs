using Backend.Models;
using MySql.Data.MySqlClient;


namespace Backend.Data
{
    public class RepoPersonal : DB_Conexion
    {
        public List<Personal> Mostrar()
        {
            List<Personal> personal = new List<Personal>();
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("SELECT dni, id_grado, arm_esp, apellido, nombre, segundo_nombre, destino, email FROM personal", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personal.Add(new Personal
                            {
                                _dni = reader.GetInt32("dni"),
                                _idGrado = reader.GetInt32("id_grado"),
                                _idArmEsp = reader.GetString("arm_esp"),
                                _apellido = reader.GetString("apellido"),
                                _nombre = reader.GetString("nombre"),
                                _sNombre = reader.GetString("segundo_nombre"),
                                _destino = reader.GetString("destino"),
                                _email = reader.GetString("email"),
                            });
                        }
                    }
                }
            }
            return personal;
        }

        public bool Insertar(int dni, int grado, string armEsp, string apellido, string nombre, string sNombre, string destino, string email)
        {
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("INSERT INTO personal (dni, grado, arm_esp, apellido, nombre, segundo_nombre, destino, email) VALUES ('@dni', '@grado', '@arm_esp', '@apellido', '@nombre', '@segundo_nombre', '@destino', '@email') WHERE dni = @dni", connection))
                {
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@grado", grado);
                    command.Parameters.AddWithValue("@arm_esp", armEsp);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@segundo_nombre", sNombre);
                    command.Parameters.AddWithValue("@destino", destino);
                    command.Parameters.AddWithValue("@email", email);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al modificar el personal: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public bool Modificar(int dni, int grado, string armEsp, string apellido, string nombre, string sNombre, string destino, string email)
        {
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("UPDATE personal SET grado = @grado, arm_esp = @arm_esp, apellido = @apellido, nombre = @nombre, segundo_nombre = @segundo_nombre, destino = @destino, email = @email WHERE dni = @dni", connection))
                {
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@grado", grado);
                    command.Parameters.AddWithValue("@arm_esp", armEsp);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@segundo_nombre", sNombre);
                    command.Parameters.AddWithValue("@destino", destino);
                    command.Parameters.AddWithValue("@email", email);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al modificar personal: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public bool Eliminar(int dni)
        {
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("DELETE FROM personal WHERE dni = @dni", connection))
                {
                    command.Parameters.AddWithValue("@dni", dni);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al eliminar el personal: {ex.Message}");
                        return false;
                    }
                }
            }
        }
    }
}