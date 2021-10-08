/// <summary>
/// не смог отправить файл из LINQPad
/// не сделать первые 2 задания из 3 пункта и 4 пункт не выполнил
/// </summary>
CREATE DATABASE country_db;
USE country_db;
CREATE TABLE Countrys
(
    id INTEGER NOT NULL PRIMARY KEY,
    country_name VARCHAR(100) NOT NULL,
    capital VARCHAR(100) NOT NULL,
    residents INT NOT NULL,
	area_country INT NOT NULL,
    part_world VARCHAR(100) NOT NULL
);

INSERT INTO Countrys(country_name, capital, residents, area_country, part_world)
VALUES('Россия', 'Москва', 146000000, 17000000, 'Европа'),
('Япония', 'Москва', 125000000, 377000, 'Азия'),
('Германия', 'Москва', 83000000, 357000, 'Европа'),

SELECT* FROM Countrys;

SELECT country_name FROM Countrys;

SELECT capital FROM Countrys;

SELECT* FROM Countrys
SELECT part_world = 'Европа';

SELECT country_name FROM Countrys
SELECT area_country > 360000;


SELECT country_name FROM Countrys
SELECT area_country< 16000000
SELECT area_country > 360000;

SELECT country_name FROM Countrys
SELECT residents > 120000000;