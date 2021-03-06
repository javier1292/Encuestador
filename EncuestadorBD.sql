USE [master]
GO
/****** Object:  Database [Encuesta]    Script Date: 7/25/2020 10:11:03 PM ******/
CREATE DATABASE [Encuesta]
GO
USE [Encuesta]
GO
/****** Object:  Table [dbo].[encuestas]    Script Date: 7/25/2020 10:11:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[encuestas](
	[ID_encuesta] [int] IDENTITY(1,1) NOT NULL,
	[ID_usuario] [int] NULL,
	[Nombre_encuesta] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_encuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[preguntas]    Script Date: 7/25/2020 10:11:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[preguntas](
	[ID_pregunta] [int] IDENTITY(1,1) NOT NULL,
	[ID_encuesta] [int] NULL,
	[Pregunta] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_pregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[respuestas]    Script Date: 7/25/2020 10:11:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[respuestas](
	[ID_respuesta] [int] IDENTITY(1,1) NOT NULL,
	[ID_pregunta] [int] NULL,
	[ID_usuario] [int] NULL,
	[Respuesta] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_respuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 7/25/2020 10:11:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[ID_usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[Contra] [varchar](50) NULL,
	[Ccontra] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[encuestas]  WITH CHECK ADD FOREIGN KEY([ID_usuario])
REFERENCES [dbo].[usuarios] ([ID_usuario])
GO
ALTER TABLE [dbo].[preguntas]  WITH CHECK ADD  CONSTRAINT [FK__preguntas__ID_en__2E1BDC42] FOREIGN KEY([ID_encuesta])
REFERENCES [dbo].[encuestas] ([ID_encuesta])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[preguntas] CHECK CONSTRAINT [FK__preguntas__ID_en__2E1BDC42]
GO
ALTER TABLE [dbo].[respuestas]  WITH CHECK ADD FOREIGN KEY([ID_pregunta])
REFERENCES [dbo].[preguntas] ([ID_pregunta])
GO
ALTER TABLE [dbo].[respuestas]  WITH CHECK ADD FOREIGN KEY([ID_usuario])
REFERENCES [dbo].[usuarios] ([ID_usuario])
GO
/****** Object:  StoredProcedure [dbo].[EditarE]    Script Date: 7/25/2020 10:11:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarE]
@nombreEncuesta varchar(200),
@Idencuesta int 
as
Update encuestas set Nombre_encuesta=@nombreEncuesta
where ID_encuesta=@Idencuesta
GO
/****** Object:  StoredProcedure [dbo].[EditarP]    Script Date: 7/25/2020 10:11:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarP]
@Pregunta varchar(200),
@IdPregunta int 
as
Update preguntas set Pregunta=@Pregunta
where ID_pregunta=@IdPregunta
GO
/****** Object:  StoredProcedure [dbo].[ElimarP]    Script Date: 7/25/2020 10:11:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ElimarP]
@IdP int 
as
delete from preguntas where ID_pregunta=@IdP
GO
/****** Object:  StoredProcedure [dbo].[ELiminarEncuesta]    Script Date: 7/25/2020 10:11:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[ELiminarEncuesta]
@IdEncuesta int
as 
delete from encuestas where ID_encuesta=@IdEncuesta
GO
USE [master]
GO
ALTER DATABASE [Encuesta] SET  READ_WRITE 
GO
