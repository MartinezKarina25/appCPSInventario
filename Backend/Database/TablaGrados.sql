CREATE TABLE IF NOT EXISTS grados (
id_grado int(5) NOT NULL AUTO_INCREMENT,
abreviatura varchar(5) NOT NULL,
grado varchar(35) NOT NULL,
PRIMARY KEY (id_grado));

INSERT INTO grados(abreviatura, grado) VALUES
("TG", "Teniente General"),
("GD", "General de División"),
("GB", "General de Brigada"),
("CY", "Coronel Mayor"),
("CR", "Coronel"),
("TC", "Teniente Coronel"),
("MY", "Mayor"),
("CT", "Capitán"),
("TP", "Teniente Primero"),
("TT", "Teniente"),
("ST", "Subteniente"),
("SM", "Suboficial Mayor"),
("SP", "Suboficial Principal"),
("SA", "Sargento Ayudante"),
("SI", "Sargento Primero"),
("SG", "Sargento"),
("CI", "Cabo Primero"),
("CB", "Cabo"),
("VP", "Voluntario de Primera"),
("VS", "Voluntario de Segunda"),
("VS ´ec´", "Voluntario de Segunda en Comisión"),
("A/C", "Agente Civil");