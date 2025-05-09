# 🩺 Áurea – Avaliação de Consultas Médicas

Áurea é um sistema desenvolvido em **Windows Forms (C#)** com o objetivo de **avaliar médicos e consultas**, ajudando pacientes a compartilharem suas experiências e contribuírem para a melhoria dos atendimentos na área da saúde.

---

## ✨ Funcionalidades

- 📝 Cadastro de médicos e pacientes  
- 📅 Registro de consultas realizadas  
- ⭐ Avaliação de consultas (nota e comentários)  
- 🔍 Visualização de histórico e médias de avaliações  
- 📧 Envio de código de confirmação por e-mail para segurança  
- 🔐 Autenticação com verificação de usuário

---

## 🛠️ Tecnologias Utilizadas

- **C# com Windows Forms**  
- **.NET Framework**  
- **SQL Server** para banco de dados  
- **SMTP** (para envio de e-mails de confirmação)

---

## 🎯 Objetivo do Projeto

O projeto tem como foco **tornar o processo de avaliação médica mais acessível e transparente**, permitindo que os usuários avaliem suas consultas com base em critérios como pontualidade, atenção, clareza nas explicações e ambiente do atendimento.

---

## 🚀 Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/aurea.git
   ---

## 🗄️ Banco de Dados

O script de criação do banco de dados está disponível na pasta [`/database`](./database/aurea_database.sql).

### Como importar:

1. Abra o SQL Server Management Studio (SSMS)  
2. Crie um novo banco de dados com o nome desejado  
3. Execute o script `aurea_database.sql` para criar as tabelas e relacionamentos  
4. Atualize a string de conexão no projeto, se necessário

