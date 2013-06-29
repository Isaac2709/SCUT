------------creacion de la base de datos--------------
create database SCUT
go

use SCUT
go

/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
					Valores por defecto
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

--------------USUARIOS--------------

create default Dgenero as 'M'--Genero 'M' = Masculino
go

create default DEstado as 'A'--Estado 'A' = Estado
go

---------------HORAS EXTRA---------------
create default Dhoras as '07:00'
go

---TIPO DE COMBUSTIBLE---
create default Dtipo_combustible as 'Regular'
go

--- TIPO MANTENIMIENTO ---
create default DtipoMantenimiento as 'Mantenimiento'
go

--- TIPO DE LICENCIA ---
create default DtipoLicencia as 'B1'
go

-- TIPO DE VELOCIDADES --
create default DVelocidades as 'M'-- Velocidades 'M' = Manual
go
--- TIPO DE PUESTO ---
create default DPuesto as 'Chofer'
go
/*+++++++++++++++++++++++++++Fin Valores por Defecto++++++++++++++++++++++++++++++++++++++++++*/


/***********************************************************************************************
								Tipos de datos y Reglas  
***********************************************************************************************/

---..................USUARIOS.........................---

--Tipos de datos id_U (Identificacion Usuario)
create rule Rid_U as(@id_U like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
go
exec sp_addtype		'Tid_U','char(8)','not null'
go
exec sp_bindrule	'Rid_U','Tid_U'
go

--Tipos de datos cedula
create rule Rcedula as (@cedula like '[0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
go
exec sp_addtype		'TCedula','char (11)', 'not null'
go
exec sp_bindrule	'Rcedula','Tcedula'
go

--Tipos de datos genero(M = Masculino y F = Femenino)
create rule Rgenero as (@genero in ('M','F'))
go
exec sp_addtype		'Tgenero','char(1)','not null'
go
exec sp_bindrule	'Rgenero','Tgenero'
go
exec sp_bindefault	'Dgenero','Tgenero'
go

--Tipo de puesto
create rule Rpuesto as (@puesto in ('Chofer','Profesor','Otros'))
go
exec sp_addtype		'Tpuesto','char(8)','not null'
go
exec sp_bindrule	'Rpuesto','Tpuesto'
go
exec sp_bindefault	'Dpuesto','Tpuesto'
go

--Tipo de estado usuario(A = Activo o I = Inactivo)
create rule Restado as (@estado in ('A','I'))
go
exec sp_addtype		'Testado','char(1)','not null'
go
exec sp_bindrule	'Restado','Testado'
go
exec sp_bindefault	'Destado','Testado'
go

--Tipos de datos fecha_nacimiento
create rule Rfecha as (@fecha like '[0-1][0-9]-[0-3][0-9]-[0-9][0-9][0-9][0-9]')
go
exec sp_addtype		'Tfecha','char(10)','not null'
go
exec sp_bindrule	'Rfecha','Tfecha'
go

--Tipos de datos e_mail
create rule Re_mail as(@e_mail like '[a-Z]%@[a-Z]%.%')
go
exec sp_addtype		'Te_mail','varchar(80)','not null'
go
exec sp_bindrule	'Re_mail','Te_mail'
go

---..................LICENCIA..................---

-- Tipos de dato tipo
create  rule RtipoLicencia as (@tipo like '[A-D][1-4]') 
go 
exec sp_addtype		'TtipoLicensia','char(2)','not null'
go
exec sp_bindrule	'RtipoLicencia','TtipoLicensia'
go
exec sp_bindefault	'DtipoLicencia','TtipoLicensia'
go

---..................TELEFONOS..................---

--Tipo de dato telefono
create rule Rtelefono as (@telefono like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
or (@telefono like '([0-9][0-9][0-9]) [0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]') 
go
exec sp_addtype		'Ttelefono','varchar(14)','not null'
go
exec sp_bindrule	'Rtelefono','Ttelefono'
go

---..................GASTO_COMBUSTIBLE..................---

--Tipo de dato placa 
create rule Rplaca as (@placa like '[0-9][0-9][0-9]-[0-9][0-9][0-9]')
go
exec sp_addtype		'Tplaca','char(7)','not null'
go
exec sp_bindrule	'Rplaca','Tplaca'
go

---..................HORAS EXTRA..................---

--Tipo de datos oficioAprobación
create rule RoficioAprob as (@oficio_Aprobacion like'[0-9][0-9][0-9][0-9]')
go
exec sp_addtype		'ToficioAprob','char(4)','not null'
go
exec sp_bindrule	'RoficioAprob','ToficioAprob'
go

--Tipo de dato horas
create rule Rhoras as (@horas like '[0-2][0-9]:[0-5][0-9]')
go
exec sp_addtype		'Thoras','char(5)','not null'
go
exec sp_bindrule	'Rhoras','Thoras'
go
exec sp_bindefault	'Dhoras','Thoras'
go

---..................TCENTRO COSTOS..................---

--Tipos de datos id_CC
create rule Rid_CC as (@id_CC like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
go 
exec sp_addtype		'Tid_CC','char(14)','not null'
go
exec sp_bindrule	'Rid_CC','Tid_CC'
go


---..................SOLICITUD_FICHA_SALIDA..................---

--Tipo de datos Numero_Solicitud 
create rule RnumeroSolicitud as(@numero_Solicitud like '[0-9][0-9][0-9][0-9]')
go
exec sp_addtype		'Tnumero_Solicitud','char(4)','not null'
go
exec sp_bindrule	'RnumeroSolicitud','Tnumero_Solicitud'
go

---..................VEHICULOS..................---

--Tipo de datos tipo de combustible
create rule Rtipo_combustible as (@tipo_combustible in ('Regular','Super','Diesel'))
go
exec sp_addtype		'Ttipo_combustible','char(7)','not null'
go
exec sp_bindrule	'Rtipo_combustible','Ttipo_combustible'
go
exec sp_bindefault	'Dtipo_combustible','Ttipo_combustible'
go

--Tipo de datos tipo de velocidades
create rule RVelocidades as(@Velocidades in('M','A'))--A = Automatico y M = Manual
go
exec sp_addtype		'TVelocidades','char(1)','not null'
go
exec sp_bindrule	'RVelocidades','TVelocidades'
go
exec sp_bindefault	'DVelocidades','TVelocidades'
go

---..................MANTENIMIENTO..................----

--Tipo de datos de mantenimiento
create rule RtipoMantenimiento as(@tipo in ('Mantenimiento','Reparacion'))
go
exec sp_addtype		'TtipoMantenimiento','varchar(13)','not null'
go
exec sp_bindrule	'RtipoMantenimiento','TtipoMantenimiento'
go
exec sp_bindefault	'DtipoMantenimiento','TtipoMantenimiento'
go

/*******************************Fin Tipos de Datos y Reglas ************************************/


/***********************************************************************************************
									Creación de tablas
***********************************************************************************************/

create table Usuarios(
	id_U				Tid_U,
	cedula				Tcedula	,
	nombre				varchar(20) not null,
	apellido1			varchar(20) not null,
	apellido2			varchar(20) not null,
	fecha_nacimiento	Tfecha,
	genero				Tgenero,
	direccion			varchar(200) not null,
	e_mail				Te_mail,
	puesto				Tpuesto,
	estado				char(1),
	departamento		varchar(150) not null,
	constraint pk_id_Usuarios		primary key (id_U),
	constraint u_cedula_Usuarios	unique (cedula)
)
go

create table telefonos(
	id_U		char(8) not null,
	telefono	Ttelefono,
	constraint pk_idUtelefono_telefonos primary key (id_U,telefono),
	constraint fk_idU_telefonos			foreign key (id_U) references Usuarios		on delete cascade on update cascade 
)
go

create table Tipos_Licencia(
	id_U		char(8) not null,
	tipo		TtipoLicensia,
	constraint pk_idUTipo_Tipos_Licencia	primary key (id_U,tipo),
	constraint fk_idU_Tipos_Licencia		foreign key (id_U) references Usuarios	on delete cascade on update cascade 
)
go

-- Viaticos del Chofer--
create table viaticos (
	id_V	int		identity(1,1),
	detalle	varchar(200) not null,
	fecha	Tfecha,
	monto	int not null,
	id_U	char(8) ,
	constraint pk_idV_Viaticos		primary key(id_V),
	constraint U_idV_idU_Viaticos	unique (id_V,id_U),
	constraint fk_idU_Viaticos		foreign key(id_U)	references Usuarios On Delete Set Null on update cascade 
)
go

-- Departamento institucional al que se le cobrar los viajes--
create table Centro_Costo(
	id_CC	Tid_CC,
	nombre	varchar(40),
	constraint pk_idCC_Centro_Costo primary key (id_CC)
)
go

--tabla de horas extras--
create table horas_extra(
	oficio_Aprobacion	ToficioAprob,
	hora_inicio		Thoras,	
	hora_fin		Thoras,
	fecha			Tfecha,
	id_CC			char(14),
	id_U			char(8) ,
	actividad		varchar(30)
	constraint pk_oficio_Aprobacion_horas_Extras	primary key(oficio_Aprobacion),
	constraint fk_idU_horas_extras					foreign key (id_U)	references Usuarios		 On Delete Set Null on update cascade,
	constraint fk_idCC_horas_extras					foreign key (id_CC) references Centro_Costo  On Delete Set Null on update cascade, 
)
go

-- Agencia a la que se le compra el Vehículo
create  table agencia(
	cedula_jur_ag	varchar(20) not null,
	direccion		varchar(150) not null,
	telefono		Ttelefono,
	email			Te_mail,
	nombre			varchar(20),
	constraint pk_cedula_jur_ag_agencia		primary key(cedula_jur_ag)
)
go

-- Garantia del Vehiculo--
create table garantia(
	id_Garantia		int identity(1,1),
	cedula_jur_ag	varchar(20) not null,
	km_Vencimiento	int not null,
	fecha_Vencimiento	Tfecha,
	constraint pk_idGarantia_garantia		primary key(id_garantia),
	constraint fk_cedula_jur_ag			foreign key(cedula_jur_ag)		references agencia
)
go

--Tabla de información del Vehículo
create table vehiculos (
	placa				Tplaca,
	departamento		char(14) not null,
	descripcion			varchar(100),
	modelo				int not null,
	numero_chasis		char(17),
	numero_Motor		varchar(15),
	cilindros			tinyint,
	cilindrada			varchar(7),
	color				varchar(20) not null,
	puertas				tinyint not null,
	tipo_combustible	Ttipo_combustible,
	marca				varchar(15) not null,
	estilo				varchar(30) null,
	fecha_compra		Tfecha,	
	kilometraje			int,
	capacidad			tinyint,
	velocidades			TVelocidades,
	id_garantia			int,
	cedula_jur_ag		varchar(20) ,
	sucursal			varchar(20) not null,
	constraint pk_placa_vehiculos			primary key(placa),
	constraint fk_garantia_vehiculos		foreign key(id_Garantia)	references garantia On Delete Set Null on update cascade, 
	constraint fk_cedula_jur_ag_vehiculos	foreign key(cedula_jur_ag)	references agencia	On Delete Set Null on update cascade 
)
go

--Gasto de combustible de los vehículos
create table gasto_combustible(
	id_G				int		identity(1,1),
	gasto_combustible	int	not null,
	fecha				Tfecha,	
	gasto_efectivo		int not null,
	factura				int not null,
	placa				char(7) ,
	id_U				char(8) ,
	constraint pk_idG_Gasto_Combustible		primary key(id_G),
	constraint U_idG_idU_Gasto_Combustible	unique(id_G,id_U),
	constraint fk_idU_Gasto_Combustible		foreign key(id_U) references Usuarios On Delete Set Null on update cascade, 
	constraint fk_placa_Combustible		foreign key(placa) references vehiculos On Delete Set Null on update cascade 
)
go

--tabla de Información de solicitud de ficha de salida
create table Solicitud_FichaSalida(
	numero_Solicitud	Tnumero_Solicitud,
	tipoActividad		varchar(100),
	Hora_Sal			Thoras,
	Hora_Lleg			Thoras,
	Kilometraje_Inic	int,
	Kilometraje_Final	int,
	Ruta				varchar(100),
	Fecha_Salida		Tfecha,
	Fecha_Llegada		Tfecha,
	id_U				char(8) ,
	placa_vehiculo		char(7),		
	id_CC				char(14),
	constraint pk_idSFS_Solicitud_FichaSalida	primary key(numero_Solicitud),
	constraint fk_id_U_Solicitud_FichaSalida	foreign key(id_U)				references Usuarios		On Delete Set Null on update cascade, 
	constraint fk_id_CC_Solicitud_FichaSalida	foreign key(id_CC)				references Centro_Costo On Delete Set Null on update cascade, 
	constraint fk_placa_vehiculos				foreign key(placa_vehiculo)		references vehiculos	On Delete Set Null on update cascade 
)
go

--Tabla de información del taller
create table talleres(
	cedula_jur_talleres	varchar(20) not null,
	nombre			varchar(15) not null,
	especialidad	varchar(50) not null,
	email			Te_mail,
	direccion		varchar(150) not null,
	telefono		Ttelefono,
	constraint pk_cedulaJurTalleres_talleres	primary key (cedula_jur_talleres) 
)
go 

--Tabla de información del mantenimiento
create table mantenimiento (
	id_mant				int identity(1,1),
	monto				int,
	detalle				varchar(60) not null,
	tipoMantenimento	TtipoMantenimiento,		
	numero_factura		int not null,
	fecha				Tfecha,
	cedula_jur_talleres	varchar(20),
	cedula_jur_ag		varchar(20),
	placa_vehiculo		char(7) not null,	
	constraint pk_idMant_mantenimiento				primary key (id_mant),
	constraint fk_placaVehiculo_mantenimiento 		foreign key (placa_vehiculo) references Vehiculos on delete cascade on update cascade,
	constraint fk_cedula_jur_ag_mantenimiento 		foreign key (cedula_jur_ag) references agencia,
	constraint fk_cedula_jur_talleres_mantenimiento foreign key (cedula_jur_talleres) references talleres on Delete Set Null on update cascade
)
go
/**********************************************Fin de creación de tablas*********************************************************/

/*&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
											Creacion de Procedimientos
&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&*/

--[[[[[[[[Aqui se utiliza una Transaccion]]]]]]]
--........Inserción de Usuarios ........--
create procedure insertarUsuarios(
	@id_U				char(8),
	@cedula				char(11),
	@nombre				varchar(20),
	@apellido1			varchar(20),
	@apellido2			varchar(20),
	@fecha_nacimiento	char(10),
	@genero				char(1),
	@direccion			varchar(200),
	@e_mail				varchar(80),
	@puesto				varchar(20),
	@estado				char(1),
	--@tarjeta	
	@departamento		varchar(150)
)
as
	begin tran
	if (@e_mail like '[a-Z]%@[a-Z]%.%')
	begin
		commit tran
		insert Usuarios(id_U, cedula, nombre, apellido1, apellido2,fecha_nacimiento, genero, direccion, e_mail, puesto,estado, departamento)
		Values(@id_U, @cedula, @nombre, @apellido1, @apellido2, @fecha_nacimiento, @genero, @direccion, @e_mail, @puesto,@estado, @departamento)
	end
	
	else 
	begin
		rollback tran
		raiserror ('Dominios no permitidos',1,1)
	end
go
--........Consulta de tabla Usuarios........--
create procedure ConsultaUsuario
as
	select * from Usuarios
go

--........Para actualizar Usuarios........--
create procedure actualizarUsuarios
(
	@id_U				char(8),
	@cedula				char(11),
	@nombre				varchar(20),
	@apellido1			varchar(20),
	@apellido2			varchar(20),
	@fecha_nacimiento	char(10),
	@genero				char(1),
	@direccion			varchar(200),
	@e_mail				varchar(80),
	@puesto				varchar(20),
	@departamento		varchar(150)
)
as
	if(@cedula is not null and @id_U is not null)
	begin
		update usuarios
		set cedula=@cedula
		where @id_U=id_U
	end
	if(@nombre is not null and @id_U is not null)
	begin
		update usuarios
		set nombre=@nombre
		where @id_U=id_U
	end
	if(@apellido1 is not null and @id_U is not null)
	begin
		update usuarios
		set apellido1=@apellido1
		where @id_U=id_U
	end
	if(@apellido2 is not null and @id_U is not null)
	begin
		update usuarios
		set apellido2=@apellido2
		where @id_U=id_U
	end
	if(@fecha_nacimiento is not null and @id_U is not null)
	begin
		update usuarios
		set fecha_Nacimiento=@fecha_nacimiento
		where @id_U=id_U
	end
	if(@genero is not null and @id_U is not null)
	begin
		update usuarios
		set genero=@genero
		where @id_U=id_U
	end
	if(@direccion is not null and @id_U is not null)
	begin
		update usuarios
		set direccion=@direccion
		where @id_U=id_U
	end
	if(@e_mail is not null and @id_U is not null)
	begin
		update usuarios
		set e_mail=@e_mail
		where @id_U=id_U
	end
	if(@puesto is not null and @id_U is not null)
	begin
		update usuarios
		set puesto=@puesto
		where @id_U=id_U
	end
	if(@departamento is not null and @id_U is not null)
	begin
		update usuarios
		set departamento=@departamento
		where @id_U=id_U
	end
go

--........Borrado de Usuario........--
create procedure borrarUsuarios(
	@id_U			char(8)
)
as
	delete from Usuarios where id_U=@id_U

go

--........Insertar Teléfono a Usuario........--
create procedure insertarTelefonos(
	@id_U		char(8),
	@telefono	varchar(14)
)
as
	if (@telefono like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
or (@telefono like '([0-9][0-9][0-9]) [0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
	begin
		if(select count(*) from telefonos where id_U=@id_U)<3
		begin
			if(select count(*) from telefonos where id_U=@id_U and telefono like '2%')<2 or @telefono like '8%'
			begin
				insert telefonos(id_U, telefono)
				values(@id_U, @telefono)
			end
			else
			begin
				print 'Al menos debe tener insertar un telefono celular'
			end
		end
		else
		begin
			print 'Solamente se permiten 3 telefonos'
		end
	end
	else
	begin
		print 'No tiene el formato adecuado'
	end
go

--........Consulta de tabla Teléfono........--
create procedure ConsultaTelefono
as
	select * from telefonos
go

----........Borrar Teléfono a Usuario........--
create procedure borrarTelefonos(
	@id_U		char(8),
	@telefono	varchar(14)
)
as
	delete from telefonos where id_U=@id_U and telefono=@telefono
go

--........Insertar Tipo de Licencia a Usuario........--
create procedure insertarTipos_Licencia(
	@id_U	char(8),
	@tipo	char(2)
)
as
	insert Tipos_Licencia(id_U,tipo)
	values(@id_U, @tipo)
go

--........Consulta de tabla Tipos_Licencia........--
create procedure ConsultaTipos_Licencia
as
	select * from Tipos_Licencia
go

--........Actualiza Tipo de Licencia a Usuario........--
create procedure actualizarTipos_Licencia(
	@id_U	char(8),
	@tipo	char(2)
)
as
	if(@id_U is not null and @tipo is not null)
	begin
		update Tipos_Licencia
		set tipo=@tipo
		where id_U=@id_U
	end
go

--........Borrar Tipo de Licencia a Usuario........--
create procedure borrarTipos_Licencia(
	@id_U		char(8),
	@tipo		char(2)
)
as
	delete from Tipos_Licencia where id_U=@id_U and tipo=@tipo
go

--........Insertar Viáticos........--
create procedure insertarViaticos(
	@id_V		int,
	@detalle	varchar(200),
	@fecha		char(10),
	@monto		int,
	@id_U		char(8)
)
as
	insert viaticos( detalle, fecha, monto, id_U)
	values(@detalle,@fecha,@monto,@id_U)
go

--........Consulta de tabla Viaticos........--
create procedure ConsultaViaticos
as
	select * from Viaticos
go

--........Actualizar Viáticos........--
create procedure actualizarViaticos(
	@id_V		int,
	@detalle	varchar(200),
	@fecha		char(10),
	@monto		int,
	@id_U		char(8)
)
as
	if(@id_V is not null)
	begin
		if(@detalle is not null)
		begin
			update Viaticos
			set detalle=@detalle
			where id_V=@id_V
		end
		if(@fecha is not null)
		begin
			update Viaticos
			set fecha=@fecha
			where id_V=@id_V
		end
		if(@monto is not null)
		begin
			update Viaticos
			set monto=@monto
			where id_V=@id_V
		end
		if(@id_U is not null)
		begin
			update Viaticos
			set id_U=@id_U
			where id_V=@id_V
		end
	end
go

--........Borrar Viáticos........--
create procedure borrarViaticos(
	@id_V		int
)
as
	delete from viaticos where id_V=@id_V
go

--[[[[[[[  AQUÍ SE UTILIZA UNA TRANSACCIÓN  ]]]]]]]
--........Insertar Gasto........--
create procedure insertarGasto_Combustible(
	@id_G				int,
	@gasto_Combustible	int,
	@fecha				char(10),
	@gasto_efectivo		int,
	@factura			int,
	@placa				char(7),
	@id_U				char(8)
)
as
	begin tran
	if(@gasto_efectivo>0 and @gasto_Combustible>0)
	begin
		commit tran
		insert gasto_combustible(gasto_Combustible,fecha,gasto_Efectivo,factura,placa,id_U)
		values(@gasto_Combustible,@fecha,@gasto_Efectivo,@factura,@placa,@id_U)
	end
	else 
		begin 
			rollback tran
			raiserror ('Gasto en efectivo o de combustible debe de ser positivo',4,1)
		end
go

--........Consulta de tabla Gasto_Combustible........--
create procedure ConsultaGasto_Combustible
as
	select * from Gasto_Combustible
go

--........Actualizar Gasto Combustible........--
create procedure actualizarGasto_Combustible(
	@id_G				int,
	@gasto_Combustible	int,
	@fecha				char(10),
	@gasto_efectivo		int,
	@factura			int,
	@placa				char(7),
	@id_U				char(8)
)
as
	if(@id_G is not null)
	begin
		if(@gasto_Combustible is not null)
		begin
			update gasto_combustible
			set gasto_combustible=@gasto_Combustible
			where id_G=@id_G
		end
		if(@fecha is not null)
		begin
			update gasto_combustible
			set fecha=@fecha
			where id_G=@id_G
		end
		if(@gasto_efectivo is not null)
		begin
			update gasto_combustible
			set gasto_efectivo=@gasto_efectivo
			where id_G=@id_G
		end
		if(@factura is not null)
		begin
			update gasto_combustible
			set factura=@factura
			where id_G=@id_G
		end
		if(@placa is not null)
		begin
			update gasto_combustible
			set placa=@placa
			where id_G=@id_G
		end
		if(@id_U is not null)
		begin
			update gasto_combustible
			set id_U=@id_U
			where id_G=@id_G
		end
	end
go

--........Borrar Gasto Combustible........--
create procedure borrarGasto_Combustible(
	@id_G				int
)
as
	delete from gasto_combustible where id_G=@id_G
go

--........Insertar Horas Extras........--
create procedure insertarHoras_Extras(
	@oficio_Aprobacion	char(4),
	@hora_Inicio		char(5),
	@hora_Fin			char(5),
	@fecha				char(10),
	@id_CC				char(14),
	@id_U				char(8),
	@actividad			varchar(30)
)
as
	insert horas_Extra(oficio_Aprobacion,hora_Inicio,hora_fin,fecha,id_CC,id_U,actividad)
	values(@oficio_Aprobacion,@hora_Inicio,@hora_Fin,@fecha,@id_CC,@id_U,@actividad)
go

--........Consulta de tabla Horas_Extras........--
create procedure ConsultaHoras_Extras
as
	select * from horas_extra
go

--........Actualizar Horas Extras........--
create procedure actualizarHoras_Extras(
	@oficio_Aprobacion	char(4),
	@hora_Inicio		char(5),
	@hora_Fin			char(5),
	@fecha				char(10),
	@id_CC				char(14),
	@id_U				char(8)
)
as
	if(@oficio_Aprobacion is not null)
	begin
		if(@hora_Inicio is not null)
		begin
			update horas_extra
			set hora_Inicio=@hora_Inicio
			where oficio_Aprobacion=@oficio_Aprobacion
		end
		if(@hora_Fin is not null)
		begin
			update horas_extra
			set hora_Fin=@hora_Fin
			where oficio_Aprobacion=@oficio_Aprobacion
		end
		if(@fecha is not null)
		begin
			update horas_extra
			set fecha=@fecha
			where oficio_Aprobacion=@oficio_Aprobacion
		end
		if(@id_CC is not null)
		begin
			update horas_extra
			set id_CC=@id_CC
			where oficio_Aprobacion=@oficio_Aprobacion
		end
		if(@id_U is not null)
		begin
			update horas_extra
			set id_U=@id_U
			where oficio_Aprobacion=@oficio_Aprobacion
		end
	end
go

--........Borrar Horas Extras........--
create procedure borrarHoras_Extras(
	@oficio_Aprobacion	char(4)
)
as
	delete from horas_extra where oficio_Aprobacion=@oficio_Aprobacion
go

--........Insertar Centro de Costo........--
create procedure insertarCentro_Costo(
	@id_CC	char(14),
	@nombre	varchar(40)
)
as
	insert Centro_Costo(id_CC, nombre)
	values(@id_CC,@nombre)
go

--........Consulta de tabla Centro_Costo........--
create procedure ConsultaCentro_Costo
as
	select * from Centro_Costo
go

--........Actualizar Centro de Costo........--
create procedure actualizarCentro_Costo(
	@id_CC	char(14),
	@nombre	varchar(40)
)
as
	if(@id_CC is not null and @nombre is not null)
	begin
		update Centro_Costo
		set nombre=@nombre
		where id_CC=@id_CC
	end
go

--........Borrar Centro de Costo........--
create procedure borrarCentro_Costo(
	@id_CC	char(14)
)
as
	delete from Centro_Costo where id_CC=@id_CC
go

select *from Solicitud_FichaSalida
go

--........Insertar Solicitud de Ficha de Salida........--
create procedure insertarSolicitud_Ficha_Salida(
	@numero_Solicitud		char(4),
	@tipoActividad			varchar(100),
	@Hora_Sal				char(5),
	@Hora_Lleg				char(5),
	@Kilometraje_Inic		int,
	@Kilometraje_Final		int,
	@Ruta					varchar(100),
	@Fecha_Salida			char(10),
	@Fecha_Llegada			char(10),
	@id_U					char(8),
	@placa_Vehiculo			char(7),
	@id_CC					char(14)
)
as
	insert Solicitud_FichaSalida(numero_Solicitud,tipoActividad,Hora_Sal,Hora_Lleg,Kilometraje_Inic,Kilometraje_Final,Ruta,Fecha_Salida,Fecha_Llegada,id_U,placa_Vehiculo,id_CC)
	values(@numero_Solicitud,@tipoActividad,@Hora_Sal,@Hora_Lleg,@Kilometraje_Inic,@Kilometraje_Final,@Ruta,@Fecha_Salida,@Fecha_Llegada,@id_U,@placa_Vehiculo,@id_CC)
go

--........Consulta de tabla Solicitud de ficha de salida........--
create procedure ConsultaSolicitudFichaSalida
as
	select * from Solicitud_FichaSalida
go

--........Actualizar Solicitud de ficha de salida........--
create procedure actualizarSolicitud_Ficha_Salida(
	@numero_Solicitud		char(4),
	@tipoActividad			varchar(100),
	@Hora_Sal				char(5),
	@Hora_Lleg				char(5),
	@Kilometraje_Inic		int,
	@Kilometraje_Final		int,
	@Ruta					varchar(100),
	@Fecha_Salida			char(10),
	@Fecha_Llegada			char(10),
	@id_U					char(8),
	@placa_Vehiculo			char(7),
	@id_CC					char(14)
)
as
	if(@numero_Solicitud is not null)
	begin
		if(@tipoActividad is not null)
		begin
			update Solicitud_FichaSalida
			set tipoActividad=@tipoActividad
			where numero_Solicitud=@numero_Solicitud
		end
		if(@Hora_Sal is not null)
		begin
			update Solicitud_FichaSalida
			set Hora_Sal=@Hora_Sal
			where numero_Solicitud=@numero_Solicitud
		end
		if(@Hora_Lleg is not null)
		begin
			update Solicitud_FichaSalida
			set Hora_Lleg=@Hora_Lleg
			where numero_Solicitud=@numero_Solicitud
		end
		if(@Kilometraje_Inic is not null)
		begin
			update Solicitud_FichaSalida
			set Kilometraje_Inic=@Kilometraje_Inic
			where numero_Solicitud=@numero_Solicitud
		end
		if(@Kilometraje_Final is not null)
		begin
			update Solicitud_FichaSalida
			set Kilometraje_Final=@Kilometraje_Final
			where numero_Solicitud=@numero_Solicitud
		end
		if(@Ruta is not null)
		begin
			update Solicitud_FichaSalida
			set Ruta=@Ruta
			where numero_Solicitud=@numero_Solicitud
		end
		if(@Fecha_Salida is not null)
		begin
			update Solicitud_FichaSalida
			set Fecha_Salida=@Fecha_Salida
			where numero_Solicitud=@numero_Solicitud
		end
		if(@Fecha_Llegada is not null)
		begin
			update Solicitud_FichaSalida
			set Fecha_Llegada=@Fecha_Llegada
			where numero_Solicitud=@numero_Solicitud
		end
		if(@id_U is not null)
		begin
			update Solicitud_FichaSalida
			set id_U=@id_U
			where numero_Solicitud=@numero_Solicitud
		end
		if(@placa_Vehiculo is not null)
		begin
			update Solicitud_FichaSalida
			set placa_Vehiculo=@placa_Vehiculo
			where numero_Solicitud=@numero_Solicitud
		end
		if(@id_CC is not null)
		begin
			update Solicitud_FichaSalida
			set id_CC=@id_CC
			where numero_Solicitud=@numero_Solicitud
		end
	end
go

--........Borrar Solicitud_Ficha_Salida........--
create procedure borrarSolicitud_Ficha_Salida(
	@numero_Solicitud		char(4)
)
as
	delete from Solicitud_FichaSalida where numero_Solicitud=@numero_Solicitud
go

--........Insertar Vehículo........--
create procedure insertarVehiculos(
	@placa				char(7),
	@departamento		char(14),
	@descripcion		varchar(100),
	@modelo				int,
	@numero_chasis		char(17),
	@numero_Motor		varchar(15),
	@cilindros			tinyint,
	@cilindrada			varchar(7),
	@color				varchar(20),
	@puertas			tinyint,
	@tipo_combustible	char(7),
	@marca				varchar(15),
	@estilo				varchar(30),
	@fecha_compra		char(10),
	@kilometraje		int,
	@capacidad			tinyint,
	@velocidades		char(1),
	@id_garantia		int,
	@cedula_jur_ag		varchar(20),
	@sucursal			varchar(20)
)
as
	insert vehiculos(placa,departamento,descripcion,modelo,numero_chasis,numero_Motor,cilindros,cilindrada,color,puertas,tipo_combustible,marca,estilo,fecha_compra,kilometraje,capacidad,velocidades,id_garantia,cedula_jur_ag,sucursal)
	values (@placa,@departamento,@descripcion,@modelo,@numero_chasis,@numero_Motor,@cilindros,@cilindrada,@color,@puertas,@tipo_combustible,@marca,@estilo,@fecha_compra,@kilometraje,@capacidad,@velocidades,@id_garantia,@cedula_jur_ag,@sucursal)
go

--........Consulta de tabla Vehiculo........--
create procedure ConsultaVehiculos
as
	select * from vehiculos
go

--........Actualizar Vehículo........--
create procedure actualizarVehiculos(
	@placa				char(7),
	@departamento		char(14),
	@descripcion		varchar(100),
	@modelo				tinyint,
	@numero_chasis		char(17),
	@numero_Motor		varchar(15),
	@cilindros			tinyint,
	@cilindrada			varchar(7),
	@color				varchar(20),
	@puertas			tinyint,
	@tipo_combustible	char(7),
	@marca				varchar(15),
	@estilo				varchar(30),
	@fecha_compra		char(10),
	@kilometraje		int,
	@capacidad			tinyint,
	@velocidades		char(1),
	@id_garantia		int,
	@cedula_jur_ag		varchar(20),
	@sucursal			varchar(20)
)
as
	if(@placa is not null)
	begin
		if(@departamento is not null)
		begin
			update vehiculos
			set departamento=@departamento
			where placa=@placa
		end
		if(@descripcion is not null)
		begin
			update vehiculos
			set descripcion=@descripcion
			where placa=@placa
		end
		if(@modelo is not null)
		begin
			update vehiculos
			set modelo=@modelo
			where placa=@placa
		end
		if(@numero_chasis is not null)
		begin
			update vehiculos
			set numero_chasis=@numero_chasis
			where placa=@placa
		end
		if(@numero_Motor is not null)
		begin
			update vehiculos
			set numero_Motor=@numero_Motor
			where placa=@placa
		end
		if(@cilindros is not null)
		begin
			update vehiculos
			set cilindros=@cilindros
			where placa=@placa
		end
		if(@cilindrada is not null)
		begin
			update vehiculos
			set cilindrada=@cilindrada
			where placa=@placa
		end
		if(@color is not null)
		begin
			update vehiculos
			set color=@color
			where placa=@placa
		end
		if(@puertas is not null)
		begin
			update vehiculos
			set puertas=@puertas
			where placa=@placa
		end
		if(@tipo_combustible is not null)
		begin
			update vehiculos
			set tipo_combustible=@tipo_combustible
			where placa=@placa
		end
		if(@marca is not null)
		begin
			update vehiculos
			set marca=@marca
			where placa=@placa
		end
		if(@estilo is not null)
		begin
			update vehiculos
			set estilo=@estilo
			where placa=@placa
		end
		if(@fecha_compra is not null)
		begin
			update vehiculos
			set fecha_compra=@fecha_compra
			where placa=@placa
		end
		if(@kilometraje is not null)
		begin
			update vehiculos
			set kilometraje=@kilometraje
			where placa=@placa
		end
		if(@capacidad is not null)
		begin
			update vehiculos
			set capacidad=@capacidad
			where placa=@placa
		end
		if(@velocidades is not null)
		begin
			update vehiculos
			set velocidades=@velocidades
			where placa=@placa
		end
		if(@id_garantia is not null)
		begin
			update vehiculos
			set id_garantia=@id_garantia
			where placa=@placa
		end
		if(@cedula_jur_ag is not null)
		begin
			update vehiculos
			set cedula_jur_ag=@cedula_jur_ag
			where placa=@placa
		end
		if(@sucursal is not null)
		begin
			update vehiculos
			set sucursal=@sucursal
			where placa=@placa
		end		
	end
go

--........Borrar Vehículos........--
create procedure borrarVehiculos(
	@placa				char(7)
)
as
	delete from vehiculos where placa=@placa
go

--........Insertar Garantia........--
create procedure insertarGarantia(
	@cedula_jur_ag	varchar(20),
	@km_Vencimiento		int,
	@fecha_Vencimiento	char(10)
)
as	
	insert garantia(cedula_jur_ag,km_Vencimiento,fecha_Vencimiento)
	values(@cedula_jur_ag,@km_Vencimiento,@fecha_Vencimiento)
go

--........Consulta de tabla Garantia........--
create procedure ConsultaGarantia
as
	select * from garantia
go

--........Actualizar Garantia........--
create procedure actualizarGarantia(
	@id_Garantia		int,
	@km_Vencimiento		int,
	@fecha_Vencimiento	char(10)
)
as
	if(@id_Garantia is not null)
	begin
		if(@km_Vencimiento is not null)
		begin
			update garantia
			set km_Vencimiento=@km_Vencimiento
			where id_Garantia=@id_Garantia
		end
		if(@fecha_Vencimiento is not null)
		begin
			update garantia
			set fecha_Vencimiento=@fecha_Vencimiento
			where id_Garantia=@id_Garantia
		end
	end
go

--........Borrar  Garantia........--
create procedure borrarGarantia(
	@id_Garantia		int
)
as
	delete from garantia where id_Garantia=@id_Garantia
go

--........Insertar Agencia........--
create procedure insertarAgencia(
	@cedula_Jur_Ag	varchar(20),
	@direccion		varchar(150),
	@telefono		varchar(14),
	@email			varchar(14),
	@nombre			varchar(20)
)
as
	insert Agencia(cedula_Jur_Ag,direccion, telefono,email,nombre)
	values(@cedula_Jur_Ag,@direccion,@telefono,@email,@nombre)
go

--........Consulta de tabla Agencia........--
create procedure ConsultaAgencia
as
	select * from agencia
go

--........Actualizar Agencia........--
create procedure actualizarAgencia(
	@cedula_Jur_Ag	varchar(20),
	@direccion		varchar(150),
	@telefono		varchar(14),
	@email			varchar(14),
	@nombre			varchar(20)
)
as
	if(@cedula_Jur_Ag is not null)
	begin
		if(@direccion is not null)
		begin
			update agencia
			set direccion=@direccion
			where cedula_Jur_Ag=@cedula_Jur_Ag
		end
		if(@telefono is not null)
		begin
			update agencia
			set telefono=@telefono
			where cedula_Jur_Ag=@cedula_Jur_Ag
		end
		if(@email is not null)
		begin
			update agencia
			set email=@email
			where cedula_Jur_Ag=@cedula_Jur_Ag
		end
		if(@nombre is not null)
		begin
			update agencia
			set nombre=@nombre
			where cedula_Jur_Ag=@cedula_Jur_Ag
		end
	end
go

--........Borrar Agencia........--
create procedure borrarAgencia(
	@cedula_Jur_Ag	varchar(20)
)
as
	delete from agencia where cedula_jur_ag=@cedula_Jur_Ag
go

--[[[[[[[  AQUÍ SE UTILIZA UNA TRANSACCIÓN  ]]]]]]]
--........Insertar Mantenimiento........--
create procedure insertarMantenimiento(
 @id_Mant	 int,
 @monto	 int,
 @detalle	 varchar(150),
 @tipoMantenimento varchar(13),
 @numero_Factura	 int,
 @fecha	 char(10),
 @cedula_jur_talleres varchar(20),
 @cedula_jur_ag varchar(20),
 @placa_Vehiculo	 char(7)
)
as
 begin tran
 if(@cedula_jur_talleres is not null and @cedula_jur_ag is null)
 begin
 	if(@monto is not null and @monto>0)
 	begin
	 commit tran
 	 insert Mantenimiento(monto,detalle,tipoMantenimento,numero_Factura,fecha,cedula_jur_talleres,cedula_jur_ag,placa_Vehiculo)
 	 values(@monto,@detalle,@tipoMantenimento,@numero_Factura,@fecha,@cedula_jur_talleres,null,@placa_Vehiculo)
 	end
 	else
 	begin
	 rollback tran
 	 raiserror ('Debe de ingresarse el monto del mantenimiento(monto mayor a cero)',5,1)
 	end
 end
 else if(@cedula_jur_talleres is null and @cedula_jur_ag is not null)
 begin
	commit tran
 	insert Mantenimiento(detalle,tipoMantenimento,numero_Factura,fecha,cedula_jur_ag,placa_Vehiculo)
 	values(@detalle,@tipoMantenimento,@numero_Factura,@fecha,@cedula_jur_ag,@placa_Vehiculo)	 
 end
 	else 
 begin
	rollback tran
 	raiserror ('Debe ingresar la cedula juridiga de agencia o taller',4,1)
 end
go

--........Consulta de tabla Mantenimiento........--
create procedure ConsultaMantenimiento
as
	select * from mantenimiento
go

--........Actualizar Mantenimiento........--
create procedure actualizarMantenimiento(
	@id_Mant				int,
	@monto					int,
	@detalle				varchar(150),
	@tipoMantenimento		varchar(13),
	@numero_Factura			int,
	@fecha					char(10),
	@cedula_jur_talleres	varchar(20),
	@cedula_jur_ag			varchar(20),
	@placa_Vehiculo			char(7)
)
as
	if(@id_Mant is not null)
	begin
		if(@monto is not null)
		begin
			update mantenimiento
			set monto=@monto
			where id_Mant=@id_Mant
		end
		if(@detalle is not null)
		begin
			update mantenimiento
			set detalle=@detalle
			where id_Mant=@id_Mant
		end
		if(@tipoMantenimento is not null)
		begin
			update mantenimiento
			set tipoMantenimento=@tipoMantenimento
			where id_Mant=@id_Mant
		end
		if(@numero_Factura is not null)
		begin
			update mantenimiento
			set numero_Factura=@numero_Factura
			where id_Mant=@id_Mant
		end
		if(@fecha is not null)
		begin
			update mantenimiento
			set fecha=@fecha
			where id_Mant=@id_Mant
		end
		if(@cedula_jur_talleres is not null)
		begin
			update mantenimiento
			set cedula_jur_talleres=@cedula_jur_talleres
			where id_Mant=@id_Mant
		end
		if(@cedula_jur_ag is not null)
		begin
			update mantenimiento
			set cedula_jur_ag=@cedula_jur_ag
			where id_Mant=@id_Mant
		end
		if(@placa_Vehiculo is not null)
		begin
			update mantenimiento
			set placa_Vehiculo=@placa_Vehiculo
			where id_Mant=@id_Mant
		end
	end
go

--........Borrar Mantenimiento........--
create procedure borrarMantenimiento(
	@id_Mant				int
)
as
	delete from mantenimiento where id_Mant=@id_Mant
go

--........Insertar Talleres........--
create procedure insertarTalleres(
	@cedula_Jur_Talleres	varchar(20),
	@nombre					varchar(15),
	@especialidad			varchar(50),
	@email					varchar(80),
	@direccion				varchar(150),
	@telefono				varchar(14)
)
as
	insert Talleres(cedula_Jur_Talleres,nombre,especialidad, email,direccion,telefono)
	values(@cedula_Jur_Talleres,@nombre,@especialidad,@email,@direccion,@telefono)
go

--........Consulta de tabla Talleres........--
create procedure ConsultaTalleres
as
	select * from talleres
go

--........Actualizar Taller........--
create procedure actualizarTalleres(
	@cedula_Jur_Talleres	varchar(20),
	@nombre					varchar(15),
	@especialidad			varchar(50),
	@email					varchar(80),
	@direccion				varchar(150),
	@telefono				varchar(14)
)
as
	if(@cedula_Jur_Talleres is not null)
	begin
		if(@nombre is not null)
		begin
			update talleres
			set nombre=@nombre
			where cedula_jur_talleres=@cedula_Jur_Talleres
		end
		if(@especialidad is not null)
		begin
			update talleres
			set especialidad=@especialidad
			where cedula_jur_talleres=@cedula_Jur_Talleres
		end
		if(@email is not null)
		begin
			update talleres
			set email=@email
			where cedula_jur_talleres=@cedula_Jur_Talleres
		end
		if(@direccion is not null)
		begin
			update talleres
			set direccion=@direccion
			where cedula_jur_talleres=@cedula_Jur_Talleres
		end
		if(@telefono is not null)
		begin
			update talleres
			set telefono=@telefono
			where cedula_jur_talleres=@cedula_Jur_Talleres
		end
	end
go


--........Borrar Taller........--
create procedure borrarTalleres(
	@cedula_Jur_Talleres	varchar(20)
)
as
	delete from talleres where cedula_jur_talleres=@cedula_Jur_Talleres
go


/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
													CONSULTAS
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

------ Consultas
select Usuarios.nombre+ ' '+ Usuarios.apellido1+' '+ Usuarios.apellido2 as Nombre_completo, Usuarios.puesto, Solicitud_FichaSalida.numero_Solicitud, Solicitud_FichaSalida.placa_vehiculo
from usuarios inner join Solicitud_FichaSalida 
on Usuarios.id_U = Solicitud_FichaSalida.id_U
go

--1. Muestra los vehículos que todavía tienen garantía, esto se logra con la unión de la tabla vehículo y garantía, cuya garantía no se haya vencido con la respectiva fecha.
select placa, vehiculos.marca,vehiculos.modelo ,vehiculos.kilometraje,YEAR(GETDATE()) as fecha_Hoy, garantia.fecha_Vencimiento  
from vehiculos inner join garantia 
on vehiculos.id_garantia = garantia.id_Garantia and YEAR(GETDATE()) <=  fecha_Vencimiento
go

--2. Cantidad de días que le quedan de garantía, esto se logra con la unión de la tabla vehículo y garantía, cuya garantía no se haya vencido, con la fecha actual del sistema menos la fecha límite de la garantía vigente.
select placa, vehiculos.marca,vehiculos.modelo ,vehiculos.kilometraje,YEAR(GETDATE()) as fecha_Hoy, garantia.fecha_Vencimiento, YEAR(GETDATE()) - garantia.fecha_Vencimiento as dias
from vehiculos inner join garantia 
on vehiculos.id_garantia = garantia.id_Garantia and YEAR(GETDATE()) <=  fecha_Vencimiento
go

--3. Esta consulta se encuentra contenida en un Procedimiento que realiza una visualización de la información que posee un usuario, con la particularidad que los teléfonos los muestra concatenados en un solo arreglo de char
create procedure BuscarPersonas
(
	@id_U				char(8),
	@cedula				char(11),
	@nombre				varchar(20),
	@apellido1			varchar(20),
	@apellido2			varchar(20),
	@puesto				varchar(20),
	@estado				char(1)
)
as
select b.* , STUFF(	(SELECT  ', ' + a.telefono  AS [text()]
	from telefonos  a
	where a.id_U = b.cedula
	Order by a.id_U
	for xml PATH('')),1,1,''	) AS telefono
 from (select * from Usuarios 
	where	(id_U=@id_U or @id_U is null) and
			(cedula=@cedula or @cedula is null) and
			(nombre=@nombre or @nombre is null) and
			(apellido1=@apellido1 or @apellido1 is null) and
			(apellido2=@apellido2 or @apellido2 is null) and
			(puesto=@puesto or @puesto is null) and
			(estado=@estado or @estado is null)) b
--group by cedula
ORDER BY cedula
go

---- 4. Procedimiento para consultar los vehículos con sus respectivos mantenimientos y reparaciones en un lapso de tiempo
create procedure ConsultaIntervaloFechaReparacionesVehiculos(
	@fechaInicial	char(10),
	@fechaFinal		char(10),
	@consultaManRep	varchar(15)
)
as	
	declare @fechaI char(10),@fechaF char(10)
	select @FechaI = (SELECT convert(char(10), (SELECT convert(date, @fechaInicial, 105)))) 
	select @FechaF = (SELECT convert(char(10), (SELECT convert(date, @fechaFinal, 105)))) 
	select * from
	(select  VehMant.Id_Mant as "ID del Mantenimiento", VehMant.[Cedula Juridiga Vehiculo], VehMant.Departamento, VehMant.Cedula_jur_talleres as "Cedula Juridiga de Talleres", VehMant.Cedula_jur_ag as "Cedula Juridiga de Agencia", Nombre, VehMant.TipoMantenimento, VehMant.Detalle, VehMant.Fecha, VehMant.Monto from
		(select  MAN.Id_Mant, VEH.cedula_jur_ag as "Cedula Juridiga Vehiculo", VEH.Departamento,  MAN.Cedula_jur_talleres, MAN.cedula_jur_ag, MAN.Detalle, MAN.Fecha, MAN.Monto, MAN.TipoMantenimento from 
		vehiculos VEH inner join mantenimiento as MAN on VEH.placa=MAN.placa_vehiculo where MAN.tipoMantenimento=@consultaManRep)VehMant 
		inner join
		(select * from(
			select MAN.id_mant,TALL.nombre from
			mantenimiento MAN inner join talleres as TALL on MAN.cedula_jur_talleres=TALL.cedula_jur_talleres
			UNION
			select MAN.id_mant, AGEN.nombre from
			mantenimiento MAN inner join agencia as AGEN on MAN.cedula_jur_ag=AGEN.cedula_jur_ag)MANTallAgen)MANTAgTa on VehMant.id_mant=MANTAgTa.id_mant)ManRep
	where ((SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, ManRep.fecha, 105))))) AS DiffDate)<=(SELECT DATEDIFF(day,@FechaI,@fechaF) AS DiffDate)) and (SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, ManRep.fecha, 105))))) AS DiffDate)>=0
	order by [Cedula Juridiga Vehiculo]
go


---- 5. Procedimiento para consultar los viáticos dentro de un intervalo de fechas, se logra mandando una fecha inicial y una fecha final las cuales se utilizaran para el intervalo deseado. 
create procedure ConsultaIntervaloFechaViaticos(
	@fechaInicial	char(10),
	@fechaFinal		char(10)
)
as	
	declare @fechaI char(10),@fechaF char(10)
	select @FechaI = (SELECT convert(char(10), (SELECT convert(date, @fechaInicial, 105)))) 
	select @FechaF = (SELECT convert(char(10), (SELECT convert(date, @fechaFinal, 105)))) 
	select * from viaticos
	where ((SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, viaticos.fecha, 105))))) AS DiffDate)<=(SELECT DATEDIFF(day,@FechaI,@fechaF) AS DiffDate)) and (SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, viaticos.fecha, 105))))) AS DiffDate)>=0
	order by fecha
go

---- 6. Procedimiento para consultar los viáticos de los usuarios dentro de un intervalo de fechas, esta es muy similar a la anterior solo que se busca los viáticos de todos lo usuarios.
create procedure UsuariosViaticosSalida(
	@fechaInicial	char(10),
	@fechaFinal		char(10)
)
as	
	declare @fechaI char(10),@fechaF char(10)
	select @FechaI = (SELECT convert(char(10), (SELECT convert(date, @fechaInicial, 105)))) 
	select @FechaF = (SELECT convert(char(10), (SELECT convert(date, @fechaFinal, 105)))) 
	
	select USU.id_U,USU.nombre+' '+USU.apellido1+' '+USU.apellido2 as Nombre, USU.cedula,VIAT.id_V as "ID Viatico", VIAT.Detalle, VIAT.monto, VIAT.Fecha from
		(select * from viaticos
		where ((SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, viaticos.fecha, 105))))) AS DiffDate)<=(SELECT DATEDIFF(day,@FechaI,@fechaF) AS DiffDate)) and (SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, viaticos.fecha, 105))))) AS DiffDate)>=0
		)VIAT inner join
		(select * from Usuarios)USU on VIAT.id_U=USU.id_U
		order by nombre
go

select * from viaticos order by fecha
exec UsuariosViaticosSalida'10-02-2013','21-04-2013'
go

---- 7. Procedimiento para consultar el monto total gastado en viáticos de los usuarios dentro de un intervalo de fechas.
create procedure UsuariosMontoViaticos(
	@fechaInicial	char(10),
	@fechaFinal		char(10)
)
as	
	declare @fechaI char(10),@fechaF char(10), @monto int
	select @FechaI = (SELECT convert(char(10), (SELECT convert(date, @fechaInicial, 105)))) 
	select @FechaF = (SELECT convert(char(10), (SELECT convert(date, @fechaFinal, 105)))) 
	
	select USU.[Nombre Completo], sum(monto) as "Monto Gasto" from
		(select * from viaticos
		where ((SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, viaticos.fecha, 105))))) AS DiffDate)<=(SELECT DATEDIFF(day,@FechaI,@fechaF) AS DiffDate)) and (SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, viaticos.fecha, 105))))) AS DiffDate)>=0
		)VIAT inner join
		(select id_U,nombre+' '+apellido1+' '+apellido2 as "Nombre Completo" from Usuarios)USU on VIAT.id_U=USU.id_U
	group by [Nombre Completo]
go

select * from viaticos order by fecha
exec UsuariosMontoViaticos'10-02-2013','21-04-2013'
go

---- 8. Procedimiento para consultar el monto gastado en el combustible de los vehículos dentro de un intervalo de fechas
create procedure UsuariosMontoCombustibleVehiculos(
	@fechaInicial	char(10),
	@fechaFinal		char(10)
)
as	
	declare @fechaI char(10),@fechaF char(10), @monto int
	select @FechaI = (SELECT convert(char(10), (SELECT convert(date, @fechaInicial, 105)))) 
	select @FechaF = (SELECT convert(char(10), (SELECT convert(date, @fechaFinal, 105)))) 
	
	select VEH.Placa, VEH.tipo_combustible as "Tipo de Combustible",sum(gasto_combustible) as "Gasto de Combustible", sum(gasto_efectivo)as "Gasto en Efectivo" from
		(select gasto_combustible, gasto_efectivo, placa from gasto_combustible
		where ((SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, gasto_combustible.fecha, 105))))) AS DiffDate)<=(SELECT DATEDIFF(day,@FechaI,@fechaF) AS DiffDate)) and (SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, gasto_combustible.fecha, 105))))) AS DiffDate)>=0
		)COMB inner join
		(select placa, tipo_combustible from vehiculos)VEH on VEH.placa=COMB.placa
	group by VEH.placa, VEH.tipo_combustible
go
select * from gasto_combustible order by fecha
exec UsuariosMontoCombustibleVehiculos '11-02-2013','10-11-2013'
go

---- 9. Procedimiento para consultar toda la información de las fichas de salida, además del nombre completo del chofer y la capacidad del vehículo  en un rango de fechas, se logra con la unión de las tablas, vehículos, solicitud de ficha salida y usuario
create procedure SalidaViaje(
	@fechaInicial	char(10),
	@fechaFinal		char(10)
)
as	
	declare @fechaI char(10),@fechaF char(10)
	select @FechaI = (SELECT convert(char(10), (SELECT convert(date, @fechaInicial, 105)))) 
	select @FechaF = (SELECT convert(char(10), (SELECT convert(date, @fechaFinal, 105)))) 
	select Numero_Solicitud as "Numero de Solicitud",TipoActividad, Hora_Sal, Hora_Lleg, Fecha_Salida,Fecha_Llegada, Ruta, Placa, Departamento, Descripcion, Capacidad, USU.Id_U as "ID del Chofer", USU.[Nombre Completo] from
		(select FICHA.numero_Solicitud,FICHA.tipoActividad, FICHA.Hora_Sal, FICHA.Hora_Lleg, FICHA.Fecha_Llegada, FICHA.Fecha_Salida,ruta,VEH.Placa, VEH.departamento,VEH.descripcion,VEH.capacidad, FICHA.id_U from
			(select numero_Solicitud,id_U,tipoActividad, Hora_Sal, Hora_Lleg, ruta, Fecha_Llegada, Fecha_Salida,placa_vehiculo from Solicitud_FichaSalida
			where ((SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, Solicitud_FichaSalida.Fecha_Salida, 105))))) AS DiffDate)<=(SELECT DATEDIFF(day,@FechaI,@fechaF) AS DiffDate)) and (SELECT DATEDIFF(day,@FechaI,(SELECT convert(char(10), (SELECT convert(date, Solicitud_FichaSalida.Fecha_Salida, 105))))) AS DiffDate)>=0
			)FICHA inner join
			(select placa, departamento,descripcion,capacidad from vehiculos)VEH on VEH.placa=FICHA.placa_vehiculo)FichaVehiculo
			inner join 
			(select cedula, id_U, nombre+' '+apellido1+' '+apellido2 as "Nombre Completo" from Usuarios)USU on FichaVehiculo.id_U=USU.id_U
go

select * from Solicitud_FichaSalida order by Fecha_Salida
exec SalidaViaje '18-02-2013','22-03-2013'
go


---- 10 consulta que muestra los usuarios con sus telefonos y los diferentes tipos de licencia ----
select U.id_U,nombre+' '+apellido1+' '+apellido2 'Nombre completo', telefono,tipo from 
		usuarios U 
		inner join telefonos T on U.id_U=T.id_U
		inner join Tipos_Licencia TL on U.id_U=TL.id_U 
		order by u.id_U

go
/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
													CREACION DE TRIGGERS
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/
--[[[[[[[  AQUÍ SE UTILIZA UNA TRANSACCIÓN  ]]]]]]]
--Este trigger permite insertar horas extra si ha realizado más de las 9 horas base de trabajo hábiles incluyendo hora de almuerzo, sino no se inserta y se hace un rollback, también imprime las horas y minutos de trabajo.
create trigger Trig_Horas_Extra 
	on  horas_extra 
	for insert 
	as 
		declare @horas int
		declare @horaI char(5)
		declare @horaF char(5)
		declare @horas_e varchar(20)

		select @horaI=(select hora_inicio from inserted)
		select @horaF=(select hora_fin from inserted)
		select @horas= DATEDIFF(MINUTE,@horaI,@horaF)

		begin
			select @horas_e=(convert(varchar,convert(int,@horas/60.0))+' Horas '+convert (varchar,convert(int,(@horas/60.0-convert(int,@horas/60.0))*60))+' Mins ')
			print @horas_e
		end
	if(@horas<570)
		begin
			raiserror('No se puede insertar horas extras porque no a cumplido con las 9 horas laborales sumando la hora de almuerzo',1,2)
			rollback transaction
		end		
go

--[[[[[[[  AQUÍ SE UTILIZA UNA TRANSACCIÓN  ]]]]]]]
--Este trigger se dispara cuando se inserta una nueva solicitud de ficha salida, y se actualiza el kilometraje del vehículo, según el kilometraje de llegada que se apunto en la ficha.
create  trigger Trig_actualizar_kilometraje 
	on Solicitud_FichaSalida
	for insert
	as
	begin tran
	declare @placa	char(7)
	declare @kil	int

	select @placa=(select placa_vehiculo from inserted)
	select @kil=(select Kilometraje_Final from inserted)
	if(@kil > (select kilometraje from vehiculos where placa=@placa))
		begin
			commit tran
			update vehiculos set vehiculos.kilometraje=@kil  where vehiculos.placa=@placa
		end
	else
		begin
			rollback tran
			raiserror('No se puede insertar un kilometraje inferior al ya existente',3,1)
		end
go

--Triger que al haber horas extra inserta la hora extra y un detalle en la actividad
create trigger Detalle_Extra 
	on horas_extra 
	for insert 
	as 
		declare @horas int , @cantidad int
		declare @horaI char(5)
		declare @horaF char(5)
		declare @horas_e varchar(20),@detalle varchar(10)

		select @horaI=(select hora_inicio from inserted)
		select @horaF=(select hora_fin from inserted)
		select @horas= DATEDIFF(MINUTE,@horaI,@horaF)

		declare @oficio char(4)
		declare @fecha   Tfecha

		declare @id_CC	char(14)
		declare @id_U	char(8)
		declare @actividad varchar(30)


		begin
			select @cantidad= convert(int,@horas/60.0) + convert(int,(@horas/60.0-convert(int,@horas/60.0))*60)
		end
	if(@cantidad>570)
		begin

		select @cantidad = @cantidad - 570
		if(@cantidad > 60)
		begin 

		select @detalle =  'Extra: horas '+(@cantidad /60 )+'minutos'+(@cantidad %60 )
		select @actividad = @actividad+@detalle 

		insert horas_Extra(oficio_Aprobacion,hora_Inicio,hora_fin,fecha,id_CC,id_U,actividad)
		values(@oficio,@horaI,@horaF,@fecha,@id_CC,@id_U,@actividad)
		
		end  

		else
		
		begin 
		select @detalle = 'minutos extra '+@cantidad
		select @actividad = @actividad+@detalle 

		insert horas_Extra(oficio_Aprobacion,hora_Inicio,hora_fin,fecha,id_CC,id_U,actividad)
		values(@oficio,@horaI,@horaF,@fecha,@id_CC,@id_U,@actividad)
		
		end	
			
end 

go

/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
											INFORMACION DE PRUEBA
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

----------------------Usuarios------------------

exec insertarUsuarios '00000001','0-0000-0001','Leonardo','Víquez', 'Acuña','04-11-1970','M','Ciudad Quesada','leoviquez@gmail.com','Chofer','A','Transporte'
exec insertarUsuarios '00000002','0-0000-0002','Gaudy','Esquivel', 'Vega','11-09-1950','F','Florencia','Gaudy@gmail.com','Chofer','A','Transporte'
exec insertarUsuarios '00000003','0-0000-0003','Rita','Saenz', 'Días','03-01-1980','F','Santa Clara','Rita@gmail.com','Chofer','A','Transporte'
exec insertarUsuarios '00000004','0-0000-0004','Juaquin','Angulo', 'Peña','04-02-1989','M','La Vega','Juaquin@gmail.com','Chofer','A','Transporte'
exec insertarUsuarios '00000005','0-0000-0005','Marcos','Días', 'Vindas','11-11-1970','M','Aguas Zarcas','Marcos@gmail.com','Chofer','A','Transporte'
GO

------------Telefonos---------------
exec insertarTelefonos '00000001','8895-3002'
exec insertarTelefonos '00000001','2401-3109'
exec insertarTelefonos '00000002','2000-0001'
exec insertarTelefonos '00000003','2000-0002'
exec insertarTelefonos '00000005','8000-0002'
exec insertarTelefonos '00000005','6000-0003'
exec insertarTelefonos '00000005','2000-0004'

---------------Tipos_Licencia-----------------
exec insertarTipos_Licencia '00000001','B1'
exec insertarTipos_Licencia '00000002','B2'
exec insertarTipos_Licencia '00000003','D1'
exec insertarTipos_Licencia '00000004','C4'
exec insertarTipos_Licencia '00000005','D3'
exec insertarTipos_Licencia '00000005','B2'

-------------------Viaticos----------------
exec insertarViaticos '','desayuno','04-04-2013','3000','00000001'
exec insertarViaticos '','desayuno','04-03-2013','2000','00000001'
exec insertarViaticos '','estadia','11-02-2012','10000','00000004'
exec insertarViaticos '','estadia','04-02-2013','15000','00000005'
exec insertarViaticos '','almuerzo','02-01-2013','3500','00000002'

--------------Centro_Costos---------------
exec insertarCentro_Costo '0000-0000-0001','Computacion'
exec insertarCentro_Costo '0000-0000-0002','Transporte'
exec insertarCentro_Costo '0000-0000-0003','Produccion'
exec insertarCentro_Costo '0000-0000-0004','Agronomia'
exec insertarCentro_Costo '0000-0000-0005','Administracion'

--------------Horas_Extra--------------------
exec insertarHoras_Extras '1111','07:00','20:00','04-03-2013','0000-0000-0001','00000001','gira'
exec insertarHoras_Extras '2222','07:00','20:00','11-03-2013','0000-0000-0002','00000002','gira'
exec insertarHoras_Extras '3333','07:00','18:00','02-04-2013','0000-0000-0003','00000003','gira'
exec insertarHoras_Extras '6666','07:00','21:00','04-06-2013','0000-0000-0002','00000001','gira'

------------Agencia----------------------
exec insertarAgencia '7688-8887-77','San Jose','2435-3333','sssss@hotmail.com','Nissan'
exec insertarAgencia '6666-6666-66','Heredia','2455-3444','eeee@gmai.com','Nissan'
exec insertarAgencia '7888-8888-88','San Jose','2435-5555','Pedro@hotmail.com','Mitsubishi'
exec insertarAgencia '3444-4444-44','San Carlos','2460-4565','pppp@gmail.com','Toyota'

-----------Garantia-----------------
exec insertarGarantia '7688-8887-77','7000','01-01-2015'
exec insertarGarantia '6666-6666-66','8000','01-01-2015'
exec insertarGarantia '7888-8888-88','7000','05-02-2014'
exec insertarGarantia '3444-4444-44','7500','05-02-2014'

------------Vehiculos-------------------------
exec insertarVehiculos '222-222','Tansporte','Buseta','2012','363de4453456yhg66','ffgty5556gfh','4','1664','rojo','4','Diesel','Nissan','lp500','02-20-2010','2000','24','M','1','7688-8887-77','San Jose' 
exec insertarVehiculos '333-333','Trasporte','Buseta','2010','23e44556677yuttyh','dscew333','4','2000','azul','4','Diesel','Nissan','lp600','04-10-2011','1500','16','M','2','6666-6666-66','Heredia' 
exec insertarVehiculos '444-444','Transporte','Automovil','2012','3111234wwd344rfgh','vfddvf334','4','2500','blanco','2','Regular','Mitsubishi','lancer','05-30-2010','1000','4','A','3','7888-8888-88','San Jose' 
exec insertarVehiculos '666-666','Computacion','Automovil','2009','34567890iuhyy6785','324fsfsdd','4','1789','azul','4','Super','Toyota','tecel','01-22-2013','1500','4','M','4','3444-4444-44','San Carlos' 
	
---------------Gasto_Combustible---------------------
exec insertarGasto_Combustible '','4','04-02-2013','5500','2345','333-333','00000001'
exec insertarGasto_Combustible '','6','04-01-2013','6000','4544','222-222','00000002'
exec insertarGasto_Combustible '','10','11-01-2013','8000','6666','222-222','00000002'
exec insertarGasto_Combustible '','5','02-02-2013','10000','8777','444-444','00000003'
exec insertarGasto_Combustible '','6','02-03-2013','6000','1221','666-666','00000004'
exec insertarGasto_Combustible '','0','02-05-2013','6000','1221','666-666','00000004'

-----------------Solicitud_Ficha_Salida-----------------
exec insertarSolicitud_Ficha_Salida '1111','gira','08:00','20:00','5000','5300','San Carlos, Tilaran, Guatuso, Guanacaste','03-04-2013','04-04-2013','00000002','333-333','0000-0000-0002'
exec insertarSolicitud_Ficha_Salida '2222','gira','08:00','19:00','3657','4000','San Carlos, Bajo Rodriguez, San Ramon,San Jose','05-11-2012','05-11-2013','00000002','222-222','0000-0000-0002'
exec insertarSolicitud_Ficha_Salida '3333','gira','09:00','18:00','1045','5400','San Carlos, Bajo Rodriguez, San Ramon, Alajuela','02-03-2013','02-03-2013','00000003','222-222','0000-0000-0002'
exec insertarSolicitud_Ficha_Salida '4444','Transporte entre sede','12:00','17:00','12000','12400','San carlos, Cartago','03-12-2013','04-12-2013','00000001','666-666','0000-0000-0001'
exec insertarSolicitud_Ficha_Salida '5555','Transporte entre sede','16:00','20:30','3000','3500','San Carlos, San Jose','02-04-2013','02-04-2013','00000004','444-444','0000-0000-0002'

---------------talleres---------------------
exec insertarTalleres '222333','Quincho','Frenos, aceites','quincho@hotmail.com','Ciudad Quesada','2333-4455'
exec insertarTalleres '333444','Chavez','Frenos, parabrisas, muflas','chavez@gmail.com','Ciudad Quesada','2460-8888'


------------Mantenimiento------------------
exec insertarMantenimiento '','5666','cambio de aceite','Mantenimiento','3456','03-03-2013','222333',null,'222-222'
exec insertarMantenimiento '','100000','cambio de frenos','Reparacion','4566','05-06-2013',null,'3444-4444-44','222-222'
exec insertarMantenimiento '',null,'cambio de frenos','Reparacion','4551','03-02-2013',null,'3444-4444-44','666-666'
GO


/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
												VISTAS
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

--Vista que muestra las Giras que han realizado los choferes que están activos en la base de datos. se realizaa con launiónn de las tablas Solicitud_FichaSalida y usuarios y con la restricción de si el chofer está actualmente activo.
CREATE VIEW VistaChoferViajes
AS
	SELECT  S.*, u.nombre+' '+u.apellido1+' '+u.apellido2 as Chofer
	FROM	Usuarios U 
	inner join 
	Solicitud_FichaSalida S ON S.id_U=U.id_U and U.puesto='Chofer' and U.estado='A'
GO

--Vista que nuestra toda la información de los Choferes y en el caso de los teléfonos los concatena en un solo campo
CREATE VIEW VistaUsuarios
as
	select U.* , STUFF(	(SELECT  ', ' + T.telefono  AS [text()]
		from telefonos  T
		where T.id_U = U.id_U
		Order by T.id_U
		for xml PATH('')),1,1,''	) AS telefono
		from (select * from Usuarios ) U
go

--Vista que muestra lo que se ha gastado en reparación y mantenimiento en cada taller con respecto a cada vehículo
create view VistGastoTallerV
as
		select DISTINCT  v.placa placa,t.cedula_jur_talleres, t.nombre NomTaller, MT.monto2 as Costo from
		vehiculos V 
		inner join
		mantenimiento m on m.placa_vehiculo=v.placa and m.monto is not null
		inner join 
		talleres t on m.cedula_jur_talleres= t.cedula_jur_talleres	
		inner join
		(select ma.placa_vehiculo, ma.cedula_jur_talleres,sum(monto) monto2
		from mantenimiento ma
		group by ma.placa_vehiculo,ma.cedula_jur_talleres) as MT on MT.placa_vehiculo=v.placa and mt.cedula_jur_talleres=t.cedula_jur_talleres
							
go

--Muestra las Horas extras que se acumularon en cada Viaje
create view VistaHoraExtrasViaje
as
SELECT        s.numero_Solicitud,s.id_U Chofer, h.fecha AS FechaHoraExtra, h.hora_inicio, h.hora_fin, h.total
FROM            Solicitud_FichaSalida AS s 
				INNER JOIN
                Usuarios AS u ON u.id_U = s.id_U 
				INNER JOIN
                (SELECT        oficio_Aprobacion, hora_inicio, hora_fin, fecha, id_CC, id_U, actividad, DATEDIFF(MINUTE, hora_inicio, hora_fin) AS total
                 FROM            horas_extra AS h1) AS h ON h.id_CC = s.id_CC AND CONVERT(date, s.Fecha_Salida) <= CONVERT(date, h.fecha) AND CONVERT(date,s.Fecha_Llegada) >= CONVERT(date, h.fecha)
go

--Se suma los viáticos que se acumularon en cada Viaje y los muestra con el nombre completo del chofer y la información del correspondiente de la ficha del viaje.
create view VistaViaticoViaje
as
	select ss.*,nombre+' '+apellido1+' '+apellido2 NombreChofer,sv.Total  from
	Solicitud_FichaSalida ss
	inner join 
	Usuarios u on ss.id_U=u.id_U
	inner join
	(select s.numero_Solicitud, sum(monto) Total from
	Solicitud_FichaSalida s
	inner join
	viaticos v on s.id_U=v.id_U  AND CONVERT(date, s.Fecha_Salida) <= CONVERT(date, v.fecha) AND CONVERT(date,s.Fecha_Llegada) >= CONVERT(date, v.fecha)
	group by s.numero_Solicitud) sv on sv.numero_Solicitud=ss.numero_Solicitud
go

/*+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
													CURSORES
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

--Su funcionalidad es hacer un recorrido en la tabla de garantía para buscar la fecha que sea inferior a la fecha del sistema, si la fecha es superior se realizará el borrado de esa garantía
create procedure FinGarantiaFecha
as
Declare 
	@id_Garantia		int

Declare ListaGarantia Cursor
For 
	select id_Garantia from garantia
Open ListaGarantia
	Fetch next from ListaGarantia Into @id_Garantia
	While @@fetch_status=0
	Begin
		if(CONVERT(date, (select fecha_Vencimiento from garantia g where g.id_Garantia=@id_Garantia))<=  (select CONVERT(date, GETDATE())))
			begin
				 exec borrarGarantia @id_Garantia
			end
		fetch next from ListaGarantia Into @id_Garantia
	End
Close ListaGarantia
Deallocate ListaGarantia
GO

--Su funcionalidad es hacer un recorrido en la tabla de vehículos para buscar la Kilometraje de cada vehículo que sea inferior al Kilometraje de la garantía que corresponde a ese , si la Kilometraje es superior se realizará el borrado de esa garantía.
create procedure FinGarantiaKM
as
	Declare 
		@id_Garantia		int

	Declare ListaGarantia Cursor
	For 
		select id_Garantia from garantia
	Open ListaGarantia
		Fetch next from ListaGarantia Into @id_Garantia
		While @@fetch_status=0
		Begin
			if((select km_Vencimiento from garantia g where g.id_Garantia=@id_Garantia)<=(select v.kilometraje from vehiculos V where v.id_Garantia=@id_Garantia))
				begin
					 exec borrarGarantia @id_Garantia
				end
			fetch next from ListaGarantia Into @id_Garantia
		End
	Close ListaGarantia
	Deallocate ListaGarantia
GO
select * from vehiculos