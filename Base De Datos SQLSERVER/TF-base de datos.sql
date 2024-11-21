
--                                         CREAR Y USAR LA BASE DE DATOS

create database MovimientosBanco
use MovimientosBanco
-----------------------------------------------------------------------------------------
--                                         CREAR TABLAS

-- Crear la tabla BANCO
CREATE TABLE BANCO (
    cod_banco INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50)  not null,
    direccion VARCHAR(100)  not null,
    localidad VARCHAR(100)  not null
)
go

-- Crear la tabla SUCURSAL
CREATE TABLE SUCURSAL (
    nro_sucursal INT PRIMARY KEY IDENTITY(1,1),
    cod_banco INT not null,
    direccion VARCHAR(100)  not null,
    ciudad VARCHAR(100)  null,
    telefono INT not null,

	CONSTRAINT FK_SUCURSAL_cod_banco FOREIGN KEY (cod_banco) REFERENCES BANCO(cod_banco)
)
go

-- Crear la tabla CLIENTE
CREATE TABLE CLIENTE (
    cod_cli INT PRIMARY KEY IDENTITY(1,1),
    dni INT not null,
    apellidos VARCHAR(50) not null,
    nombres VARCHAR(50)  not null,
    direccion VARCHAR(100)  null,
    ciudad VARCHAR(50)  not null,
    email VARCHAR(100)  null
)
go

-- Crear la tabla CUENTA
CREATE TABLE CUENTA (
    nro_cta INT PRIMARY KEY not null,
    nro_sucursal INT  not null,
    cod_banco INT  not null,
    cod_cli INT  not null,
    saldo FLOAT not null,
    fechaapertura DATE  not null,
    tipocta VARCHAR(50)  not null,

    CONSTRAINT FK_CUENTA_nro_sucursal FOREIGN KEY (nro_sucursal) REFERENCES SUCURSAL(nro_sucursal),
	CONSTRAINT FK_CUENTA_cod_banco FOREIGN KEY (cod_banco) REFERENCES BANCO(cod_banco),
	CONSTRAINT FK_CUENTAE_cod_cli FOREIGN KEY (cod_cli) REFERENCES CLIENTE(cod_cli)
)
go

-- Crear la tabla MOVIMIENTOS
CREATE TABLE MOVIMIENTOS (
    nro_mov INT PRIMARY KEY IDENTITY(1,1),
    nro_cta INT not null,
    nro_sucursal INT  not null,
    cod_banco INT  not null,
    tipo_mov VARCHAR(50)  not null,
    fecha_mov INT  not null,
    importe FLOAT  not null,
    CONSTRAINT FK_MOVIMIENTOS_nro_cta FOREIGN KEY (nro_cta) REFERENCES CUENTA(nro_cta),
	CONSTRAINT FK_MOVIMIENTOS_nro_sucursal FOREIGN KEY (nro_sucursal) REFERENCES SUCURSAL(nro_sucursal),
	CONSTRAINT FK_MOVIMIENTOS_cod_banco FOREIGN KEY (cod_banco) REFERENCES BANCO(cod_banco)
)
go

-------------------------------------------------------------------------------------------------------------------
--                                              LLENAR TABLAS

-- Registros para la tabla BANCO
INSERT INTO BANCO (nombre, direccion, localidad)
VALUES ('BBVA', 'Avenida 1 Bolivar', 'Trujillo'),
       ('MiBanco', 'AV. REPUBLICA DE PANAMA URB. SURQUILLO 4575 ', 'SURQUILLO '),
       ('Scotiabank Perú', 'Av. Dionisio Derteano 102', 'San Isidro');

-- Registros para la tabla SUCURSAL
INSERT INTO SUCURSAL (cod_banco, direccion, ciudad, telefono)
VALUES (1, 'Av. Independencia', 'Jarabacoa', '123456789'),
       (1, 'Av. Anacaona esq. Trinitaria', 'San Juan de la Maguana', '987654321'),
       (2, 'Av. Isabel Aguiar No. 364', 'Herrera', '111222333');

-- Registros para la tabla CLIENTE
INSERT INTO CLIENTE (dni, apellidos, nombres, direccion, ciudad, email)
VALUES ('12345678', 'Vargas Valle', 'Rodrigo', 'Dirección Cliente 1', 'Pacasmayo', 'lilialeyva_verduzco@gmail.com'),
       ('87654321', 'Lopez Alcantara', 'Juan', 'Dirección Cliente 2', 'La esperanza', 'marasaucedo10@yahoo.com'),
       ('12121212', 'Gil Mesa', 'Carlos', 'Dirección Cliente 3', 'Trujillo', 'joseduardoolvera12@gmail.com');

-- Registros para la tabla CUENTA
INSERT INTO CUENTA (nro_cta, nro_sucursal, cod_banco, cod_cli, saldo, fechaapertura, tipocta)
VALUES (1001 ,2, 1, 1, 1000, '2000-01-01', 'Ahorros'),
       (1002 ,3, 1, 2, 500, '1990-02-01', 'Corriente'),
       (1003 ,2, 2, 3, 2000, '2004-03-01', 'Ahorros');

-- Registros para la tabla MOVIMIENTOS
INSERT INTO MOVIMIENTOS (nro_cta, nro_sucursal, cod_banco, tipo_mov, fecha_mov, importe)
VALUES (1002, 3, 1, 'Deposito', '2023', 80),
		(1001, 2, 1, 'Deposito', '1980', 100),
       (1002, 3, 1, 'Retiro', '2000', -50),
       (1003, 2, 2, 'Deposito', '2015', 200);

----------------------------------------------------------------------------------------------------------
--                                          VISUALIZAR TABLAS

--Mostrar tabla BANCO
SELECT * FROM BANCO

--Mostrar tabla SUCURSAL
SELECT * FROM SUCURSAL

--Mostrar tabla CLIENTE
SELECT * FROM CLIENTE

--Mostrar tabla CUENTA
SELECT * FROM CUENTA

--Mostrar tabla MOVIMIENTOSa
SELECT * FROM MOVIMIENTOS

-----------------------------------------------------------------------------------------------------------------
--                                        VACIAR ALGUNA TABLA
--DELETE FROM 

---------------------------------------------------------------------------------------------------------------
--                                     






















