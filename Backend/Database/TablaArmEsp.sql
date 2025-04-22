CREATE TABLE IF NOT EXISTS Arm_Esp (
id int(5) NOT NULL,
abreviatura varchar(5) NOT NULL,
arm_esp varchar(35) NOT NULL,
PRIMARY KEY (id));

INSERT INTO Arm_Esp(id, abreviatura, arm_esp) VALUES
("Mec Info", "Mecanico Informatico"),
("Mec Eq Fij", "Mecanico de Equipos Fijos"),
("Mec Eq Camp", "Mecanico de Equipos de Campaña"),
("Mec Rar", "Mecanicos de Radar"),
("Mec Op", "Mecanicos Opticos"),
("Mec Mun Exp", "Mecanico de Municiones y Explosivos"),
("Mec Arm", "Mecanico Armero"),
("Mec A", "Mecanico Artillero"),
("Mec Ing", "Mecanico Ingeniero"),
("Mec Inst", "Mecanico de Instalaciones"),
("Mec Mot Rue", "Mecanico Motrista a Rueda"),
("Mec Mot Oru", "Mecanico Motrista a Oruga"),
("I", "Infanteria"),
("C", "Caballeria"),
("A", "Artilleria"),
("Ing", "Ingeniero"),
("Com", "Comunicaciones"),
("Int", "Intendencia"),
("Enf", "Enfermeria"),
("Mus", "Musico"),
("Cond Mot", "Conductor Motorista"),
("Of", "Oficinista");