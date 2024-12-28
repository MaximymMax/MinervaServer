# Table of Contents
- [English version](#database-files)
- [Ukrainian version](#файли-бази-даних)

## DataBase files
- [DB_deployment_script.sql](DB_deployment_script.sql) - use it on a clean new database to create all the tables and relationships to run this script, just run it as a SQL query.
- [link to db scheme](https://drawsql.app/teams/none-2316/diagrams/minervadbscheme) - visual representation of the database structure
- [insert-example-data.sql](insert-example-data.sql) - use it to insert example data in db and test how it works. Currently inserts only into Accounts and Account_types.

## How to deploy DB
To deploy the DB, you need a clean DB in postgres. After creating it, do the following:
1) run the `DB_Deplyument_script.sql` file.
2) run the `insert-example-data.sql` file if you need some data to work with the DB.

## Файли бази даних

- [DB_deployment_script.sql](DB_deployment_script.sql) - використовуйте його в чистій новій базі даних, щоб створити всі таблиці та зв’язки, для запуску цього сценарію, просто запустіть його як SQL-запит.
- [посилання на схему бази даних](https://drawsql.app/teams/none-2316/diagrams/minervadbscheme) - візуальне представлення структури бази даних
- [insert-example-data.sql](insert-example-data.sql) - використовуйте його, щоб вставити приклад даних у базу даних і перевірити, як це працює. Наразі вставляється лише в Accounts і Account_types.

## Як розгорнути БД
Щоб розгорнути БД, вам потрібна чиста БД у postgres. Після його створення виконайте такі дії:
1) запустіть файл `DB_Deplyument_script.sql`.
2) запустіть файл `insert-example-data.sql`, якщо вам потрібні дані для роботи з БД.