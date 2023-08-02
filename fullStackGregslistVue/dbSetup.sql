-- Active: 1686681110274@@rds-mysql-10mintutorial.c81ovpu4pgjf.us-west-2.rds.amazonaws.com@3306@fullStackGregslistVue

CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        name varchar(255),
        email varchar(255),
        picture varchar(255),
        coverImg VARCHAR(255)
    ) default charset utf8mb4 COMMENT '';

Create TABLE
    IF NOT EXISTS cars (
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
        make VARCHAR(255) NOT NULL,
        model VARCHAR(255) NOT NULL,
        imgUrl VARCHAR(255) NOT NULL,
        body VARCHAR(255) NOT NULL,
        price INT NOT NULL,
        description VARCHAR(500) NOT NULL,
        creatorId VARCHAR(255) NOT NULL
    ) default charset utf8mb4 COMMENT '';