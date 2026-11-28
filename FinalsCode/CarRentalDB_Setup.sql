-- ========================================================
-- CarRentalDB Database Setup Script
-- You can run this in SQL Server Management Studio (SSMS)
-- ========================================================

USE CarRentalDB;
GO

-- 1. Create Cars table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cars')
BEGIN
    CREATE TABLE Cars (
        CarId INT IDENTITY(1,1) PRIMARY KEY,
        Brand NVARCHAR(50) NOT NULL,
        Model NVARCHAR(50) NOT NULL,
        Category NVARCHAR(50) NOT NULL,
        PlateNumber NVARCHAR(20) UNIQUE NOT NULL,
        Seaters INT NOT NULL DEFAULT 5,
        DailyRate DECIMAL(18,2) NOT NULL,
        Status NVARCHAR(20) NOT NULL DEFAULT 'Available'
    );

    PRINT 'Cars table created successfully.';

    -- Seed Initial Cars into the database
    EXEC(N'
        INSERT INTO Cars (Brand, Model, Category, PlateNumber, Seaters, DailyRate, Status) VALUES
        (''Toyota'', ''Camry SE'', ''Sedan'', ''ABC-1234'', 5, 45.00, ''Available''),
        (''Honda'', ''CR-V Hybrid'', ''SUV'', ''CRV-5678'', 5, 65.00, ''Available''),
        (''Tesla'', ''Model 3 Long Range'', ''Electric'', ''TSL-9988'', 5, 85.00, ''Available''),
        (''Ford'', ''Mustang GT'', ''Sports'', ''MST-4040'', 4, 95.00, ''Available''),
        (''BMW'', ''330i M Sport'', ''Luxury'', ''BMW-3301'', 5, 110.00, ''Available''),
        (''Hyundai'', ''Tucson Ultimate'', ''SUV'', ''TUC-7721'', 5, 55.00, ''Available''),
        (''Nissan'', ''Altima SV'', ''Sedan'', ''NSN-3344'', 5, 42.00, ''Available''),
        (''Mercedes-Benz'', ''C300 Sedan'', ''Luxury'', ''MBZ-8899'', 5, 125.00, ''Available'');
    ');

    PRINT 'Initial cars inserted successfully.';
END
ELSE
BEGIN
    IF COL_LENGTH('Cars', 'Seaters') IS NULL
    BEGIN
        ALTER TABLE Cars ADD Seaters INT NOT NULL DEFAULT 5;
        EXEC(N'UPDATE Cars SET Seaters = 4 WHERE PlateNumber = ''MST-4040'';');
        PRINT 'Seaters column added to existing Cars table.';
    END
    ELSE
    BEGIN
        PRINT 'Cars table already exists.';
    END
END
GO

-- 2. Create Rentals table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Rentals')
BEGIN
    CREATE TABLE Rentals (
        RentalId INT IDENTITY(1001,1) PRIMARY KEY,
        CustomerName NVARCHAR(100) NOT NULL,
        CustomerPhone NVARCHAR(50) NOT NULL,
        CustomerEmail NVARCHAR(100) NULL,
        IdType NVARCHAR(50) NULL,
        CustomerAddress NVARCHAR(200) NULL,
        CarId INT NOT NULL,
        RentDate DATETIME NOT NULL DEFAULT GETDATE(),
        ReturnDate DATETIME NOT NULL,
        TotalDays INT NOT NULL,
        TotalCost DECIMAL(18,2) NOT NULL,
        PickupLocation NVARCHAR(100) NULL,
        PaymentMethod NVARCHAR(50) NULL,
        SpecialRequest NVARCHAR(300) NULL,
        Status NVARCHAR(20) NOT NULL DEFAULT 'Active',
        CONSTRAINT FK_Rentals_Cars FOREIGN KEY (CarId) REFERENCES Cars(CarId)
    );

    PRINT 'Rentals table created successfully.';
END
ELSE
BEGIN
    IF COL_LENGTH('Rentals', 'CustomerEmail') IS NULL ALTER TABLE Rentals ADD CustomerEmail NVARCHAR(100) NULL;
    IF COL_LENGTH('Rentals', 'IdType') IS NULL ALTER TABLE Rentals ADD IdType NVARCHAR(50) NULL;
    IF COL_LENGTH('Rentals', 'CustomerAddress') IS NULL ALTER TABLE Rentals ADD CustomerAddress NVARCHAR(200) NULL;
    IF COL_LENGTH('Rentals', 'PickupLocation') IS NULL ALTER TABLE Rentals ADD PickupLocation NVARCHAR(100) NULL;
    IF COL_LENGTH('Rentals', 'PaymentMethod') IS NULL ALTER TABLE Rentals ADD PaymentMethod NVARCHAR(50) NULL;
    IF COL_LENGTH('Rentals', 'SpecialRequest') IS NULL ALTER TABLE Rentals ADD SpecialRequest NVARCHAR(300) NULL;
    PRINT 'Rentals table verified.';
END
GO

-- 3. Verification query
SELECT * FROM Cars;
SELECT * FROM Rentals;
GO
