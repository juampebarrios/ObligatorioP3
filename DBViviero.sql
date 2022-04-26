use master
go

------------------------------------------------------------------------------------------------------------------

if exists(Select * FROM SysDataBases WHERE name='ViveroP3')
BEGIN
	DROP DATABASE ViveroP3
END
go
CREATE DATABASE ViveroP3

go
use ViveroP3
go
Create Table Compra
(
	id int identity(1,1),
    fechaCompra date not null,
	precioCompra money not null,
	constraint pk_Compra primary key(id)
)
go

Create Table CompraPlaza
(
    idPlaza int identity,
	idCompra int not null,
    iva numeric(12,2) not null,
	constraint pk_CompraPlaza primary key(idPlaza),
	constraint fk_CompraPlaza foreign key(idCompra) references Compra(id)
)
go
Create Table CompraImportacion
(
    idImporta int identity,
	idCompra int not null,
    ImpuestoImportacion numeric(10,2),
    esAmericaDelSur bit not null,
    descripcion varchar(100),
	constraint pk_Importa primary key(idImporta),
	constraint fk_Importa foreign key(idCompra) references Compra(id)
)
go

Create Table FacturaPlantaCompradas
(
    id int identity,
	idCompra int not null,
	cantidad int not null,
	precioUnitario money not null,
	constraint pk_Importa1 primary key(id),
	constraint fk_Importa1 foreign key(idCompra) references Compra(id)
)

go

create table TipoPlanta
(
 id int identity,
 nombre nvarchar(50) not null,
 descripcion nVarchar(200),
 constraint pk_IdTipoPlanta primary key(id)
)
go


create Table Plantas
(
    id int identity,
	tipo int,
	nombreCientifico nvarchar(100) not null,
	nombresVulgares nvarchar(100) not null,
	descripcion nvarchar(100) not null,
	ambiente nvarchar(100) not null,
	alturaMax numeric(12,2) not null,
	precioUnitario numeric(12,2) not null,
	constraint pk_Planta2 primary key(id),
	constraint fk_TipoID foreign key(tipo) references TipoPlanta(id)
)
go

create table FotoPlanta
(
	id int identity,
	idPlanta int not null,
	nombre nVarchar(30),
	directorio nVarchar(200),
	constraint pk_FotoPlanta primary key(id),
	constraint fk_Importa2 foreign key(idPlanta) references Plantas(id)
)
go

create table FichaCuidado
(
	id int identity,
	idPlanta int not null,
	frecuenciaRiego nVarchar(100),
	tipoIluminacion nVarchar(100),
	temperatura nVarchar(100),
	constraint pk_FotoPlanta1 primary key(id),
	constraint fk_idPlantaFC foreign key(idPlanta) references Plantas(id)
)
go
Create Table Usuario
(
	id int identity(1,1),
    usuario  nVarchar(100) not null,
	pass  nVarchar(100) not null,
	constraint pl_Usu primary key(id)
)
go

---------------------------------------------------------------------------------------
---PLANTAS--
create procedure spAltaPlanta
	@id int,
	@tipo int,
	@nombreCientifico varchar(100) ,
	@nombresVulgares varchar(100),
	@descripcion varchar(100),
	@ambiente varchar(100) ,
	@alturaMax numeric(12,2) ,
	@precioUnitario money

as
begin
	if (exists(select * from Plantas where id = @id))
		begin
				return -1
		end
		else
		begin
			insert into Plantas values (@tipo,@nombreCientifico,@nombresVulgares,@descripcion,@ambiente,@alturaMax,@precioUnitario)
			if @@error <> 0
				return -1		
		return 0
	end
end
go	

create procedure spAltaPlantaConFoto
	@id int,
	@tipo int,
	@nombreCientifico varchar(100) ,
	@nombresVulgares varchar(100),
	@descripcion varchar(100),
	@ambiente varchar(100) ,
	@alturaMax numeric(12,2) ,
	@precioUnitario money, 
    -----FOTOS----
	@nombre varchar(30),
	@directorio varchar(200)

as
begin
	if (exists(select * from Plantas where id = @id))
		begin
				return -1
		end
		else
		begin
		begin tran
			insert into Plantas values (@tipo,@nombreCientifico,@nombresVulgares,@descripcion,@ambiente,@alturaMax,@precioUnitario)
			if @@error <> 0
			begin
				rollback tran
				return -1
			end	
			insert into FotoPlanta values (@id,@nombre,@directorio)
			if @@error <> 0
			begin 
				rollback tran
				return -1
			end
		
			commit tran
			return 0
	end
end
go	


create procedure spModificarPlantaConFoto
    @id int,
	@nombreCientifico varchar(100) ,
	@nombresVulgares varchar(100),
	@descripcion varchar(100),
	@ambiente varchar(100) ,
	@alturaMax numeric(12,2) ,
	@precioUnitario money, 
    -----FOTOS----
	@nombre varchar(30),
	@directorio varchar(200)
as
begin
	if (not exists(select * from Plantas where id = @id))
		return -1
	begin tran
	update Plantas set nombreCientifico = @nombreCientifico,nombresVulgares= @nombresVulgares,descripcion = @descripcion,ambiente= @ambiente,alturaMax= @alturaMax,precioUnitario= @precioUnitario where id = @id
	if @@error <> 0
	begin
		rollback tran
		return -1
	end
	update FotoPlanta set nombre = @nombre , directorio = @directorio
	if @@error <> 0
	begin
		rollback tran
		return -1
	end
	commit tran
	return 0
end
go

create procedure spModificarPlanta
    @id int,
	@nombreCientifico varchar(100) ,
	@nombresVulgares varchar(100),
	@descripcion varchar(100),
	@ambiente varchar(100) ,
	@alturaMax numeric(12,2) ,
	@precioUnitario money
as
begin
	if (not exists(select * from Plantas where id = @id))
		return -1
	update Plantas set nombreCientifico = @nombreCientifico,nombresVulgares= @nombresVulgares,descripcion = @descripcion,ambiente= @ambiente,alturaMax= @alturaMax,precioUnitario= @precioUnitario where id = @id
	if @@error <> 0
		return -1
	return 0
end
go

create proc spEliminarPlanta
	@id int
as
begin
	if (not exists(select * from Plantas where id = @id))
		return -1
	begin tran

	delete from FichaCuidado where idPlanta = @id
	if @@error <> 0
		begin
			rollback transaction
			return -1
		end
	
	delete from FotoPlanta where idPlanta = @id
	if @@error <> 0
		begin
			rollback transaction
			return -1
		end
	
	delete from Plantas where id = @id
	if @@error <> 0
		begin
			rollback transaction
			return -1
		end
	
	commit tran
	return 0
end
go


create proc spAgregarFoto
	@idPlanta int,
	@nombre varchar(30),
	@directorio varchar(200)
as
begin 
	if (not exists(select * from Plantas where id = @idPlanta))
		return -1
	insert into FotoPlanta values (@idPlanta,@nombre,@directorio)
	if @@error <> 0
		return -1

	return 0

end
go

create proc spAgregarFichaCuidado
	@idPlanta int,
	@frecuenciaRiego varchar(100),
	@tipoIluminacion varchar(100),
	@temperatura varchar(100)
 as
 begin
	if (not exists(select * from Plantas where id = @idPlanta))
		return -1
	insert into FichaCuidado values (@idPlanta,@frecuenciaRiego,@tipoIluminacion,@temperatura)
		
 end
 go

 create proc spEliminarFichaCuidado
	@idPlanta int
 as
 begin
	if (not exists(select * from Plantas where id = @idPlanta))
		return -1
	if (not exists(select * from FichaCuidado where id = @idPlanta))
		return -1
	delete from FichaCuidado where idPlanta = @idPlanta
		
 end
 go

 create proc spEliminarTipo
	@idTipo int
 as
 begin
	if (exists(select * from Plantas p where p.tipo = @idTipo))
		return -1
	if (not exists(select * from TipoPlanta t where t.id = @idTipo))
		return -1
	delete from Plantas where tipo = @idTipo
	delete from TipoPlanta where id = @idTipo
	return 0 
 end
 go

 create proc spModificarFichaCuidado
	@idPlanta int,
	@frecuenciaRiego varchar(100),
	@tipoIluminacion varchar(100),
	@temperatura varchar(100)
 as
 begin
	if (not exists(select * from Plantas where id = @idPlanta))
		return -1
	if (not exists(select * from FichaCuidado where id = @idPlanta))
		return -1
	update  FichaCuidado set frecuenciaRiego = @frecuenciaRiego, tipoIluminacion = @tipoIluminacion, temperatura = @temperatura
		
 end
 go

create proc spBuscarPlanta
	@id int
as
begin
	select * from Plantas where id = @id
end
go

create proc BuscarPlantaNV
	@id varchar(100)
as
begin
	select * from Plantas where nombresVulgares = @id
end
go

create proc spListarPlantas
as
begin
	select * from Plantas
end
go
-- .... --
-------------------------------------------------------------------------------------------------
insert into TipoPlanta values('Tipo1','descripcion')
go
insert into TipoPlanta values('Tipo2','descripcion')
go
insert into TipoPlanta values('test','descripcion')
go
INSERT INTO Plantas VALUES(1,'PLANTA',  'Plantota', 'La seniora descripcion', 'frio',12,123)
go
INSERT INTO Plantas VALUES(2,'PLANTA', 'Plantota', 'La seniora descripcion', 'frio',12,123)
go
INSERT INTO Plantas VALUES(1,'PLANTA', 'Plantota', 'La seniora descripcion', 'frio',12,123)
go
INSERT INTO Plantas VALUES(2,'PLANTA1', 'Plantota1', 'La seniora descripcion', 'frio',12,123)
go
/*
	tipoPlanta varchar(100) not null,
	nombreCientifico varchar(100) not null,
	nombresVulgares varchar(100) not null,
	descripcion varchar(100) not null,
	ambiente varchar(100) not null,
	alturaMax numeric(12,2) not null,
	precioUnitario money not null,
	constraint pk_Planta2 primary key(id)
*/
select * from TipoPlanta

INSERT INTO Usuario VALUES ('test@test.com', '123')
