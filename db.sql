-- FICHIER SQL
-- Pour le projet GitForFlemme


-- Base de donnée : gitforflemme


-- CREATE

-- Table "Repo"
CREATE Table repo (
    repo_id INT(11) AUTO_INCREMENT,
    name VARCHAR(50) DEFAULT 'none' NOT NULL,
    namespace_git VARCHAR(255) DEFAULT 'none' NOT NULL,
    CONSTRAINT pk_repo PRIMARY KEY(repo_id)
)