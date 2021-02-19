DROP TABLE IF EXISTS  pessoas, sala_eventos, espaco_cafes;
CREATE TABLE pessoas(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50) NOT NULL,
sobrenome VARCHAR(75) NOT NULL,
cpf VARCHAR(14),
endereco VARCHAR(75),
telefone VARCHAR(13),
email VARCHAR(100),
data_nascimento DATE,
nome_mae VARCHAR(100),
sexo VARCHAR(10),
registro_ativo BIT
);

CREATE TABLE sala_eventos(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(75),
lotacao_maxima INT,
registro_ativo BIT
);

CREATE TABLE espaco_cafes(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(75),
lotacao_maxima INT,
registro_ativo BIT
);