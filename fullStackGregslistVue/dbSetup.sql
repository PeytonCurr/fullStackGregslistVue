-- Active: 1687203860750@@rds-mysql-10mintutorial.c81ovpu4pgjf.us-west-2.rds.amazonaws.com@3306@fullStackGregslistVue

CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture',
        coverImg VARCHAR(255)
    ) default charset utf8mb4 COMMENT '';