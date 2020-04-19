INSERT INTO Users ([Id], [CreateDateTime], [CreateUserId], Email, FirstName, IsActive, IsDeleted, LastName, [Password], UpdateDateTime, UpdateUserId, Username)
VALUES ('9533D915-34AA-4FCD-9C02-30CE6D48F08F', GETDATE(), '9533D915-34AA-4FCD-9C02-30CE6D48F08F', 'fake@fake.gmail.com', 'danny', 1, 0, 'Teixeira', null, GETDATE(), '9533D915-34AA-4FCD-9C02-30CE6D48F08F', 'danotex') 

INSERT INTO Companies ([Id], [CreateDateTime], [CreateUserId], [Description], ImageUrl, IsActive, IsDeleted, Name, UpdateDateTime, UpdateUserId, WebsiteUrl)
VALUES (NEWID(), GETDATE(), '9533D915-34AA-4FCD-9C02-30CE6D48F08F', 'Tin Kitchen Description', 'imageUrl', 1, 0, 'Tin Kitchen', GETDATE(), '9533D915-34AA-4FCD-9C02-30CE6D48F08F', 'siteUrl') 


INSERT INTO FoodTrucks ([Id], [CompanyId], [CreateDateTime], [CreateUserId], [IsActive], [IsDeleted], [Name], [UpdateDateTime], [UpdateUserId])
VALUES  (NEWID(), 'ae9b2432-db40-4821-b12d-a97790182e29', GETDATE(), '9533D915-34AA-4FCD-9C02-30CE6D48F08F', 1, 0, 'Bessie', GETDATE(), '9533D915-34AA-4FCD-9C02-30CE6D48F08F') 
      , (NEWID(), 'ae9b2432-db40-4821-b12d-a97790182e29', GETDATE(), '9533D915-34AA-4FCD-9C02-30CE6D48F08F', 1, 0, 'Ferdinand', GETDATE(), '9533D915-34AA-4FCD-9C02-30CE6D48F08F') 
      , (NEWID(), 'ae9b2432-db40-4821-b12d-a97790182e29', GETDATE(), '9533D915-34AA-4FCD-9C02-30CE6D48F08F', 1, 0, 'Wilbur', GETDATE(), '9533D915-34AA-4FCD-9C02-30CE6D48F08F') 

