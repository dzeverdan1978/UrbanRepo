USE [Urban]
GO

alter table Uticaj drop constraint [FK_Uticaj_Tip_uticaja]

ALTER TABLE [dbo].[Uticaj]  WITH CHECK ADD  CONSTRAINT [FK_Uticaj_Tip_uticaja] FOREIGN KEY([id_tip])
REFERENCES [dbo].[Tip_uticaja] ([id])
go
alter table regupr
alter column oznmat nvarchar(50) null