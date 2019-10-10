use T_Gufos

Select * from Categorias order by Nome asc
Select * from Eventos
Select * from Usuarios
Select * from Presencas

select E.*, C.*
from Eventos as E
join Categorias as C
on E.IdCategoria = C.IdCategoria; --Selecionar Eventos e categorias;

Select P.*, U.*, E.*
from Presencas P
join Usuarios U
on P.IdUsuario = U.IdUsuario
join Eventos E
on P.IdEvento = E.IdEvento --Selecionar Eventos, Usuários e Presenças;

Select P.*, U.*, E.*, C.*
from Presencas P
inner join Usuarios U
on P.IdUsuario = U.IdUsuario
inner join Eventos E
on P.IdEvento = E.IdEvento
inner join Categorias C
on E.IdCategoria = C.IdCategoria; --Selecionar Presenças, Usuários, Eventos e Categorias;

-- Criando uma VIEW para facilitar a visualização dos dados
GO
CREATE VIEW EVENTOSVIEW AS
	SELECT E.IdEvento, E.Titulo, E.Descricao, E.Localizacao, E.DataEvento, C.Nome
	FROM EVENTOS E
	INNER JOIN CATEGORIAS C
	ON E.IdCategoria = C.IdCategoria
GO

SELECT * FROM EVENTOSVIEW
