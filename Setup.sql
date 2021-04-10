USE sharpblogger;

-- -- DROP TABLE blogs;

-- CREATE TABLE blogs
-- (
--     id INT NOT NULL AUTO_INCREMENT,
--     title VARCHAR(255) NOT NULL,
--     body VARCHAR(255),
--     imgUrl VARCHAR(255),
--     published BOOLEAN,
--     creatorId VARCHAR(255),

--     PRIMARY KEY (id)

--     -- FOREIGN KEY (creatorId)
--     --     REFERENCES profiles (id)
--     --     ON DELETE CASCADE
    
-- )
    -- CREATE TABLE Profile
    -- (
    --     id VARCHAR(255) NOT NULL,
    --     name VARCHAR(255) NOT NULL,
    --     email VARCHAR(255) NOT NULL,
    --     picture VARCHAR(255) NOT NULL,

    --     PRIMARY KEY (id)
    -- )
    CREATE TABLE comments
    (
        id INT NOT NULL AUTO_INCREMENT,
        creatorId VARCHAR(255) NOT NULL,
        body VARCHAR(255) NOT NULL,
        blogId INT NOT NULL,

        PRIMARY KEY (id),

        FOREIGN KEY (blogid)
            REFERENCES blogs (id)
            ON DELETE CASCADE
    )