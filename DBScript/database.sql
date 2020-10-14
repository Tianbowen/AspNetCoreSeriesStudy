CREATE TABLE `Owner` (
`OwnerId` char(36) NOT NULL,
`Name` nvarchar NOT NULL,
`DateOfBirth` date NOT NULL,
`Address` nvarchar NOT NULL,
PRIMARY KEY (`OwnerId`) 
);

CREATE TABLE `Account` (
`AccountId` char(36) NOT NULL,
`DateCreated` date NOT NULL,
`AccountType` nvarchar NOT NULL,
`OwnerId` char(36) NOT NULL,
PRIMARY KEY (`AccountId`) 
);


ALTER TABLE `Account` ADD CONSTRAINT `fk_account_owner` FOREIGN KEY (`OwnerId`) REFERENCES `Owner` (`OwnerId`);

