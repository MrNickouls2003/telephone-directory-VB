--Database agenda

--Tabela contato para armazenar informacoes do contato que será salvo
CREATE TABLE contato(
	id_contato INT NOT NULL AUTO_INCREMENT,
	nome_contato VARCHAR (50) NOT NULL,
	telefone_contato CHAR(15),
	email_contato VARCHAR(100),
	endereco_contato VARCHAR(100),
	CONSTRAINT contato_pk PRIMARY KEY (id_contato)
);

