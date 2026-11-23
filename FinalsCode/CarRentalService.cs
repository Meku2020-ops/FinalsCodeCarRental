using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace FinalsCode
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Category { get; set; } = "Sedan";
        public string PlateNumber { get; set; } = string.Empty;
        public decimal DailyRate { get; set; }
        public string Status { get; set; } = "Available";

        public string DisplayName => $"{Brand} {Model} ({Category}) - ${DailyRate:F2}/day";
    }

    public class Rental
    {
        public int RentalId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhone { get; set; } = string.Empty;
        public int CarId { get; set; }
        public string CarName { get; set; } = string.Empty;
        public DateTime RentDate { get; set; } = DateTime.Now;
        public DateTime ReturnDate { get; set; } = DateTime.Now.AddDays(3);
        public int TotalDays { get; set; } = 3;
        public decimal TotalCost { get; set; }
        public string Status { get; set; } = "Active";
    }

    public class DashboardStats
    {
        public int TotalCars { get; set; }
        public int AvailableCars { get; set; }
        public int RentedCars { get; set; }
        public decimal TotalRevenue { get; set; }
    }

    public static class CarRentalService
    {
        public static string ConnectionString { get; set; } =
            "Server=RIAMU\\SQLEXPRESS;Database=CarRentalDB;Trusted_Connection=True;TrustServerCertificate=True;";

        private static SqlConnection GetOpenConnection()
        {
            var con = new SqlConnection(ConnectionString);
            con.Open();
            return con;
        }

        /// <summary>
        /// Automatically creates the Cars and Rentals tables in CarRentalDB if they do not exist yet.
        /// Also seeds standard fleet rows so the database has immediate data to display.
        /// </summary>
        public static bool EnsureDatabaseTables(out string message)
        {
            try
            {
                using var con = GetOpenConnection();

                string sqlScript = @"
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

    INSERT INTO Cars (Brand, Model, Category, PlateNumber, DailyRate, Status) VALUES
    ('Toyota', 'Camry SE', 'Sedan', 'ABC-1234', 45.00, 'Available'),
    ('Honda', 'CR-V Hybrid', 'SUV', 'CRV-5678', 65.00, 'Available'),
    ('Tesla', 'Model 3 Long Range', 'Electric', 'TSL-9988', 85.00, 'Available'),
    ('Ford', 'Mustang GT', 'Sports', 'MST-4040', 95.00, 'Available'),
    ('BMW', '330i M Sport', 'Luxury', 'BMW-3301', 110.00, 'Available'),
    ('Hyundai', 'Tucson Ultimate', 'SUV', 'TUC-7721', 55.00, 'Available'),
    ('Nissan', 'Altima SV', 'Sedan', 'NSN-3344', 42.00, 'Available'),
    ('Mercedes-Benz', 'C300 Sedan', 'Luxury', 'MBZ-8899', 125.00, 'Available');
END;

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
END;";

                using var cmd = new SqlCommand(sqlScript, con);
                cmd.ExecuteNonQuery();

                message = "Cars and Rentals tables verified / created in CarRentalDB successfully!";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static List<Car> GetCars()
        {
            var list = new List<Car>();
            try
            {
                using var con = GetOpenConnection();
                const string query = "SELECT CarId, Brand, Model, Category, PlateNumber, DailyRate, Status FROM Cars ORDER BY CarId ASC";
                using var cmd = new SqlCommand(query, con);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Car
                    {
                        Id = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        Model = reader.GetString(2),
                        Category = reader.GetString(3),
                        PlateNumber = reader.GetString(4),
                        DailyRate = reader.GetDecimal(5),
                        Status = reader.GetString(6)
                    });
                }
            }
            catch
            {
                // Fallback to empty list if database not yet initialized or offline
            }
            return list;
        }

        public static List<Car> GetAvailableCars()
        {
            var list = new List<Car>();
            try
            {
                using var con = GetOpenConnection();
                const string query = "SELECT CarId, Brand, Model, Category, PlateNumber, DailyRate, Status FROM Cars WHERE Status = 'Available' ORDER BY Brand ASC";
                using var cmd = new SqlCommand(query, con);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Car
                    {
                        Id = reader.GetInt32(0),
                        Brand = reader.GetString(1),
                        Model = reader.GetString(2),
                        Category = reader.GetString(3),
                        PlateNumber = reader.GetString(4),
                        DailyRate = reader.GetDecimal(5),
                        Status = reader.GetString(6)
                    });
                }
            }
            catch
            {
                // Fallback
            }
            return list;
        }

        public static List<Rental> GetRentals()
        {
            var list = new List<Rental>();
            try
            {
                using var con = GetOpenConnection();
                const string query = @"
SELECT r.RentalId, r.CustomerName, r.CustomerPhone, r.CarId, 
       c.Brand + ' ' + c.Model AS CarName, 
       r.RentDate, r.ReturnDate, r.TotalDays, r.TotalCost, r.Status 
FROM Rentals r 
INNER JOIN Cars c ON r.CarId = c.CarId 
ORDER BY r.RentalId DESC";

                using var cmd = new SqlCommand(query, con);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Rental
                    {
                        RentalId = reader.GetInt32(0),
                        CustomerName = reader.GetString(1),
                        CustomerPhone = reader.GetString(2),
                        CarId = reader.GetInt32(3),
                        CarName = reader.GetString(4),
                        RentDate = reader.GetDateTime(5),
                        ReturnDate = reader.GetDateTime(6),
                        TotalDays = reader.GetInt32(7),
                        TotalCost = reader.GetDecimal(8),
                        Status = reader.GetString(9)
                    });
                }
            }
            catch
            {
                // Fallback
            }
            return list;
        }

        public static DashboardStats GetDashboardStats()
        {
            var stats = new DashboardStats();
            try
            {
                using var con = GetOpenConnection();

                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Cars", con))
                {
                    stats.TotalCars = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE Status = 'Available'", con))
                {
                    stats.AvailableCars = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE Status = 'Rented'", con))
                {
                    stats.RentedCars = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (var cmd = new SqlCommand("SELECT ISNULL(SUM(TotalCost), 0) FROM Rentals", con))
                {
                    stats.TotalRevenue = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
            catch
            {
                // Leave zeroes if connection fails
            }

            return stats;
        }

        public static bool AddCar(string brand, string model, string category, string plate, decimal rate, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model))
            {
                error = "Brand and Model are required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(plate))
            {
                error = "Plate number is required.";
                return false;
            }
            if (rate <= 0)
            {
                error = "Daily rate must be greater than 0.";
                return false;
            }

            try
            {
                using var con = GetOpenConnection();
                const string query = @"
INSERT INTO Cars (Brand, Model, Category, PlateNumber, DailyRate, Status) 
VALUES (@Brand, @Model, @Category, @Plate, @Rate, 'Available')";

                using var cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Brand", brand.Trim());
                cmd.Parameters.AddWithValue("@Model", model.Trim());
                cmd.Parameters.AddWithValue("@Category", category.Trim());
                cmd.Parameters.AddWithValue("@Plate", plate.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@Rate", rate);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public static bool BookCar(string customerName, string customerPhone, int carId, int days, out Rental? rental, out string error)
        {
            rental = null;
            error = string.Empty;

            if (string.IsNullOrWhiteSpace(customerName))
            {
                error = "Customer name is required.";
                return false;
            }
            if (days < 1)
            {
                error = "Rental duration must be at least 1 day.";
                return false;
            }

            try
            {
                using var con = GetOpenConnection();
                using var transaction = con.BeginTransaction();

                // 1. Get Car details
                decimal dailyRate = 0;
                string carName = "";
                string status = "";

                using (var selectCmd = new SqlCommand("SELECT Brand + ' ' + Model, DailyRate, Status FROM Cars WITH (UPDLOCK) WHERE CarId = @CarId", con, transaction))
                {
                    selectCmd.Parameters.AddWithValue("@CarId", carId);
                    using var reader = selectCmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        error = "Selected car does not exist.";
                        transaction.Rollback();
                        return false;
                    }
                    carName = reader.GetString(0);
                    dailyRate = reader.GetDecimal(1);
                    status = reader.GetString(2);
                }

                if (status != "Available")
                {
                    error = $"Vehicle '{carName}' is already rented or not available.";
                    transaction.Rollback();
                    return false;
                }

                decimal totalCost = dailyRate * days;
                DateTime rentDate = DateTime.Today;
                DateTime returnDate = rentDate.AddDays(days);
                int newRentalId = 0;

                // 2. Insert into Rentals
                const string insertSql = @"
INSERT INTO Rentals (CustomerName, CustomerPhone, CarId, RentDate, ReturnDate, TotalDays, TotalCost, Status) 
OUTPUT INSERTED.RentalId 
VALUES (@Name, @Phone, @CarId, @RentDate, @ReturnDate, @Days, @Cost, 'Active')";

                using (var insertCmd = new SqlCommand(insertSql, con, transaction))
                {
                    insertCmd.Parameters.AddWithValue("@Name", customerName.Trim());
                    insertCmd.Parameters.AddWithValue("@Phone", customerPhone.Trim());
                    insertCmd.Parameters.AddWithValue("@CarId", carId);
                    insertCmd.Parameters.AddWithValue("@RentDate", rentDate);
                    insertCmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                    insertCmd.Parameters.AddWithValue("@Days", days);
                    insertCmd.Parameters.AddWithValue("@Cost", totalCost);

                    newRentalId = (int)insertCmd.ExecuteScalar();
                }

                // 3. Update Car status
                using (var updateCmd = new SqlCommand("UPDATE Cars SET Status = 'Rented' WHERE CarId = @CarId", con, transaction))
                {
                    updateCmd.Parameters.AddWithValue("@CarId", carId);
                    updateCmd.ExecuteNonQuery();
                }

                transaction.Commit();

                rental = new Rental
                {
                    RentalId = newRentalId,
                    CustomerName = customerName.Trim(),
                    CustomerPhone = customerPhone.Trim(),
                    CarId = carId,
                    CarName = carName,
                    RentDate = rentDate,
                    ReturnDate = returnDate,
                    TotalDays = days,
                    TotalCost = totalCost,
                    Status = "Active"
                };

                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public static bool ReturnCar(int rentalId, out string message)
        {
            try
            {
                using var con = GetOpenConnection();
                using var transaction = con.BeginTransaction();

                int carId = 0;
                string status = "";

                using (var checkCmd = new SqlCommand("SELECT CarId, Status FROM Rentals WITH (UPDLOCK) WHERE RentalId = @RentalId", con, transaction))
                {
                    checkCmd.Parameters.AddWithValue("@RentalId", rentalId);
                    using var reader = checkCmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        message = "Rental record not found.";
                        transaction.Rollback();
                        return false;
                    }
                    carId = reader.GetInt32(0);
                    status = reader.GetString(1);
                }

                if (status == "Returned")
                {
                    message = "This rental is already marked as returned.";
                    transaction.Rollback();
                    return false;
                }

                // Update rental to Returned
                using (var updateRentCmd = new SqlCommand("UPDATE Rentals SET Status = 'Returned' WHERE RentalId = @RentalId", con, transaction))
                {
                    updateRentCmd.Parameters.AddWithValue("@RentalId", rentalId);
                    updateRentCmd.ExecuteNonQuery();
                }

                // Update car to Available
                using (var updateCarCmd = new SqlCommand("UPDATE Cars SET Status = 'Available' WHERE CarId = @CarId", con, transaction))
                {
                    updateCarCmd.Parameters.AddWithValue("@CarId", carId);
                    updateCarCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                message = $"Rental #{rentalId} returned successfully! Vehicle is now Available.";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool TestConnection(out string message)
        {
            try
            {
                using var con = GetOpenConnection();
                message = "Connected to CarRentalDB successfully!";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}
