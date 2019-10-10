--T_02_Gufos_DML.sql

use T_Gufos

insert into Usuarios	(Nome, Email, Senha, Permissao)
values					('Clayton','c.y@mail.com','123456','ADMINISTRADOR'),
						('admin','admin@admin.com','admin','ADMINISTRADOR')

insert into Usuarios	(Nome, Email, Senha, Permissao)
values					('Rayssa','rayssa@gmail.com','r123456','ALUNO')

insert into Categorias	(Nome) 
values					('Jogos'),
						('Meetup'),
						('Futebol');

insert into Eventos		(Titulo, Descricao, DataEvento, Ativo, Localizacao, IdCategoria)
values					('Campeonato de Ping-pong','Campeonato entre as turmas de tec. de redes e dev', GETDATE(), 1, 'Alameda Barão de Limeira, 539',1);
-- Formato de data e hora: AAAA-MM-DDThh:mm:ss[.mmm]

insert Eventos	(Titulo, Descricao, DataEvento, Localizacao, IdCategoria)
values			('futebol no terraço','Do Nucleo Desenvolvimento Senai','2019-08-06T18:00:00' , 'Alameda Barão de Limeira, 539',2);

insert into Presencas	(IdEvento,IdUsuario)
values					(1,2),
						(1,1),
						(2,2);

update Eventos set IdCategoria = 3 where IdEvento = 3
