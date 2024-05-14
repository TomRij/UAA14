CREATE DATABASE IF NOT EXISTS BarCocktail;
USE BarCocktail;

CREATE TABLE RECETTE
(
    recetteId INT PRIMARY KEY auto_increment NOT NULL,
    recetteQuantite double not null,
    liquideId int not null,
    cocktailId int not null,
    FOREIGN KEY (liquideId) REFERENCES LIQUIDES(liquideId),
    FOREIGN KEY (cocktailId) REFERENCES COCKTAILS(cocktailId)
);

CREATE TABLE LIQUIDES
(
    liquideId INT PRIMARY KEY auto_increment NOT NULL,
    liquideNom VARCHAR(30) not null,
    liquideType VARCHAR(15) not null
);

CREATE TABLE COCKTAILS
(
    cocktailId INT PRIMARY KEY auto_increment NOT NULL,
    cocktailNom varchar(30) not null
);

-- Ajout de liquides supplémentaires
INSERT INTO LIQUIDES (liquideNom, liquideType) VALUES
('Vodka', 'Alcool'),
('Rhum blanc', 'Alcool'),
('Whisky', 'Alcool'),
('Tequila', 'Alcool'),
('Cointreau', 'Alcool'),
('Gin', 'Alcool'),
('Jus de citron', 'Jus'),
('Jus ananas', 'Jus'),
('Cranberry', 'Jus'),
('Limonade', 'Soda'),
('Grenadine', 'Sirop'),
('Lait de coco', 'Lait');

-- Ajout de cocktails supplémentaires
INSERT INTO COCKTAILS (cocktailNom) VALUES
('Cosmopolitan'),
('Long Island Iced Tea'),
('Whisky Sour'),
('Tequila Sunrise'),
('Gin Tonic');

-- Ajout de recettes supplémentaires
INSERT INTO RECETTE (recetteQuantite, liquideId, cocktailId) VALUES
(1.5, 8, 1), -- 1.5 onces de Jus de citron pour le Cosmopolitan
(1.0, 5, 1), -- 1 once de Cointreau pour le Cosmopolitan
(1.0, 2, 1), -- 1 once de Rhum blanc pour le Cosmopolitan
(0.5, 11, 1), -- 0.5 once de Grenadine pour le Cosmopolitan

(0.5, 3, 2), -- 0.5 once de Whisky pour le Long Island Iced Tea
(0.5, 1, 2), -- 0.5 once de Vodka pour le Long Island Iced Tea
(0.5, 6, 2), -- 0.5 once de Gin pour le Long Island Iced Tea
(0.5, 5, 2), -- 0.5 once de Cointreau pour le Long Island Iced Tea
(1.0, 9, 2), -- 1 once de Limonade pour le Long Island Iced Tea

(2.0, 3, 3), -- 2 onces de Whisky pour le Whisky Sour
(0.75, 8, 3), -- 0.75 once de Jus de citron pour le Whisky Sour
(0.5, 12, 3), -- 0.5 once de Grenadine pour le Whisky Sour

(2.0, 4, 4), -- 2 onces de Tequila pour le Tequila Sunrise
(3.0, 7, 4), -- 3 onces de Jus d'orange pour le Tequila Sunrise
(1.0, 11, 4), -- 1 once de Grenadine pour le Tequila Sunrise

(2.0, 6, 5), -- 2 onces de Gin pour le Gin Tonic
(3.0, 10, 5); -- 3 onces de Limonade pour le Gin Tonic

select * from recette;
select * from cocktails;
select * from liquides;
