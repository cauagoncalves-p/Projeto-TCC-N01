ALTER DATABASE AureaMax SET MULTI_USER;
GO

ALTER DATABASE AureaMax SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

DROP DATABASE AureaMax;

CREATE DATABASE AureaMax;
GO

USE AureaMax;
GO

CREATE TABLE tbUsuario (
    Id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Sobrenome VARCHAR(100) NOT NULL,
    Data_Nascimento DATE NOT NULL,
    CPF CHAR(14) NOT NULL UNIQUE, -- formato: 000.000.000-00
    Sexo CHAR(1) NOT NULL CHECK (Sexo IN ('M', 'F', 'O')), -- Obrigatório e validado
    Telefone CHAR(11) NOT NULL, -- Ex: 11999998888
    Genero VARCHAR(20) NOT NULL CHECK (Genero IN (
        'Cisgênero', 
        'Transgênero', 
        'Não-binário', 
        'Gênero fluido', 
        'Outro', 
        'Prefiro não dizer'
    )),
    Endereco VARCHAR(200) NOT NULL,
    Email VARCHAR(200) NOT NULL UNIQUE,
    Cidade VARCHAR(100) NOT NULL,
    Estado CHAR(2) NOT NULL, 	
	Data_Cadastro DATETIME NOT NULL DEFAULT GETDATE(),
	Senha varchar(100) NOT NULL
);

CREATE TABLE tbInstituicao (
    IdInstituicao INT PRIMARY KEY IDENTITY(1,1),
    NomeInstituicao VARCHAR(150) NOT NULL,
    CNPJ CHAR(18) NOT NULL UNIQUE, -- Formato: 00.000.000/0000-00
    TipoInstituicao VARCHAR(50) CHECK (TipoInstituicao IN ('Pública', 'Privada')),
    Telefone VARCHAR(20),
    Email VARCHAR(100),
    Endereco VARCHAR(200),
    Cidade VARCHAR(100),
    Estado CHAR(2) -- Ex: SP, RJ, MG
);

CREATE TABLE tbMedico (
    IdMedico INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100) NOT NULL,
	Sobrenome Varchar(100) NOT NULL,
    CRM VARCHAR(20) NOT NULL UNIQUE,
	Sexo char(1) not null check (sexo in ('M', 'F', 'O')),
    Especialidade VARCHAR(100) NOT NULL CHECK (Especialidade IN (
    'Clínico Geral',
    'Pediatria',
    'Ginecologia',
    'Obstetrícia',
    'Urologia',
    'Dermatologia',
    'Cardiologia',
    'Endocrinologia',
    'Ortopedia',
    'Neurologia',
    'Psiquiatria',
    'Oftalmologia',
    'Otorrinolaringologia',
    'Reumatologia',
    'Gastroenterologia',
    'Nefrologia',
    'Oncologia',
    'Nutrologia',
    'Medicina do Trabalho',
    'Medicina da Família'
)),
    Cidade VARCHAR(100),
    Estado CHAR(2), -- Ex: SP, RJ, MG
    Endereco VARCHAR(200),
    Telefone VARCHAR(20),
	CPF char(14) unique not null,
	Email varchar(150) unique not null,
	Senha varchar(100) not null,
	IdInstituicao int not null,
	CONSTRAINT FK_tbMedico_tbInstituicao
	FOREIGN KEY (IdInstituicao) REFERENCES tbInstituicao(IdInstituicao)
);

CREATE TABLE tbConsulta (
    IdConsulta INT PRIMARY KEY IDENTITY(1,1),
    Id_usuario INT NOT NULL,
    IdMedico INT NOT NULL,
    DataConsulta DATETIME NOT NULL,
    Motivo VARCHAR(500),
    StatusConsulta VARCHAR(20) NOT NULL DEFAULT 'Agendada' CHECK (StatusConsulta IN (
    'Agendada',
    'Confirmada',
    'Cancelada',
    'Realizada',
    'Urgente',
	'Avaliada'
)),
    Observacoes VARCHAR(1000),
	HorarioConsulta time not null,

    CONSTRAINT FK_Consulta_Usuario FOREIGN KEY (Id_usuario) REFERENCES tbUsuario(Id_usuario),
    CONSTRAINT FK_Consulta_Medico FOREIGN KEY (IdMedico) REFERENCES tbMedico(IdMedico)
);

CREATE TABLE DiagnosticoMedico(
    Id_diagnosticoMedico integer identity PRIMARY KEY,
    Id_Consulta integer,
	diagnostico text not null,
	tratamentoRecomendado text not null,
    Medicamento VARCHAR(100),
    Dosagem VARCHAR(50),
    Frequencia VARCHAR(50),
    duracao varchar(50),
	instrucaoReceita text not null,
    FOREIGN KEY (Id_Consulta) REFERENCES tbConsulta(IdConsulta)
);

CREATE TABLE tbAvaliacao (
    IdAvaliacao INT PRIMARY KEY IDENTITY(1,1),
    IdConsulta INT NOT NULL,  -- Referência à consulta
    Atendimento_comunicacao INT NOT NULL CHECK (Atendimento_comunicacao BETWEEN 1 AND 5),
	Tempo_de_espera INT NOT NULL CHECK (Tempo_de_espera  BETWEEN 1 AND 5),
	Conhecimento_tecnico INT NOT NULL CHECK (Conhecimento_tecnico  BETWEEN 1 AND 5),
	Respeito_empatia  INT NOT NULL CHECK (Respeito_empatia  BETWEEN 1 AND 5),
    Comentario VARCHAR(1000),
    CONSTRAINT FK_Avaliacao_Consulta FOREIGN KEY (IdConsulta) REFERENCES tbConsulta(IdConsulta)
);

-- INSERTS DOS BANCO 

use AureaMax;
GO

INSERT INTO tbInstituicao (NomeInstituicao, CNPJ, TipoInstituicao, Telefone, Email, Endereco, Cidade, Estado)
VALUES 
('Hospital São Lucas', '12.345.678/0001-90', 'Privada', '(11) 4002-8922', 'contato@saolucas.com', 'Rua das Palmeiras, 100', 'São Paulo', 'SP'),
('Clínica Vida e Saúde', '98.765.432/0001-10', 'Privada', '(21) 98765-4321', 'vidaesaude@clinica.com', 'Av. Brasil, 2000', 'Rio de Janeiro', 'RJ'),
('Posto de Saúde Central', '11.222.333/0001-55', 'Pública', '(31) 3344-5566', 'pscentral@saude.gov', 'Rua dos Andradas, 456', 'Belo Horizonte', 'MG'),
('Hospital Municipal de Porto Alegre', '77.888.999/0001-44', 'Pública', '(51) 99887-6655', 'hmportoalegre@prefeitura.rs.gov.br', 'Av. Ipiranga, 1234', 'Porto Alegre', 'RS'),
('Clínica Bem-Estar', '55.666.777/0001-33', 'Privada', '(71) 98765-1234', 'contato@bemestar.com.br', 'Rua Bahia, 789', 'Salvador', 'BA'),
('Hospital Santa Rita', '22.111.444/0001-22', 'Filantrópica', '(85) 4009-1234', 'santarita@hospital.org', 'Rua das Flores, 321', 'Fortaleza', 'CE'),
('Centro Médico Alfa', '33.222.555/0001-88', 'Privada', '(62) 99876-5432', 'contato@centroalfa.com', 'Av. Goiás, 890', 'Goiânia', 'GO'),
('Unidade Básica de Saúde Esperança', '44.333.666/0001-11', 'Pública', '(48) 3232-1122', 'ubsesperanca@sc.gov.br', 'Rua São João, 456', 'Florianópolis', 'SC'),
('Clínica Popular Mais Vida', '66.777.888/0001-99', 'Privada', '(92) 3344-7788', 'atendimento@maisvida.com', 'Av. Constantino Nery, 4567', 'Manaus', 'AM'),
('Hospital Regional do Norte', '99.888.777/0001-66', 'Pública', '(95) 99888-7766', 'regionalnorte@rr.gov.br', 'Rodovia BR-174, Km 15', 'Boa Vista', 'RR');

INSERT INTO tbMedico 
(Nome, Sobrenome, CRM, Sexo, Especialidade, Cidade, Estado, Endereco, Telefone, CPF, Email, Senha, IdInstituicao)
VALUES
('João', 'Silva', 'CRM1001', 'M', 'Clínico Geral', 'São Paulo', 'SP', 'Rua A, 123', '11912345678', '00000000001', 'joao.silva@email.com', 'senha123', 1),
('Ana', 'Souza', 'CRM1002', 'F', 'Pediatria', 'Rio de Janeiro', 'RJ', 'Rua B, 456', '21912345678', '00000000002', 'ana.souza@email.com', 'senha123', 1),
('Carlos', 'Oliveira', 'CRM1003', 'M', 'Cardiologia', 'Belo Horizonte', 'MG', 'Av Central, 1000', '31912345678', '00000000003', 'carlos.oliveira@email.com', 'senha123', 1),
('Beatriz', 'Pereira', 'CRM1004', 'F', 'Ginecologia', 'Campinas', 'SP', 'Rua das Flores, 333', '11987654321', '00000000004', 'beatriz.pereira@email.com', 'senha123', 1),
('Ricardo', 'Lima', 'CRM1005', 'M', 'Urologia', 'Salvador', 'BA', 'Rua Sol, 87', '71912345678', '00000000005', 'ricardo.lima@email.com', 'senha123', 1),
('Mariana', 'Gomes', 'CRM1006', 'F', 'Dermatologia', 'Fortaleza', 'CE', 'Rua Praia, 29', '85912345678', '00000000006', 'mariana.gomes@email.com', 'senha123', 1),
('Luiz', 'Costa', 'CRM1007', 'M', 'Ortopedia', 'Curitiba', 'PR', 'Av Norte, 202', '41912345678', '00000000007', 'luiz.costa@email.com', 'senha123', 1),
('Camila', 'Ribeiro', 'CRM1008', 'F', 'Neurologia', 'Recife', 'PE', 'Rua Mar, 10', '81912345678', '00000000008', 'camila.ribeiro@email.com', 'senha123', 1),
('Felipe', 'Martins', 'CRM1009', 'M', 'Psiquiatria', 'Porto Alegre', 'RS', 'Rua Sul, 11', '51912345678', '00000000009', 'felipe.martins@email.com', 'senha123', 1),
('Larissa', 'Almeida', 'CRM1010', 'F', 'Endocrinologia', 'Belém', 'PA', 'Rua Leste, 90', '91912345678', '00000000010', 'larissa.almeida@email.com', 'senha123', 1),
('Joana', 'Silva', 'CRM1011', 'F', 'Nutrologia', 'Manaus', 'AM', 'Rua X, 5', '92912345678', '00000000011', 'joana.silva@email.com', 'senha123', 1),
('Thiago', 'Souza', 'CRM1012', 'M', 'Otorrinolaringologia', 'São Paulo', 'SP', 'Rua Y, 6', '11976543210', '00000000012', 'thiago.souza@email.com', 'senha123', 1),
('Natália', 'Oliveira', 'CRM1013', 'F', 'Clínico Geral', 'Santos', 'SP', 'Rua Z, 7', '13912345678', '00000000013', 'natalia.oliveira@email.com', 'senha123', 1),
('Eduardo', 'Pereira', 'CRM1014', 'M', 'Cardiologia', 'Campinas', 'SP', 'Rua W, 8', '11933334444', '00000000014', 'eduardo.pereira@email.com', 'senha123', 1),
('Patrícia', 'Lima', 'CRM1015', 'F', 'Pediatria', 'Rio Claro', 'SP', 'Rua V, 9', '19955556666', '00000000015', 'patricia.lima@email.com', 'senha123', 1),
('Leandro', 'Gomes', 'CRM1016', 'M', 'Endocrinologia', 'Uberlândia', 'MG', 'Rua T, 10', '34912345678', '00000000016', 'leandro.gomes@email.com', 'senha123', 1),
('Roberta', 'Costa', 'CRM1017', 'F', 'Ginecologia', 'Ribeirão Preto', 'SP', 'Rua S, 11', '16912345678', '00000000017', 'roberta.costa@email.com', 'senha123', 1),
('Fernando', 'Ribeiro', 'CRM1018', 'M', 'Neurologia', 'Natal', 'RN', 'Rua R, 12', '84912345678', '00000000018', 'fernando.ribeiro@email.com', 'senha123', 1),
('Letícia', 'Martins', 'CRM1019', 'F', 'Oftalmologia', 'Maceió', 'AL', 'Rua Q, 13', '82912345678', '00000000019', 'leticia.martins@email.com', 'senha123', 1),
('Alex', 'Almeida', 'CRM1020', 'M', 'Reumatologia', 'João Pessoa', 'PB', 'Rua P, 14', '83912345678', '00000000020', 'alex.almeida@email.com', 'senha123', 1),
('Bianca', 'Silva', 'CRM1021', 'F', 'Gastroenterologia', 'Aracaju', 'SE', 'Rua O, 15', '79912345678', '00000000021', 'bianca.silva@email.com', 'senha123', 1),
('Carlos', 'Souza', 'CRM1022', 'M', 'Obstetrícia', 'São Luís', 'MA', 'Rua N, 16', '98912345678', '00000000022', 'carlos.souza@email.com', 'senha123', 1),
('Érika', 'Oliveira', 'CRM1023', 'F', 'Urologia', 'Florianópolis', 'SC', 'Rua M, 17', '48912345678', '00000000023', 'erika.oliveira@email.com', 'senha123', 1),
('Jorge', 'Pereira', 'CRM1024', 'M', 'Nutrologia', 'Vitória', 'ES', 'Rua L, 18', '27912345678', '00000000024', 'jorge.pereira@email.com', 'senha123', 1),
('Sabrina', 'Lima', 'CRM1025', 'F', 'Clínico Geral', 'Teresina', 'PI', 'Rua K, 19', '86912345678', '00000000025', 'sabrina.lima@email.com', 'senha123', 1),
('Igor', 'Gomes', 'CRM1026', 'M', 'Ortopedia', 'São Paulo', 'SP', 'Rua J, 20', '11988887777', '00000000026', 'igor.gomes@email.com', 'senha123', 1),
('Luciana', 'Costa', 'CRM1027', 'F', 'Dermatologia', 'Curitiba', 'PR', 'Rua I, 21', '41977776666', '00000000027', 'luciana.costa@email.com', 'senha123', 1),
('Vinícius', 'Ribeiro', 'CRM1028', 'M', 'Medicina do Trabalho', 'Belo Horizonte', 'MG', 'Rua H, 22', '31966665555', '00000000028', 'vinicius.ribeiro@email.com', 'senha123', 1),
('Natália', 'Martins', 'CRM1029', 'F', 'Medicina da Família', 'Recife', 'PE', 'Rua G, 23', '81955554444', '00000000029', 'natalia.martins@email.com', 'senha123', 1),
('Marcelo', 'Almeida', 'CRM1030', 'M', 'Oftalmologia', 'Fortaleza', 'CE', 'Rua F, 24', '85944443333', '00000000030', 'marcelo.almeida@email.com', 'senha123', 1);


select * from tbUsuario;
select * from tbInstituicao;
select * from tbMedico;
select * from tbAvaliacao;
select * from tbConsulta;
select * from DiagnosticoMedico;
