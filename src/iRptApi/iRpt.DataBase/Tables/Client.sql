CREATE TABLE [dbo].[Client]
(
	[ClientId] BIGINT NOT NULL , 
    [ClientCode] NVARCHAR(30) NOT NULL, 
    [ClientName] NVARCHAR(200) NOT NULL, 
    CONSTRAINT [PK_Client] PRIMARY KEY ([ClientId])
)
