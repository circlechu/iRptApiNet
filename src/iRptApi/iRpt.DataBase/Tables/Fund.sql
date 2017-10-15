CREATE TABLE [dbo].[Fund]
(
	[FundId] BIGINT NOT NULL , 
    [FundCode] NVARCHAR(50) NOT NULL, 
    [FundName] NVARCHAR(200) NOT NULL, 
	[ClientId] BIGINT NOT NULL, 
    [ts] ROWVERSION NOT NULL, 
    CONSTRAINT [PK_Fund] PRIMARY KEY ([FundId]), 
    CONSTRAINT [FK_Fund_Client] FOREIGN KEY (CLientId) REFERENCES Client(ClientId) 
)
