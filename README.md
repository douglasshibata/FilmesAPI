# Filmes API
Projeto realizado com auxílio da alura da aula **API Rest com .NET 5: Operações essenciais com verbos HTTP**

### Criar projeto
Criar o projeto na pasta que deseja e rodar o comando
```bash
donet new webapi
```

### Executar o projeto
```bash
dotnet watch run
```

### Para instalar os pacotes
Instalando os pacotes necessários para a conexão com o banco de dados

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.5
```

```bash
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.5
```

MySQL
```bash
dotnet add package MySql.Data.EntityFrameworkCore --version 5.0.3
```

### Docker mysql 
```bash
docker run --name filmes-api -p 3306:3306 -e MYSQL_USER=root -e MYSQL_PASSWORD=root -e MYSQL_ROOT_PASSWORD=root -e MYSQL_DATABASE=filmeDb -d mariadb:10.5
```


### Migrações no banco
Abra o console de gerenciamento de pacotes, no visual studio está localizado em ferramentas -> gerenciador de pacotes nuget
Para adicionar uma migration
```bash
Add-Migration CriandoTabelaFilme
```

Para atualizar o banco de dados
```bash
Update-Database
```

#### No linux
Execute o comando para instalar o dotnet ef tools:
```bash
dotnet tool install --global dotnet-ef
```

Execute o comando de criação de migration:
```bash
dotnet ef migrations add FilmeMigration
```

Aplique as mudanças no banco de dados:
```bash
dotnet ef database update
```