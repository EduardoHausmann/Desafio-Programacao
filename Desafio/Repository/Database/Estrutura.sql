DROP TABLE IF EXISTS cafe_pessoas, evento_pessoas, sala_eventos, espaco_cafes, pessoas;
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

CREATE TABLE evento_pessoas(
id INT PRIMARY KEY IDENTITY(1,1),
descricao VARCHAR(100),
id_sala_evento INT,
FOREIGN KEY (id_sala_evento) REFERENCES sala_eventos(id),
id_pessoa INT,
FOREIGN KEY (id_pessoa) REFERENCES pessoas(id),
lotacao_atual INT,
registro_ativo BIT
);

CREATE TABLE cafe_pessoas(
id INT PRIMARY KEY IDENTITY(1,1),
id_espaco_cafe INT,
FOREIGN KEY (id_espaco_cafe) REFERENCES espaco_cafes(id),
id_pessoa INT,
FOREIGN KEY (id_pessoa) REFERENCES pessoas(id),
lotacao_atual INT,
registro_ativo BIT
);

INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('VITALINA','BERTOTTI','249.221.669-00','FELIX ESTEVAO ZUNINO, 554  FUNDOS','(47)9922-3153','vitalina@proway.com','2001-11-15','MARIA BERTOTTI','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('ROBERT',' STOLL STEINHEUSER','102.777.399-59','NICOLAU LINK, LADO 298 CX 01','(47)9922-356','robert@proway.com','2002-12-20','PAULA STEINHEUSER','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('FABRICIO',' KLETTENBERG','091.111.044-74','RUA MIRADOR N 314','(47)9928-5236','fabricio@proway.com','2000-02-28','JOAQUINA KLETTENBERG','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('PEDRINHO',' JOSE COELHO','497.823.639-87','AUGUSTO OTTE, 420','(47)9923-2642','pedrinho@proway.com','2001-03-25','ELFRIDA JOSE COELHO','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('ROSIMEIRE',' CRISTINA BIAZUS','557.933.489-34','CAMPOS NOVOS - 269','(47)9921-265','roseimeire@proway.com','2002-03-17','JULIA CRISTINA BIAZUS','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('SIDNEIA',' ERNESTINA COTA','902.949.229-68','RODOLFO SCHMITZ, 478','(47)9921-5745','sdineia@proway.com','2003-04-14','ANTONIA ERNESTINA COTA','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('ROBERTO',' JOSE MACHADO','498.282.829-32','DOUTOR FRANCISCO KUEBEL, 145','(47)9921-2648','roberto@proway.com','2001-05-03','ANTONIA MACHADO','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('SANTA',' LOURDES F. FACINA','948.128.029-20','WILHELM SIEBERT CX02','(47)9921-2658','santa@proway.com','2002-06-03','SANDRA LOURDES F. FACINA','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('RITA',' DE CASSIA LIZ DA SILVA','551.775.119-20','RODOLFO BRETZKE - 1893','(47)9928-5642','ridacassia@proway.com','2003-02-02', 'RITA LIZ DA SILV','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('ROSEMARIE',' SPERNAU NUNES','580.274.288-68','BELVEDERES 104','(47)9921-1514','rosi_nunes@proway.com','2000-02-18','ROSE MARIA ','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('VANDERLEI',' ZWANG','004.043.679-92','RUA DAS PALMEIRAS KM 09','(47)9929-6542','vandelei@proway.com','2000-05-19','VANDERLEIA ZWANG','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('TANIA',' TERESINHA COLSANI','443.200.888-49','R. EVALD BRAUN, 107','(47)9923-0046','valdir@proway.com','2001-06-21','TANIA PAULA ','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('VALDIR',' KOCHINSKI','860.345.469-91','LEOPOLDO HERINGER    1450','(47)9923-2518','tania@proway.com','2002-07-22','VALDIRIA KOCHINSKI','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('ROSANA',' VICENTIN','915.335.829-87','AV BARAO DO RIO BRANCO.244','(47)9928-7563','rosana@proway.com','2003-08-23','ROSAMARIA VICENTIN','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('ONESIA',' MACHADO DA SILVA','355.869.089-53','R. NESTOR JUSTINO DA SILVA, 46','(47)9921-2356','onesia@proway.com','2000-09-25', 'CARMEM DA SILVA','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('RONALDO',' DA SILVA TAVEIRA','415.667.977-49','ROBERTO BRUCH, LD27 AP07','(47)9924-583','ronaldo@proway.com','2001-10-27','RONALDINA DA SILVA TAVEIRA','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('RAFAEL',' MANSKE','040.002.769-50','JOAO RAUSCH, 495','(47)9923-2975','manske@proway.com','2001-11-29','RAFAELA MARIA','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('PAULO',' ROBERTO WAN DALL MILCHERT','716.184.149-68','SIBALDO HADLICH 70','(47)9923-2645','michelt@proway.com','2002-12-30', 'PAULA ROBERTA','Masuclino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('PEDRO',' DE BORBA','381.003.339-53','RUA BELO HORIZONTE, 739','(47)9923-251','borba@proway.com','2003-01-25',	'PEDROSA BORBALETA','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('ROBERTO',' RODRIGUES DOS SANTOS','939.088.737-20','LORENCO MAFRA 100','(47)9923-266','rodrigues@proway.com','2001-03-01','ROBERTA DOS SANTOS','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('SIRLEI',' APARECIDA SILVA','906.007.369-68','ARGENTINA       313','(47)9921-231','seilei@proway.com','2002-02-03','SIRLEI JOAQUINA SILVA','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('OLINDINA',' MARTINS DIAS','035.400.909-01','RUA REINHOLD SCHROEDER 6007','(47)9923-2689','martins@proway.com','2002-04-05', 'OLINDINA DIAS E NOITE','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('VALMOR',' SOARES SERAFIN','309.060.209-20','ELDORADO - OTAVIO DOMINGOS SERAFIN','(47)9921-2637','pereira@proway.com','2002-05-07','VALMORA SERAFIN','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('PATRICIA',' PEREIRA SIMOES','008.506.807-98','JOAQUIM NABUCO,189','(47)9928-230','patricia@proway.com','2001-05-09','KATIA  SIMOES','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('RAIMUNDO',' METTE','291.024.059-20','RUA SEBASTIAO JOSE DE SOUZA, 135','(47)9922-3025','mette@proway.com','2001-06-11','RAIMUNDA GUIMARAES','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('SINARA',' ANDREA ISIDORO','901.607.059-04','CARL DETTMER, 512','(47)9920-2536','isidoro@proway.com','2002-09-13','SINARA JULIA','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('PAULINO',' TORRES DE OLIVEIRA','506.350.209-20','DA COMUNIDADE - 109','(47)9925-3678','torres@proway.com','2002-09-15', 'PAULA OLIVEIRA','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('SANDRO',' RODRIGO ISIDORO','022.202.409-40','CARL DETTMER, 512','(47)9928-0362','sandro@proway.com','2002-10-17','SANDRA JANAINA','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('SILVANA',' CARL','988.095.109-20','ARNOLDO CARL, 61 CX03','(47)9921-194','silvana@proway.com','2003-10-19','SILVIA CAROLINA','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('SANDRO',' MARCOS REINERT HERRERO','902.940.769-72','JOAQUIM GONCALVES LEDO','(47)9921-2362','sandro@proway.com','2001-11-19','SANDRINHA REINERT','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('ROSANE',' SALDANHA','021.000.409-74','PAULO ROBERTO DO NASCIMENTO, 110','(47)9921-2365','rosane@proway.com','2000-03-21','ROSA SALDINHA','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('VALMIR',' MACIEL','059.109.130-41','CACADORES, DOS 1581 APART10 BLOCO A2','(47)9921-2345','maciel@proway.com','2000-04-23','VALMIRA MACIEL','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('VILMA',' KRATZ','609.173.800-04','FRANZ MUELLER-803','(47)9925-6321','kardts@proway.com','2001-04-25','VILMARA KRATZ','Feminino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('FABRICIO',' EVANGELISTA SILVA','087.707.306-47','RUA ARY CONRADO METTE, 20 AP 01','(47)9928-5631','silva@proway.com','2001-02-20','FABRICIA SILVA','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('SERGIO','KUHNEN','733.078.089-68','WILHELM GROSSKRUETZ, 115','(47)9926-3158','sergio@proway.com','2001-05-27','CLAUDIA KUHNEN','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('VILBERTO',' ALEXANDRE','382.703.209-05','NICOLAU REITER 450','(47)9921-5863','alexandr@proway.com','2002-06-27','VALENTINA ALEXANDRE','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('WALDEMAR',' CARLOS TRAVALHA','049.206.109-25','FREDERICO EVESPEC.56','(47)9928-6325','travalha@proway.com','2000-06-29','WALDEMIRA TRAVALHA','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('SIDNEI',' COSTA','802.134.809-15','JOSE JOAO DA SILVA, 135','(47)9923-2578','machado@proway.com','2001-07-30','JULIA COSTA','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('SEBASTIAO',' PEREIRA MACHADO','207.720.029-08','ESTRADA GERAL,SN','(47)9925-7832','costa@proway.com','2001-08-22','SEBASTIANA MACHADO','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('VILSON',' DIAS VIEIRA','391.004.409-10','MATHIAS HERKENHOFF JUNIOR PROX1394','(47)9928-3265','vilson@proway.com','2002-08-20','VERONICA VIEIRA','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('VALTER',' AMORIM','506.802.459-30','BERNARDO SCHEIDEMANTEL LOTE 94','(47)9922-6825','valter@proway.com','2002-09-18','VALENTINA AMORIM','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('PEDRO',' GONZAGA','014.602.209-20','ANANIAS DA SILVA 148','(47)9925-6341','gonsaga@proway.com','2001-10-12',	'PEDRITA BAMBAM','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('ROBERTO',' FERNANDES FERREIRA','308.859.079-91','RUA OTTO METZNER 95','(47)9923-4125','fernandes@proway.com','2001-10-10','ROBERTA CLOUSE','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('SERGIO',' LUIZ ROSUMEK','422.947.139-63','RUA WILHELM SCHELWORTH 85','(47)9921-2535','rosime2@proway.com','2003-11-08','SERGINA ROSUMEK','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('PAULO',' PEDRO DA SILVA','624.684.209-72','PRIMEIRO DE JANEIRO, 1131','(47)9925-3558','pedro_Paulo@proway.com','2001-11-06', 'PAULA DA SILVA','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('OSNI',' SACHSE','341.542.269-77','POMERODE, 1483','(47)9925-5865','osni_S@proway.com','2001-12-07','OSNILDA SACHSE','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('OSEIAS',' FABIANO TRAPP','360.331.699-68','NOSSA SR. DAS GRACAS 403','(47)9928-6548','trapp_os@proway.com','2001-12-09','FABIANA TRAPP','Masculino',1);
INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES ('ROSILENE',' ROSSINI','670.616.179-20','HENRIQUE GESKE 39','(47)9925-4889','rossini@proway.com','2003-03-30','ROSIMARA ROSSINI','Feminino',1);

INSERT INTO sala_eventos (nome, lotacao_maxima, registro_ativo) 
VALUES ('Teste 01', 2, 1),
		('Teste 02', 30, 1);

INSERT INTO espaco_cafes(nome, lotacao_maxima, registro_ativo) 
VALUES ('Teste 03', 2, 1),
		('Teste 04', 30, 1);		