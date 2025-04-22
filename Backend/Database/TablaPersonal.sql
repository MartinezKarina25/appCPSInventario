CREATE TABLE IF NOT EXISTS personal (
  dni int(10) NOT NULL,
  id_grado int(5) NOT NULL,
  id_armesp int(5) NOT NULL,
  apellido varchar(35) NOT NULL,
  nombre varchar(20) NOT NULL,
  segundo_nombre varchar(20),
  destino varchar(20) NOT NULL,
  email varchar(50) NOT NULL,
  PRIMARY KEY (dni));

INSERT INTO  personal (dni, id_grado, id_armesp, apellido, nombre, segundo_nombre, destino, email)
VALUES 
('56789012', '7', '1', 'Martínez','Ana','Maria', 'B Com 602', 'ana.martinez@tudominio.com'),
('78901234', '18', '1', 'Fernández', 'Luis','Alberto', 'B Com 602', 'luis.fernandez@tudominio.com'),
('90123456', '1', '1', 'López', 'Sofía', 'Lourdes', 'B Com 602', 'sofia.lopez@tudominio.com'),
('23456789', '12', '1','Sánchez','Diego','Ignacio', 'B Com 602', 'diego.sanchez@tudominio.com'),
('87654321', '4', '1', 'Gómez', 'María','Estela', 'B Com 602', 'mariana.gomez@tudominio.com'),
('34567890', '21', '1', 'Rodríguez','Carlos','Matias', 'B Com 602', 'carlos.rodriguez@tudominio.com'),
('65432109', '22', '1', 'Ramírez','Laura','', 'B Com 602', 'laura.ramirez@tudominio.com'),
('34567812', '9', '1', 'García','Pedro','Lian', 'B Com 602', 'pedro.garcia@tudominio.com'),
('56789034', '15', '1', 'Alvarez', 'Paula','Jimena', 'B Com 602', 'paula.alvarez@tudominio.com');
('12345678', '16', '1', 'Pérez','Juan', 'Gabriel', 'B Com 602', 'juan.perez@tudominio.com'),