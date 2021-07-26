--INSERT into dbo.Cachorro(Nome,NomeDoDono,TelefoneDoDono) value ('Rex','Jonas','47992697019')

CREATE TABLE dbo.Cachorro(
 idCachorro int not null Identity(1,1),
 Nome VARCHAR(50) not null,
 NomeDoDono VARCHAR(50) not null,
 TelefoneDoDono VARCHAR(16) not null

)