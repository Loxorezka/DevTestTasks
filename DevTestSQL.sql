-- Для упрощения ситуации, все констрейнты опущены

CREATE TABLE [dbo].[Categories](
	[id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Products](
	[id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProdCat](
	[prodId] [int] NOT NULL,
	[catId] [int] NOT NULL
) ON [PRIMARY]
GO

select P.Name, Isnull(c.Name,'Undefined')
	from Products p
		left outer join ProdCat pc on pc.prodId = p.Id
		left outer join Categories c on c.id = pc.catId

select * --IsNull(P.Name,'Undefined'), Isnull(c.Name,'Undefined')
	from ProdCat pc
		full outer join Products p on pc.prodId = p.Id
		full outer join Categories c on c.id = pc.catId