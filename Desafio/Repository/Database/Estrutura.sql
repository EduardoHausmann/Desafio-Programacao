DROP TABLE IF EXISTS  cafe_pessoas,evento_pessoas, pessoas, sala_eventos, espaco_cafes;
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
numero_sala INT,
lotacao_maxima INT,
registro_ativo BIT
);

CREATE TABLE espaco_cafes(
id INT PRIMARY KEY IDENTITY(1,1),
numero_sala INT,
lotacao_maxima INT,
registro_ativo BIT
);

CREATE TABLE evento_pessoas(
id INT PRIMARY KEY IDENTITY(1,1),
nome_evento VARCHAR(100),
id_sala_evento INT,
FOREIGN KEY (id_sala_evento) REFERENCES sala_eventos(id),
id_pessoa INT,
FOREIGN KEY (id_pessoa) REFERENCES pessoas(id),
lotacao_atual INT,
registro_ativo BIT
);

CREATE TABLE cafe_pessoas(
id INT PRIMARY KEY IDENTITY(1,1),
nome_espaco VARCHAR(100),
id_espaco_cafe INT,
FOREIGN KEY (id_espaco_cafe) REFERENCES espaco_cafes(id),
id_pessoa INT,
FOREIGN KEY (id_pessoa) REFERENCES pessoas(id),
lotacao_atual INT,
registro_ativo BIT
);