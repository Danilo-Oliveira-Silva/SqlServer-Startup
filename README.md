# Como criar um docker compose para projetos com SQL Server

Repositório criado para o artigo: [SQL Server + Docker Compose: como criar e popular bancos de dados ao inicializar os containers](https://dev.to/danilosilva/sql-server-docker-compose-como-criar-e-popular-bancos-de-dados-ao-inicializar-os-containers-4ilf).


## Para inicializar

1º Passo: inicializar os containers

```shell
docker compose up -d --build
```


2º Passo: Caso o banco de dados ainda não tenha sido populado, execute o script

```shell
./init.sh
```
