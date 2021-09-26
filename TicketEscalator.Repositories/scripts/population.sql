-- Populate into Customers
INSERT INTO Customers (Id, Name, Address, SSN) VALUES(1, 'Íslandspóstur', 'Stórhöfði', '');
INSERT INTO Customers (Id, Name, Address, SSN) VALUES(2, 'Reiknistofa Bankanna', 'Kalkofnsvegur', '');
INSERT INTO Customers (Id, Name, Address, SSN) VALUES(3, 'Umslag', 'Lágmúli', '');
INSERT INTO Customers (Id, Name, Address, SSN) VALUES(4, 'Landsbankinn', 'Mjódd', '');

-- Populate into Customer Contacts
INSERT INTO CustomerContacts (Id, Name, PhoneNumber, Email, CustomerId) VALUES(1, 'Gyða', '825-1212', 'gydaa@postur.is', 1);
INSERT INTO CustomerContacts (Id, Name, PhoneNumber, Email, CustomerId) VALUES(2, 'Albert', '825-1215', 'abertk@postur.is', 4);
INSERT INTO CustomerContacts (Id, Name, PhoneNumber, Email, CustomerId) VALUES(3, 'Helena', '888-1111', 'helena@umslag.is', 3);
INSERT INTO CustomerContacts (Id, Name, PhoneNumber, Email, CustomerId) VALUES(4, 'Elín', '777-1111', 'Elin.Ulfarsdottir@rb.is.', 2);

-- Populate into Employees
INSERT INTO Employees (Id, Name, Email, Password) VALUES(1, 'Birgir', 'birgir@oba.is', '1234');
INSERT INTO Employees (Id, Name, Email, Password) VALUES(2, 'Snorri', 'snorri@oba.is', '3421');
INSERT INTO Employees (Id, Name, Email, Password) VALUES(3, 'Davíð', 'david@oba.is', '4321');
INSERT INTO Employees (Id, Name, Email, Password) VALUES(4, 'Óli Rowell', 'friggz@friggz.is', '1234');

-- Populate into Products
INSERT INTO Products (Id, Name, SerialNumber, Usage) VALUES(1, 'Vantage', '4033', 43000);
INSERT INTO Products (Id, Name, SerialNumber, Usage) VALUES(2, 'MX2100', '13699', 234234234);
INSERT INTO Products (Id, Name, SerialNumber, Usage) VALUES(3, 'Pitney Bowes Di600', '1234', 764444);
INSERT INTO Products (Id, Name, SerialNumber, Usage) VALUES(4, 'DI350', '4516', 236666);

-- Populate into Repairs
INSERT INTO Repairs (Id, Description, DaytimeHours, OvertimeHours, Trip, RepairDate) VALUES(1, 'skipt um prenthaus', 2.0, NULL, 1, 2020-01-01);
INSERT INTO Repairs (Id, Description, DaytimeHours, OvertimeHours, Trip, RepairDate) VALUES(2, 'skipt um reim', 2.0, NULL, 1, 2021-04-05);
INSERT INTO Repairs (Id, Description, DaytimeHours, OvertimeHours, Trip, RepairDate) VALUES(3, 'vél endurræst', 1.5, 0.5, 1, 2021-06-07);
INSERT INTO Repairs (Id, Description, DaytimeHours, OvertimeHours, Trip, RepairDate) VALUES(4, 'valsar þrifnir', 2, NULL, 1, 2021-06-03);

-- Populate into SpareParts
INSERT INTO SpareParts (Id, PartsNumber, Name, Price) VALUES(1, '546123-001', 'belti', 1234);
INSERT INTO SpareParts (Id, PartsNumber, Name, Price) VALUES(2, '555111-002', 'reim', 2222);
INSERT INTO SpareParts (Id, PartsNumber, Name, Price) VALUES(3, '459111-001', 'hjól', 3500);
INSERT INTO SpareParts (Id, PartsNumber, Name, Price) VALUES(4, 'gb3422-22', 'kefli', NULL);

-- Populate into Tickets
INSERT INTO Tickets (Id, AssigneeID, CreatorID, CustomerContacted, CustomerId, Description, ExtraItems, ReadyDate, RegisterDate) VALUES(1, 3, 1, TRUE , 1, 'Bilaður stakker', NULL, 2020-01-01, DATE('now'));
INSERT INTO Tickets (Id, AssigneeID, CreatorID, CustomerContacted, CustomerId, Description, ExtraItems, ReadyDate, RegisterDate) VALUES(2, NULL, 2, FALSE, 2, 'lína í korti',    NULL, NULL, DATE('now'));
INSERT INTO Tickets (Id, AssigneeID, CreatorID, CustomerContacted, CustomerId, Description, ExtraItems, ReadyDate, RegisterDate) VALUES(3, NULL, 2, FALSE, 3, 'Flækir',          NULL, NULL, DATE('now'));
INSERT INTO Tickets (Id, AssigneeID, CreatorID, CustomerContacted, CustomerId, Description, ExtraItems, ReadyDate, RegisterDate) VALUES(4, NULL, 3, FALSE, 4, 'Bilað inntak',    'snúra fylgir', NULL, DATE('now'));

