
use master
go

if exists(Select * FROM SysDataBases WHERE name='Proyecto')
BEGIN
	DROP DATABASE Proyecto
END
go


CREATE DATABASE Proyecto
ON(
	NAME=Proyecto,
	FILENAME='C:\Proyecto.mdf'
)
go

USE Proyecto
go
-----TABLAS
CREATE TABLE Usuarios(
	Ndoc bigint NOT NULL PRIMARY KEY ,
	NomUsuario varchar(20) NOT NULL  ,
	Usuario varchar(20) NOT NULL unique check(len(Usuario)<20),
	Constrase�a varchar(9) not null check(len(Constrase�a) = 9),

	
) 
go
Create Table Lectores
(
	Ndoc bigint Not Null Primary Key Foreign Key References Usuarios(Ndoc),
	Correo varchar(40) Not Null check (Correo like '%@%'),
)
go
Create Table Administradores
(
	Ndoc bigint Not Null Primary Key Foreign Key References Usuarios(Ndoc),
	AprobarLectores bit 
)
go
CREATE TABLE Periodistas(
	NomPeriodista varchar(20) NOT NULL PRIMARY KEY check(len(NomPeriodista)<20) ,
	Nacionalidad varchar(20) NOT NULL check(len(Nacionalidad)<20) ,
	FechaNacimiento Datetime NOT NULL,
	Baja bit not null default 0
	
) 
go
CREATE TABLE Premios(
	NomPeriodista varchar(20) not null Foreign Key References Periodistas(NomPeriodista),
	Premio varchar(50) not null check(len(Premio)<50),
	Primary Key (NomPeriodista, Premio)
	
) 
go
CREATE TABLE Noticias(
	IdNoticia int Not Null Primary Key Identity(1,1),
	Titulo varchar(40) not null check(len(Titulo)<40),
	Resumen varchar(150) not null check(len(Resumen)<150),
	CuerpoNoticia varchar(1500) not null check(len(CuerpoNoticia)<1500),
	FechaHoraCreacion Datetime NOT NULL default getdate(),
	Relevante bit not null,
	Categoria varchar(20) Not Null Check(Categoria ='Economica' OR Categoria ='Internacional' or Categoria='Politica'or Categoria='Policial' ),
	NomPeriodista varchar(20) not null Foreign Key References Periodistas(NomPeriodista),
) 
go
CREATE TABLE Comentarios(
	IdComentario int not null,
	IdNoticia int not null Foreign Key References Noticias(IdNoticia),
	Ndoc bigint not null Foreign Key References Lectores(Ndoc),
	Comentario varchar(100) not null check(len(Comentario)<150)
	primary key(IdComentario,IdNoticia)
) 
----------------------------------------------------------------------
---INGRESAR DATOS
go
insert Periodistas(NomPeriodista,Nacionalidad,FechaNacimiento)values('Periodista1','Uruguayo','02/03/1975')
insert Periodistas(NomPeriodista,Nacionalidad,FechaNacimiento)values('Periodista2','Brasile�o','03/04/1965')
insert Periodistas(NomPeriodista,Nacionalidad,FechaNacimiento)values('Periodista3','Argentino','03/04/1955')
insert Periodistas(NomPeriodista,Nacionalidad,FechaNacimiento)values('Periodista4','Chileno','03/04/1968')

go
insert Premios(NomPeriodista,Premio)values('Periodista1','PremioOro')
insert Premios(NomPeriodista,Premio)values('Periodista1','PremioPlata')
insert Premios(NomPeriodista,Premio)values('Periodista2','PremioDiamante')
insert Premios(NomPeriodista,Premio)values('Periodista2','PremioCobre')
insert Premios(NomPeriodista,Premio)values('Periodista3','PremioBronce')
go

----------------------------------------------------------
insert Noticias(Titulo,Resumen,CuerpoNoticia,Relevante,Categoria,NomPeriodista)
 values ('Aumento provisorio de pasividades',
 'El �ndice Medio de Salarios Nominales registr� una suba acumulada de 10,56% en 11 meses del a�o',
 'Ese es el dato que determina que los jubilados y pensionistas tendr�n un aumento de 10,56% a partir de enero, con un posterior ajuste en febrero cuando se conozca el IMSN de cierre de 2015.
El primer incremento de jubilaciones y pasividades, entonces, se cobrar� los primeros d�as de febrero y la reliquidaci�n de la diferencia se percibir� con el cobro de la prestaci�n en marzo.
Con esto se completar�n 12 a�os en los que las jubilaciones y pensiones aumentan m�s que la inflaci�n (que se estima cerrar� en 8%), un registro sin precedentes.'
,1,'Economica','Periodista1')
--------------------------------------------------------
insert Noticias(Titulo,Resumen,CuerpoNoticia,Relevante,Categoria,NomPeriodista)
 values ('Wall Street y un buen a�o',
 'Wall Street cerr� ayer la �ltima sesi�n del a�o con p�rdidas y el Dow Jones de Industriales, su principal indicador, baj� 0,29%',
 'Al final de las contrataciones de la �ltima jornada de 2016, el Dow Jones baj� 57,18 puntos y termin� en 19.762,60 enteros, el S&P 500 cedi� 10,43 puntos hasta 2.238,83 unidades y el �ndice compuesto del mercado Nasdaq cay� 48,97 puntos 5.383,12 enteros.'
,0,'Economica','Periodista2')
----------------------------------------------------
insert Noticias(Titulo,Resumen,CuerpoNoticia,Relevante,Categoria,NomPeriodista)
 values ('Salario m�nimo aumentar� 10% en 2017',
 'El porcentaje de aumento ya se encuentra establecido para los a�os 2017 y 2018, dejando el salario m�nimo 2017 en $12.265',
 'De cara al comienzo de un nuevo a�o lectivo, una interrogante que muchos uruguayos se plantean es si se concretar� un aumento adicional en el salario m�nimo en Uruguay en 2017. En julio de 2015 el ministro de Econom�a, Danilo Astori, estableci� las pautas de un acuerdo salarial que propon�a un aumento cada seis meses, vigente por tres a�os.
El porcentaje de aumento ya se encuentra establecido para los a�os 2017 y 2018, dejando el salario m�nimo 2017 en $12.265 gracias a un aumento preestablecido del 10%. La interrogante para muchos es si habr� cambios a este salario m�nimo ya establecido surge a partir de una cl�usula gatillo que permitir�a establecer porcentajes mayores de aumento en caso de que la inflaci�n superase el 12%.'
,1,'Economica','Periodista3')
--------------------------------------------------------------
insert Noticias(Titulo,Resumen,CuerpoNoticia,Relevante,Categoria,NomPeriodista)
 values ('Estados Unidos deport� a casi 451 mil',
 'El gobierno de Estados Unidos contin�a con su pol�tica de deportaciones, aunque la cifra tuvo una leve disminuci�n en el 2016, seg�n registros.',
 'El Gobierno de Estados Unidos deport� a 450 mil 954 inmigrantes indocumentados en el a�o fiscal 2016, un 2.5% menos que en el ejercicio anterior, seg�n datos facilitados este viernes a la prensa por el Departamento de Seguridad Nacional(DHS).
 Las 450 mil 954 deportaciones de este a�o fiscal 2016  (del 1 de octubre de 2015 al 30 de septiembre de 2016) suponen un descenso del 2.5 % respecto del a�o fiscal previo, cuando las autoridades migratorias efectuaron 462 mil 463 repatriaciones.'
,0,'Internacional','Periodista1')
------------------------------------------------------------------------
insert Noticias(Titulo,Resumen,CuerpoNoticia,Relevante,Categoria,NomPeriodista)
 values ('Cocodrilo Mordio a Turista',
 'El animal salvaje se "sorprendi�" y mordi� a la turista en la pierna, seg�n explicaron funcionarios del parque en el que ocurri� el hecho.',
 'Un cocodrilo salvaje mordi� el domingo a una turista francesa que intentaba tomarse una selfie junto al peligroso animal, en un gran parque nacional tailand�s al norte de Bangkok. 
"Quiso hacerse una selfie con el cocodrilo que yac�a en el arroyo", explic� a la AFP un funcionario del parque Khao Yai, que requiri� el anonimato. El animal "se vio sorprendido y la mordi� en la pierna", a�adi�. 
La v�ctima fue trasladada a un hospital, pero se encuentra fuera de peligro. '
,1,'Internacional','Periodista2')
--------------------------------------------------------------------------
insert Noticias(Titulo,Resumen,CuerpoNoticia,Relevante,Categoria,NomPeriodista)
 values ('Reclamacion al Gobierno',
 'Los funcionarios p�blicos anuncian que el 2017 ser� un a�o at�pico ya que volver� a discutirse el Presupuesto nacional',
 'El presidente de la Rep�blica, Tabar� V�zquez, y su equipo econ�mico de Gobierno decidieron al inicio de la actual administraci�n que el Presupuesto nacional no tendr�a una vigencia de cinco a�os, como ha sido costumbre, sino que se modificar�a a los dos a�os.
En tal sentido, en este 2017 comenzar� la discusi�n, el an�lisis y la redacci�n de la segunda parte del Presupuesto nacional.
El integrante del Secretariado Ejecutivo del PIT-CNT y presidente de la Confederaci�n de Organizaciones de Funcionarios del Estado (COFE), Mart�n Pereira, asegur� que el 2017 �no ser� un a�o t�pico, ya que el Presupuesto nacional, que siempre se hac�a a cinco a�os, la actual administraci�n lo acort�. '
,0,'Politica','Periodista2')
----------------------------------------------------------------------
insert Noticias(Titulo,Resumen,CuerpoNoticia,Relevante,Categoria,NomPeriodista)
 values ('Barack Obama, elogi� a Uruguay',
 'El presidente de los Estados Unidos, Barack Obama, elogi� a Uruguay, Sierra Leona, Indonesia y Ucrania ',
 'El presidente de la Rep�blica, Tabar� V�zquez particip� este martes 7 de diciembre en la cuarta Cumbre Global de la Alianza para el Gobierno Abierto en Par�s, instancia en la que participaron 3.000 autoridades de 70 pa�ses.
 La conferencia fue inaugurada por el presidente franc�s, Fran�ois Hollande.
Previo a la disertaci�n de V�zquez, el presidente de Estados Unidos, Barack Obama, a trav�s de un video, elogi� a Uruguay, Sierra Leona, Indonesia y Ucrania porque �han asumido 3.000 compromisos y acciones para luchar contra la corrupci�n y mejorar la prestaci�n de servicios p�blicos�. '
,1,'Politica','Periodista3')
------------------------------------------------------------------------
insert Noticias(Titulo,Resumen,CuerpoNoticia,Relevante,Categoria,NomPeriodista)
 values ('Delincuentes robaron escuela en Marconi',
 'La Polic�a busca indicios para tratar de saber qui�nes fueron los autores del robo.',
 'Las autoridades de la escuela p�blica ubicada en Leandro G�mez y San Mart�n dicen que este tipo de robos son comunes en �poca de vacaciones.
En la madrugada del lunes, los delincuentes saltaron las rejas. Ingresaron al local y robaron cosas de no mucho valor, pero s� causaron muchos destrozos.
Robaron las mallas protectoras de las ventanas y destrozaron los cables de las alarmas.
La Polic�a busca indicios para tratar de saber qui�nes fueron los autores del robo.'
,0,'Policial','Periodista1')
-------------------------------------------------------------------------
insert Noticias(Titulo,Resumen,CuerpoNoticia,Relevante,Categoria,NomPeriodista)
 values ('Tiroteo Policia con Delincuentes',
 'Pasaba por el lugar, les dio la voz de alto y comenz� el intercambio de disparos, que termin� con uno de los ladrones muertos.',
 'Cuatro delincuentes fuertemente armados asaltaron este lunes de tarde la sucursal del supermercado Ta-Ta ubicada en Felipe Carap� y Tr�bol en el barrio Aires Puros.
Al local ingresaron tres de los ladrones y el cuarto qued� esperando afuera en un auto. Amenazaron y redujeron a empleados y clientes, y se apoderaron de la recaudaci�n.
Cuando se retiraban, un polic�a que pasaba por el lugar les dio la voz de alto. Seg�n informa Telemundo, dos de los delincuentes ya hab�an entrado al auto, y fue el tercer ladr�n que entr� a robar que comenz� a tirotearse con el uniformado.'
,1,'Policial','Periodista3')
go
--------------------------------------------------
Insert Usuarios(Ndoc,NomUsuario,Usuario,Constrase�a) Values (11111,'Usuariouno','Lector1','Lector111')

Insert Usuarios(Ndoc,NomUsuario,Usuario,Constrase�a) Values (33333,'Usuariotres','Lector3','Lector333')

Insert Usuarios(Ndoc,NomUsuario,Usuario,Constrase�a) Values (55555,'Usuariocinco','Lector5','Lector555')
Insert Usuarios(Ndoc,NomUsuario,Usuario,Constrase�a) Values (66666,'Usuarioseis','Lector6','Lector666')
Insert Usuarios(Ndoc,NomUsuario,Usuario,Constrase�a) Values (77777,'Usuariosiete','Lector7','Lector777')
go
insert Lectores(Ndoc,Correo) values(11111,'correo1@gmail.com')
insert Lectores(Ndoc,Correo) values(33333,'correo2@gmail.com')
insert Lectores(Ndoc,Correo) values(55555,'correo3@gmail.com')
insert Lectores(Ndoc,Correo) values(66666,'correo4@gmail.com')
insert Lectores(Ndoc,Correo) values(77777,'correo5@gmail.com')

go

insert Comentarios(IdComentario,Comentario,Ndoc,IdNoticia) values (1,'Buena Noticia',11111,1)
insert Comentarios(IdComentario,Comentario,Ndoc,IdNoticia) values (1,'Excelente Noticia',33333,9)
insert Comentarios(IdComentario,Comentario,Ndoc,IdNoticia) values (1,'Noticia Regular',11111,5)
insert Comentarios(IdComentario,Comentario,Ndoc,IdNoticia) values (2,'Muy Buena Noticia',77777,1)

go
--select * from Noticias
-------------------------------
----PROCEDIMIENTOS
--ALTA ADMINISTRADORES
Create Procedure AltaAdministrador @Ndoc bigint,@NomUsuario varchar(20),
	@Usuario varchar(20),
	@Constrase�a varchar(9),@AprobarLector bit  As
Begin

if ( Exists(Select * From Usuarios Where Ndoc = @Ndoc))
			Begin
				return -1
			end
	if(exists (select * from Usuarios where Usuario=@Usuario))
	begin
		return -3
	end
		
		Begin Transaction
		Insert usuarios (Ndoc,NomUsuario,Usuario,Constrase�a) Values (@Ndoc,@NomUsuario,@Usuario,@Constrase�a)
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -6
		End
			Declare @VarSentenciaSql varchar(200)
	     Set @VarSentenciaSql = 'CREATE LOGIN [' +  @Usuario + '] WITH PASSWORD = ' + QUOTENAME(@Constrase�a, '''')
	       Exec (@VarSentenciaSql)
			if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -5
		End
		Declare @VarSentenciaBD varchar(200)
	     Set @VarSentenciaBD = 'CREATE USER [' +  @Usuario + '] FROM LOGIN [' + @Usuario + ']'
	     	Exec (@VarSentenciaBD)
			if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -7
		End
		Declare @permisos varchar(200)
			Set @permisos ='GRANT execute to '+@Usuario
			EXEC (@permisos)
			if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -8
		End
		Insert Administradores(Ndoc, AprobarLectores) Values(@Ndoc,@AprobarLector)

		if (@@ERROR<>0)
		Begin
			RollBack Transaction
			return -2
		End
		Commit Transaction
		return 1

		 
End
go

--LOGUEO ADMINISTRADOR
CREATE PROC LogueoAdministrador
@usuario varchar(20),
@contrase�a varchar(9)
AS
begin
	SELECT * FROM Usuarios as us inner join  Administradores as ad  ON us.Ndoc = ad.Ndoc
		WHERE us.Usuario = @usuario AND us.Constrase�a = @contrase�a
end
go
--BUSCAR ADMINISTRADOR
Create Procedure BuscoAdmin @Ndoc bigint As
Begin
	Select * 
	From Usuarios U Inner Join Administradores a on U.Ndoc = a.Ndoc 
	Where a.Ndoc=@Ndoc
End
go
 --EXEC BuscoAdmin 88888
--ALTA PERIODISTAS
	
Create Procedure AltaPeriodistas @NomPeriodista varchar(20), @Nacionalidad  varchar(20),@FechaNacimiento datetime As
Begin
if (exists(select * from Periodistas where NomPeriodista=@NomPeriodista and Baja=0))
	begin
		return -1
	end
	if exists( select * from Periodistas
	 where NomPeriodista=@NomPeriodista and Baja=1)
	 begin
	Update Periodistas set Nacionalidad=@Nacionalidad,FechaNacimiento=@FechaNacimiento,Baja=0
		where NomPeriodista=@NomPeriodista
		return 3
	end
		
		
	
		Insert Periodistas(NomPeriodista,Nacionalidad,FechaNacimiento) values (@NomPeriodista,@Nacionalidad,@FechaNacimiento)
		if(@@error=0)
			return 1
		else
			return -2
			
End
go

--BAJA PERIODISTAS
create Procedure BajaPeriodistas @NomPeriodista varchar(20) AS
Begin
	if not exists(select * from Periodistas where NomPeriodista= @NomPeriodista)
	BEGIN
		return -1
	END
	if exists(select * from Noticias where Noticias.NomPeriodista=@NomPeriodista)
	begin
		
	 Update Periodistas set Baja=1
		where NomPeriodista=@NomPeriodista
		
	end
	

	else
	begin
		begin transaction
		delete from Premios where NomPeriodista=@NomPeriodista
		  if @@ERROR <>0
	begin
	rollback tran
	return -1
	end
	
		Delete From Periodistas where NomPeriodista=@NomPeriodista
		  if @@ERROR <>0
	begin
	rollback tran
	return -1
	end
		commit tran
		return 1			
	end
end
go
--MODIFICAR PERIODISTA
create Procedure ModificarPeriodista  @Nom varchar(20),@Nacionalidad varchar(20),@FechaN datetime As
Begin
		if (Not Exists(Select * From Periodistas Where  NomPeriodista = @Nom and Baja=0))
			Begin
				return -1
			end
		
		
			 
			Begin
				Update Periodistas Set  Nacionalidad=@Nacionalidad,FechaNacimiento=@FechaN Where NomPeriodista = @Nom 
				If (@@ERROR = 0)
					return 1
				Else
					return -2
			End
			
				
End
go
--BUSCAR PERIODISTAS
create Procedure BuscarPeriodistas @nom varchar(20) As
Begin
		
	Select * From Periodistas where NomPeriodista=@nom and Baja=0
End
go
--BUSCAR PERIODISTAS SIN BAJA
create Procedure BuscarPeriodistasSBAJA @nom varchar(20) As
Begin
		
	Select * From Periodistas where NomPeriodista=@nom
End
go
--LISTO PERIODISTAS
create Procedure ListPeriodistas  As
Begin
		
	Select * From Periodistas where Baja=0
End
go
--ALTA PREMIOS
Create Procedure AltaPremio @Periodista varchar(20), @Premio varchar(50) As
Begin
		If Not (Exists(select * from Periodistas where NomPeriodista=@Periodista and Baja=0))
			return -1
		if exists(select * from Premios where Premio=@Premio)
			return -2
		Insert Premios(NomPeriodista, Premio) Values (@Periodista, @Premio)
		
		If @@ERROR = 0
			return 1
		else
			return -2

End
go
--BAJA PREMIOS
Create Procedure BajaPremios @nom varchar(20) As
begin

	Delete From Premios Where NomPeriodista = @nom 
	if(@@error=0)
			return 1
		else
			return -2
End

go
--BUSCO PREMIOS
create Procedure BuscoPremios @nomP varchar(20) As
Begin

	Select * 
	From Periodistas L Inner Join Premios T on L.NomPeriodista = T.NomPeriodista
	where t.NomPeriodista=@nomP and L.Baja=0
end
go
--LISTO PREMIOS
create Procedure ListarPremio @nomP varchar(20) AS
Begin
	Select * 
	From Premios 
	Where NomPeriodista=@nomP
End
go
--ALTA NOTICIAS
create PROC AltaNoticias @Titulo varchar(40),@Resumen varchar(150),@CuerpoNoticia varchar(1500),
@Relevante bit,@Categoria varchar(20),@NomPeriodista varchar(20) as
begin
	if not exists(select * from Periodistas where NomPeriodista=@NomPeriodista and Baja=0)
		begin
			return -3
		end
		else
		begin
			insert Noticias(Titulo,Resumen,CuerpoNoticia,Relevante,Categoria,NomPeriodista) 
			values (@Titulo,@Resumen,@CuerpoNoticia,@Relevante,@Categoria,@NomPeriodista)
			If (@@ERROR = 0)
			return 1
		else
			return 0
		end
	
	end
	go
--UPDATE NOTICIAS
create PROC ModificarNoticias @id int,@Titulo varchar(40),@Resumen varchar(150),@CuerpoNoticia varchar(1500)
,@Relevante bit,@Categoria varchar(20),@NomPeriodista varchar(20)
 as
Begin
	if not exists(select * from Noticias where  IdNoticia= @id)
	BEGIN
		return -1
	END
	if not exists(select * from Periodistas where NomPeriodista=@NomPeriodista)
		begin
			return -2
		end

	begin
	
		update Noticias set  Titulo=@Titulo,Resumen=@Resumen,CuerpoNoticia=@CuerpoNoticia,
		Relevante=@Relevante,Categoria=@Categoria,NomPeriodista=@NomPeriodista
		 where IdNoticia=@id
		
		if(@@error=0)
			return 1
		else
			return -2		
	end
end
go
--BAJA NOTICIAS
create Procedure BajaNoticias @id int AS
Begin
	if not exists(select * from Noticias where IdNoticia = @id)
	BEGIN
		return -1
	END
	
	begin
		Begin Transaction
		Delete From Comentarios where IdNoticia=@id 
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -3
		End
		Delete From Noticias where IdNoticia=@id 
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -3
		End
		Commit Transaction
		return 1

	end
end
go
-------------BUSCO NOTICIAS---------
create Procedure BuscoNoticia @id int As
Begin
		select * from Noticias where IdNoticia=@id 
End
go
---LISTO NOTICIAS
create Procedure ListoNoticia As
Begin
		select  * from Noticias
End
go
--LISTAR TODOS LOS COMENTARIOS
create Procedure ListoComentarios As
Begin
		select  * from Comentarios
End
go
--LISTAR COMENTARIOS DE NOTICIA
create Procedure ListarComentariosNoticia @id int AS
Begin
	Select * 
	From Comentarios
	Where IdNoticia=@id
End
go
--LOGUEO LECTOR
CREATE PROC LogueoLector
@usuario varchar(20),
@contrase�a varchar(9)
AS
begin
	SELECT * FROM Usuarios as us inner join  Lectores as C  ON us.Ndoc = C.Ndoc
		WHERE us.Usuario = @usuario AND us.Constrase�a = @contrase�a
end
go
--LISTAR NOTICIAS RELEVANTES
create Procedure ListarNoticiasRelevantes As
Begin
		select * from Noticias
		where Relevante=1 
		order by FechaHoraCreacion desc
End
go
--LISTAR NOTICIAS ECONOMICAS
create Procedure ListarNoticiasEconomica As
Begin
		select * from Noticias
		where Categoria='Economica'
		order by FechaHoraCreacion desc
End
go
--LISTAR NOTICIAS POLICIALES
create Procedure ListarNoticiasPolicial As
Begin
		select * from Noticias
		where Categoria='Policial'
		order by FechaHoraCreacion desc
End
go
--LISTAR NOTICIAS POLITICAS
create Procedure ListarNoticiasPolitica As
Begin
		select * from Noticias
		where Categoria='Politica'
		order by FechaHoraCreacion desc
End
go
--LISTAR NOTICIAS INTERNACIONALES
create Procedure ListarNoticiasInternacional As
Begin
		select * from Noticias
		where Categoria='Internacional'
		order by FechaHoraCreacion desc
End
go
--REGISTRO LECTOR
Create Procedure RegistroLector @Ndoc bigint,@Nom varchar(20),
	@Usuario varchar(20),
	@Constrase�a varchar(9),@Correo varchar(40)  As
Begin

  if ( Exists(Select * From Usuarios Where Ndoc = @Ndoc))
			Begin
				return -1
			end
	if(exists (select * from Usuarios where Usuario=@Usuario))
	begin
		return -3
	end
		Begin Transaction
	
		Insert usuarios (Ndoc,NomUsuario,Usuario,Constrase�a) Values (@Ndoc,@Nom,@Usuario,@Constrase�a)
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -4
		End

		Insert Lectores(Ndoc, Correo) Values(@Ndoc,@Correo)
		if (@@ERROR<>0)
		Begin
			RollBack Transaction
			return -2
		End

		Commit Transaction
		return 1	
End
go
--COMENTAR NOTICIA
create Procedure ComentarNoticia  @IdNoticia int, @Ndoc bigint, @Comentario varchar(100) As
Begin
	

if (not exists(select * from Noticias where IdNoticia = @IdNoticia))
		begin
		return -1
		end
if not exists(select * from Lectores where Ndoc = @Ndoc)
		begin
		return -2
		end
if not exists(select * from Comentarios where IdNoticia=@IdNoticia)
begin
	insert Comentarios(IdComentario,IdNoticia,Ndoc,Comentario)values(1,@IdNoticia,@Ndoc,@Comentario)
	if(@@ERROR=0)
	return 2
	else
	return -3
end
else
	begin
		declare @idcom int=(select MAX(IdComentario) from Comentarios  
		 where IdNoticia=@IdNoticia)+1
		Insert  Comentarios(IdComentario,IdNoticia,Ndoc,Comentario)values(@idcom,@IdNoticia,@Ndoc,@Comentario) 
	
		if(@@error=0)
			return 1
		else
			return -4
	end		
End
go
--Exec 
--LISTAR NOTICIAS SEGUN PERIODISTAS(PARTE XML)

create Procedure ListadoNoticiasPeriodistaXML @NomPeriodista varchar(20) As
Begin
		select * from Noticias
		where NomPeriodista=@NomPeriodista	
End
go
--MODIFICAR LECTOR
Create Procedure ModificoLector @Ndoc int,@Nom varchar(20),
	@Usuario varchar(20),
	@Constrase�a varchar(9),@Correo varchar(40) As
Begin

if ( NOT Exists(Select * From Lectores Where Ndoc = @Ndoc))
			Begin
				return -1
			end
	if(exists (select * from Usuarios where Usuario=@Usuario))
	begin
		return -3
	end
	
	
		Begin Transaction
	
		UPDATE usuarios SET NomUsuario=@Nom, Usuario=@Usuario ,Constrase�a=@Constrase�a 
		WHERE Ndoc=@Ndoc
	
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -1
		End

		update Lectores set Correo=@Correo where Ndoc=@Ndoc
		if (@@ERROR<>0)
		Begin
			RollBack Transaction
			return -2
		End

		Commit Transaction
		return 1
End
go
--BAJA LECTOR
Create Procedure BajaLector @Ndoc int As
Begin
		if (not Exists(Select * From Lectores Where Ndoc = @Ndoc))
				return -1

		Begin Transaction
		Delete From Comentarios Where Ndoc = @Ndoc
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -6
		End
		Delete From Lectores Where Ndoc = @Ndoc
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -5
		End

		Delete From Usuarios Where Ndoc = @Ndoc
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -3
		End

		Commit Transaction
		return 1

End
go
--BUSCAR Lector
Create Procedure BuscoLector @Ndoc bigint As
Begin
	Select * 
	From Usuarios U Inner Join Lectores a on U.Ndoc = a.Ndoc 
	Where a.Ndoc=@Ndoc
End
go
--Listar Lector
Create Procedure ListarLector As
Begin
	Select * 
	From Usuarios U Inner Join Lectores a on U.Ndoc = a.Ndoc 
End
go


USE master


CREATE LOGIN [IIS APPPOOL\DefaultAppPool] FROM WINDOWS
GO

USE Proyecto
GO

CREATE USER [IIS APPPOOL\DefaultAppPool] FOR LOGIN [IIS APPPOOL\DefaultAppPool]
GO

GRANT execute to [IIS APPPOOL\DefaultAppPool]
GO


Exec AltaAdministrador 22222,'Usuariodos','Admin2','Admin2222',1
go
Exec AltaAdministrador 88888,'Usuariocho','Admin8','Admin8888',0
go

