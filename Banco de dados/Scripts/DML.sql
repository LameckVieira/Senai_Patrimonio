USE Senai_Patrimonios

INSERT INTO Sala( Nome, Andar, Metragem) 
VALUES			('Sala Dev´s','3','15'),
				('Sala Design','2','20')
;

INSERT INTO Equipamento(IdSala, Marca, Tipo, Serie, Descricao, Patrimonio, Estado) 
VALUES				   ('1','Dell','NoteBook','2132323','IntelCore i5 10º Geração, 8gb RAM, 1gb de armazenamento','123456','Ativo'),
					   ('2','MadeiraMadeira','Mesa Comum','2132323','Mesa de madeira','654321','Inativo'),
					   ('1','Mouse','LogiTech','7679779','Mouse Optico','876876','Ativo')
;

INSERT INTO Usuario( Email, Senha) 
VALUES			   ('admin@admin.com','admin123')
;
