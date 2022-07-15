CREATE TABLE if not EXISTS `pessoa` (
   `Id` BIGINT (20) not null AUTO_INCREMENT,
   `Endereco` VARCHAR (100) NOT NULL,
   `Nome` VARCHAR (100) NOT NULL,
   `SobreNome` VARCHAR (100) NOT NULL,
   `Genero` VARCHAR (100) NOT NULL,
    PRIMARY KEY (`Id`)
)