CREATE TABLE TB_Usuario(
	Usuario_ID INT IDENTITY PRIMARY KEY,
	Nome VARCHAR(150) NOT NULL,
	CPF VARCHAR(15) NOT NULL,
	Email VARCHAR(150) NOT NULL,
	StatusUser VARCHAR(12) NOT NULL
)

DROP TABLE TB_Usuario
DROP TABLE TB_ReservasUsuarios

CREATE TABLE TB_ReservasUsuarios(
	Usuario INT FOREIGN KEY REFERENCES TB_Usuario(Usuario_ID),
	NumQuarto VARCHAR(3) NOT NULL,
	CheckIn DateTime NOT NULL,
	CheckOut DateTime NOT NULL,
	CategoriaQuarto VARCHAR(150) NOT NULL,
)

--ALTER TABLE TB_Usuario ADD CPF VARCHAR(1) NULL, Email VARCHAR(50) NULL

-- Populando o Banco de Dados
INSERT INTO TB_Usuario VALUES('Alan Graton', '000-000-000-00', 'alan.teste@gmail.com', 'Ativo')
INSERT INTO TB_Usuario VALUES('Marcos de Brito', '111-111-111-11','marcos.teste@gmail.com', 'Inativo')
INSERT INTO TB_Usuario VALUES('Débora Graton', '222-222-222-22','debora.tests@gmail.com', 'Ativo')

INSERT INTO TB_LoginUsuario VALUES('Vanessa', 'Professora')

SELECT * FROM TB_Usuario
SELECT * FROM TB_LoginUsuario

-- ///////////////////////////////////////////////////////////
-- PROCEDURES PARA CADASTRO DE USUÁRIOS
-- //////////////////////////////////////////////////////////


-- Procedure ADICIONAR USUÁRIOS
DROP PROCEDURE AddUsuarios
GO
CREATE PROCEDURE AddUsuarios(
@Nome VARCHAR(150),
@CPF VARCHAR(15),
@Email VARCHAR(150),
@Status VARCHAR(12)
)

AS
BEGIN
	IF NOT EXISTS(SELECT * FROM TB_Usuario WHERE CPF = @CPF)
		BEGIN
			SELECT 'Usuário já cadastrado ;-;' AS Retorno
		END
	ELSE
		INSERT INTO TB_Usuario VALUES(@Nome, @CPF, @Email, @Status)	
END
GO

-- Procedure EDITAR USUÁRIO CADASTRADO
GO
CREATE PROCEDURE AlterarCadastroUsuarios(
@Nome VARCHAR(150),
@CPF VARCHAR(15),
@Email VARCHAR(150),
@Status VARCHAR(12)
)

AS
BEGIN
	IF NOT EXISTS (SELECT * FROM TB_Usuario WHERE Nome = @Nome)
		BEGIN
			SELECT 'Usuário não encontrado' AS retorno
		END
	ELSE
		UPDATE TB_Usuario SET Nome=@Nome, CPF=@CPF, Email=@Email, StatusUser=@Status WHERE Nome = @Nome
END
GO

EXEC AlterarCadastroUsuarios 'Alan Graton', '000-000-00', 'alan.teste@gmail.com', 'Ativo'

-- Procedure EXCLUIR USUÁRIO CADASTRADO
DROP PROCEDURE DeleteUsuarios
GO
CREATE PROCEDURE DeleteUsuarios(
@Nome VARCHAR(150)
)

AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM TB_Usuario WHERE Nome = @Nome)
			BEGIN
				SELECT 'Ficha de Usuário não encontrada ;-;' AS Retorno
			END
		ELSE 
			DELETE FROM TB_Usuario WHERE Nome = @Nome
	END
GO

-- Procedure LISTAR USUÁRIOS CADASTRADOS
DROP PROCEDURE ListarUsuarios
GO
CREATE PROCEDURE ListarUsuarios

AS
	BEGIN
			SELECT * FROM TB_Usuario
	END
GO

EXEC ListarUsuarios

-- Procedure CONSULTAR USUÁRIOS
DROP PROCEDURE ConsultarCadastroUsuarios
GO
CREATE PROCEDURE ConsultarCadastroUsuarios(
@Nome VARCHAR(150),
@RETORNO VARCHAR(50) OUTPUT
)

AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM TB_Usuario WHERE Nome = @Nome)
			BEGIN
				SET @RETORNO = 'Não encontrado'
			END
		ELSE IF @Nome = ''
			BEGIN
				SET @RETORNO = 'Campo vazio'
			END
		ELSE
			BEGIN
				SET @RETORNO = 'Encontrei'
				SELECT * FROM TB_Usuario WHERE Nome = @Nome
			END
	END
GO

EXEC ConsultarCadastroUsuarios 'Alan'
EXEC ConsultarCadastroUsuarios 'Alan Graton'

-- ///////////////////////////////////////////////////////////
-- PROCEDURES PARA RESERVA DE USUÁRIOS
-- //////////////////////////////////////////////////////////

CREATE PROCEDURE SalvarReservaUsuario(
@Usuario_ID INT,
@CategoriaQuarto VARCHAR(150),
@NumQuarto VARCHAR(3),
@CheckIn DATETIME,
@CheckOut DATETIME
)

AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM TB_ReservasUsuarios WHERE @Usuario_ID = Usuario_ID)
			BEGIN
				INSERT INTO TB_ReservasUsuarios VALUES(@CategoriaQuarto, @NumQuarto, @CheckIn, @CheckOut)
			END
		ELSE
			SELECT 'Reserva já havia sido Cadastrada' AS Retorno
	END
GO