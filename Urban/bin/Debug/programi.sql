USE [Urban]
GO
/****** Object:  Table [dbo].[PROGRAM]    Script Date: 04/11/2008 13:25:24 ******/

CREATE TABLE [dbo].[PROGRAM](
	[TIPPLAKT] [nvarchar](5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DATUM] [datetime] NULL,
	[ARHBR] [nvarchar](11) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[INICIJAT] [nvarchar](22) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OPSTINA] [nvarchar](15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NAZIV] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OBRADJIVAC] [nvarchar](25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[KARTBR] [nvarchar](4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[VEZA] [nvarchar](4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[REALIZOVAN] [bit] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_PROGRAM] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
go

set identity_insert program on
go
insert into program (TIPPLAKT, DATUM, ARHBR, INICIJAT, OPSTINA, NAZIV, OBRADJIVAC, KARTBR, VEZA, REALIZOVAN, id)
select TIPPLAKT, DATUM, ARHBR, INICIJAT, OPSTINA, NAZIV, OBRADJIVAC, KARTBR, VEZA, REALIZOVAN, id from programi_temp.dbo.program

set identity_insert program off

