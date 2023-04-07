-- FICHIER SQL
-- Pour le projet GitForFlemme


-- Base de donnée : cayo_gitforflemme


-- CREATE

-- Table "Repo"
CREATE Table repo (
    repo_id INT(11) AUTO_INCREMENT,
    label VARCHAR(50) DEFAULT 'none' NOT NULL,
    namespace VARCHAR(255) DEFAULT 'none' NOT NULL,
    init ENUM('true','false') DEFAULT 'false',
    CONSTRAINT pk_repo PRIMARY KEY(repo_id)
)

-- Table "Desktop"
CREATE TABLE desktop (
   desk_id INT(11) AUTO_INCREMENT,
   label VARCHAR(25) DEFAULT 'none' NOT NULL,
   description VARCHAR(255),
   folder TEXT,
   repo INT(11),
   CONSTRAINT pk_desktop PRIMARY KEY(desk_id),
   CONSTRAINT fkdesktop_repo FOREIGN KEY(repo) REFERENCES repo(repo_id)
)