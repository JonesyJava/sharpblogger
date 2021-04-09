CREATE TABLE blogs
(
    id INT NOT NULL AUTO_INCREMENT,
    title VARCHAR(255) NOT NULL,
    body VARCHAR(255),
    imgUrl VARCHAR(255),
    published BOOLEAN,
    creatorId VARCHAR(255),

    PRIMARY KEY (id),

    FOREIGN KEY (creatorId),
        REFERENCES creator (id)
        ON DELETE CASCADE
)