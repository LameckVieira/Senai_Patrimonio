USE Senai_Patrimonios

SELECT * FROM Sala

SELECT  * FROM Equipamento

SELECT * FROM Usuario

SELECT Sala.Nome AS Sala, Equipamento.Descricao AS Equipamento, Equipamento.Tipo AS TipoEquipamento
FROM Equipamento
INNER JOIN Sala
ON Equipamento.IdSala = Sala.IdSala;