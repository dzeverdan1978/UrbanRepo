use Urban
go
ALTER proc [dbo].[IzmeniUticaj] @id int,@opis nvarchar(1000),@datum smalldatetime,@tip int
as
update uticaj set opis=@opis,datum=@datum,id_tip=@tip
where id=@id
go
update regupr
set datsllst=dateadd(yy,100,datsllst)
where year(datsllst) between 1900 and 1910

update tip_uticaja
set opis=upper(opis)

