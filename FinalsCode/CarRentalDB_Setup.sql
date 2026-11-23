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
        DailyRate DECIMAL(18,2) NOT NULL,
        Status NVARCHAR(20) NOT NULL DEFAULT 'Available'
    );

    PRINT 'Cars table created successfully.';

    -- Seed Initial Cars into the database
    INSERT INTO Cars (Brand, Model, Category, PlateNumber, DailyRate, Status) VALUES
    ('Toyota', 'Camry SE', 'Sedan', 'ABC-1234', 45.00, 'Available'),
    ('Honda', 'CR-V Hybrid', 'SUV', 'CRV-5678', 65.00, 'Available'),
    ('Tesla', 'Model 3 Long Range', 'Electric', 'TSL-9988', 85.00, 'Available'),
    ('Ford', 'Mustang GT', 'Sports', 'MST-4040', 95.00, 'Available'),
    ('BMW', '330i M Sport', 'Luxury', 'BMW-3301', 110.00, 'Available'),
    ('Hyundai', 'Tucson Ultimate', 'SUV', 'TUC-7721', 55.00, 'Available'),
    ('Nissan', 'Altima SV', 'Sedan', 'NSN-3344', 42.00, 'Available'),
    ('Mercedes-Benz', 'C300 Sedan', 'Luxury', 'MBZ-8899', 125.00, 'Available');

    PRINT 'Initial cars inserted successfully.';
END
ELSE
BEGIN
    PRINT 'Cars table already exists.';
END
GO

-- 2. Create Rentals table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Rentals')
BEGIN
    CREATE TABLE Rentals (
        RentalId INT IDENTITY(1001,1) PRIMARY KEY,
        CustomerName NVARCHAR(100) NOT NULL,
        CustomerPhone NVARCHAR(50) NOT NULL,
        CarId INT NOT NULL,
        RentDate DATETIME NOT NULL DEFAULT GETDATE(),
        ReturnDate DATETIME NOT NULL,
        TotalDays INT NOT NULL,
        TotalCost DECIMAL(18,2) NOT NULL,
        Status NVARCHAR(20) NOT NULL DEFAULT 'Active',
        CONSTRAINT FK_Rentals_Cars FOREIGN KEY (CarId) REFERENCES Cars(CarId)
    );

    PRINT 'Rentals table created successfully.';
END
ELSE
BEGIN
    PRINT 'Rentals table already exists.';
END
GO

-- 3. Verification query
SELECT * FROM Cars;
SELECT * FROM Rentals;
GO
