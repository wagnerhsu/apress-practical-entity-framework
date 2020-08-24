--validate your username
SELECT * from AspNetUsers

--if you can't login, run this with your username
UPDATE AspNetUsers 
SET EmailConfirmed = 1 
WHERE Id = (
	SELECT [Id]
	FROM [dbo].[AspNetUsers]
	WHERE UserName = 'brian@brian.com' --put your username here
)

--if you want to quickly add categories:
/*WARNING: running more than once will create duplicates */
INSERT INTO Categories ([Name])
VALUES ('Books')
INSERT INTO Categories ([Name])
VALUES ('Movies')
INSERT INTO Categories ([Name])
VALUES ('Games')
select * from categories