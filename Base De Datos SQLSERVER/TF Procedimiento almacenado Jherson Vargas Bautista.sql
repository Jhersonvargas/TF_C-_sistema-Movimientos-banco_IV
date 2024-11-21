--PROCEDIMIENTOS ALMACENADOS:

--------------------------------------------------------------------------------------------------------------
--                                               SECCION DE TABLA BANCO

-- Crear procedimiento almacenado para llenar el combox del formulario usando la tabla banco
CREATE PROCEDURE Llenar_Banco
AS
BEGIN
    SELECT * FROM BANCO
END;
GO

-- Ejecutar procedimiento almacenado
EXECUTE Llenar_Banco
GO


--------------------------------------------------------------------------------------------------------------
--                                               SECCION DE TABLA SUCURSAL


--CREAMOS EL PROCEDIMIENTOS VALIDAR USUARIO PARA EL FORMULARIO ACCESO(LOGIN)
CREATE PROCEDURE validar_usuario
@cod_cli INT,
@dni INT
AS
BEGIN
    SELECT * FROM CLIENTE
    WHERE ((cod_cli = @cod_cli) AND (dni= @dni));
END;
go

--EJECUTAMOS EL PROCEDIMIENTO CREADO PARA PROBAR SU FUNCIONAMIENTO
execute validar_usuario '1', '12345678'


-- Crear procedimiento almacenado para llenar el combox del formulario usando la tabla Sucursal
CREATE PROCEDURE Llenar_Sucursal
AS
BEGIN
    SELECT * FROM SUCURSAL
END;
GO

-- Ejecutar procedimiento almacenado
EXECUTE Llenar_Sucursal
GO

--------------------------------------------------------------------------------------------------------------
--                                               SECCION DE TABLA CLIENTE


-- Crear procedimiento almacenado para llenar el combox del formulario usando la tabla cliente
CREATE PROCEDURE Llenar_Cliente
AS
BEGIN
    SELECT * FROM CLIENTE
END;
GO

-- Ejecutar procedimiento almacenado
EXECUTE Llenar_Cliente
GO

--procedimiento PARA INSERTAR UN NUEVO REGISTRO EN LA TABLA CLIENTE 
CREATE PROCEDURE InsertarCliente
(
    @dni INT,
    @apellidos VARCHAR(50),
    @nombres VARCHAR(50),
    @direccion VARCHAR(100),
    @ciudad VARCHAR(50),
    @email VARCHAR(100)
)
AS
BEGIN
    INSERT INTO CLIENTE (dni, apellidos, nombres, direccion, ciudad, email)
    VALUES (@dni, @apellidos, @nombres, @direccion, @ciudad, @email)
END

--PROBAMOS EL PROCEDIMIENTO 
EXECUTE InsertarCliente '77777777','VARGAS BAUTISTA','Jherson','Los prados Mz23','Trhujillo','Jhersondgsh@gmail.com'
--DELETE FROM CLIENTE WHERE cod_cli = '4';
--------------------------------------------------------------------------------------------------------------
--                                               SECCION DE TABLA CUENTA
--CREAMOS EL PROCEDIMIENTO PARA CREAR UNA CUENTA
CREATE PROCEDURE CrearCuenta
@nro_cta INT,
@nro_sucursal INT,
@cod_banco INT,
@cod_cli INT,
@saldo FLOAT,
@fechaapertura DATE,
@tipocta VARCHAR(50)
AS
BEGIN
    INSERT INTO CUENTA (nro_cta, nro_sucursal, cod_banco, cod_cli, saldo, fechaapertura, tipocta)
    VALUES (@nro_cta, @nro_sucursal, @cod_banco, @cod_cli, @saldo, @fechaapertura, @tipocta);
END;
go

--EJECUTAMOS EL PROCEDIMIENTO CREADO PARA PROBAR SU FUNCIONAMIENTO
EXECUTE CrearCuenta '1004','1','3','2','800','2010-08-02','Ahorros'





-- Crear procedimiento almacenado para llenar el combox del formulario usando la tabla cliente
CREATE PROCEDURE Llenar_Cuenta
AS
BEGIN
    SELECT * FROM CUENTA
END;
GO

-- Ejecutar procedimiento almacenado
EXECUTE Llenar_Cuenta
GO




--CREAR PROCEDIMIENTO PARA BUSCAR LAS CUENTAS POR EL ID
--drop procedure Consultar_Cuentas_Idcuentas
create procedure Consultar_Cuentas_Idcuentas
@nro_cta int
as
select c.*, b.nombre AS banco_nombre, s.ciudad AS ciudad_sucursal, cl.nombres AS nombres_cliente from CUENTA c
LEFT JOIN BANCO b ON b.cod_banco = c.cod_banco
LEFT JOIN CLIENTE cl ON cl.cod_cli = c.cod_cli
LEFT JOIN SUCURSAL s ON s.nro_sucursal = c.nro_sucursal
where nro_cta=@nro_cta
go

--PROBAMOS EL PROCEDIMIETO ALMACENADO
EXECUTE Consultar_Cuentas_Idcuentas '1001'
go
--------------------------------------------------------------------------------------------------------------
--                                               SECCION DE TABLA MOVIMIENTOS

--CREAMOS EL PROCEDIMIENTOS ReporteFecha PARA USARLO EN NUESTRO FORMULARIO REPORTE

create procedure ReporteFecha
@año int,
@año2 int
as
select * from Vista_MovimientosCliente where fecha_mov >= @año and fecha_mov <= @año2
go

--EJECUTAMOS EL PROCEDIMIENTO CREADO PARA PROBAR SU FUNCIONAMIENTO
execute ReporteFecha '2000' ,'2023'

--------------------------------------------------------------------------------------------------------------

--                      CUENTA SURCURSAL

--creamos el procedimiento para visualizar el numero de cuenta con la surcusal
create procedure VConsultar_Cuenta_Sucursal
@nro_cta int
as
select * from Vista_Cuenta_Sucursal where nro_cta=@nro_cta
go

--probamos el procedimiento
execute VConsultar_Cuenta_Sucursal '1001'

----------------------------------------------------------------------------------------------------------------
--                       SECCION DE LAS TABLAS  CUENTA Y MOVIMIENTOS

--CREAR PROCEDIMIENTO PARA REALIZAR DEPOSITOS
--DROP PROCEDURE RealizarDeposito
CREATE PROCEDURE RealizarDeposito
@nro_cta INT,
@importe FLOAT
AS
BEGIN
    UPDATE CUENTA
    SET saldo = saldo + @importe
    WHERE nro_cta = @nro_cta;
	
	insert into MOVIMIENTOS (cod_banco, importe, nro_cta,nro_sucursal, tipo_mov, fecha_mov)
	SELECT cod_banco, @importe, nro_cta,nro_sucursal, 'Deposito', Year(GETDATE()) FROM CUENTA c WHERE c.nro_cta = @nro_cta;
END
go

--select Year(GETDATE()) 

--SELECT * FROM CUENTA WHERE nro_cta = '1001';

--SELECT * FROM MOVIMIENTOS WHERE nro_cta = '1001';
----PROBAR PROCEDIMIENTO
--EXECUTE RealizarDeposito '1001','100'



--CREAR PROCEDIMIENTO PARA REALIZAR RETIROS
--DROP PROCEDURE RealizarRetiro
CREATE PROCEDURE RealizarRetiro
@nro_cta INT,
@importe FLOAT
AS
BEGIN
    DECLARE @saldo FLOAT;
    SET @saldo = (SELECT saldo FROM CUENTA WHERE nro_cta = @nro_cta);

    IF @saldo >= @importe
    BEGIN
        UPDATE CUENTA
        SET saldo = saldo - @importe
        WHERE nro_cta = @nro_cta;

		insert into MOVIMIENTOS (cod_banco, importe, nro_cta,nro_sucursal, tipo_mov, fecha_mov)
	    SELECT cod_banco, @importe, nro_cta,nro_sucursal, 'Retiro', Year(GETDATE()) FROM CUENTA c WHERE c.nro_cta = @nro_cta;
    END
END
go

--PROBAR PROCEDIMIENTO
--EXECUTE RealizarRetiro '1001','100'


