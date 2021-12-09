CREATE TABLE work.worker (
  idWorker INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  lastname VARCHAR(255) NOT NULL,
  idFirm int null,
  foreign key (idFirm) references firm(idFirm),
  PRIMARY KEY (idWorker));

CREATE TABLE work.firm (
  idFirm INT NOT NULL AUTO_INCREMENT,
  nameFirm VARCHAR(255) NOT NULL,
  PRIMARY KEY (idFirm));