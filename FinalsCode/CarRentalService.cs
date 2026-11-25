using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace FinalsCode
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";
        public string Category { get; set; } = "Sedan";
        public string PlateNumber { get; set; } = "";
        public decimal DailyRate { get; set; }
        public string Status { get; set; } = "Available";

        public string DisplayName => Brand + " " + Model + " (" + Category + ") - ₱" + DailyRate.ToString("F2") + "/day";
    }

    public class Rental
    {
        public int RentalId { get; set; }
        public string CustomerName { get; set; } = "";
        public string CustomerPhone { get; set; } = "";
        public int CarId { get; set; }
        public string CarName { get; set; } = "";
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
            "Server=RIAMU\\SQLEXPRESS;Database=CarRentalDB;Trusted_Connection=True;TrustServerCertificate=True;Connection Timeout=5;";

        public static bool EnsureDatabaseTables(out string message)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    string sql = @"
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

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    message = "Cars and Rentals tables verified / created successfully!";
                    return true;
                }
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
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT CarId, Brand, Model, Category, PlateNumber, DailyRate, Status FROM Cars ORDER BY CarId ASC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car car = new Car();
                            car.Id = Convert.ToInt32(reader["CarId"]);
                            car.Brand = reader["Brand"].ToString()!;
                            car.Model = reader["Model"].ToString()!;
                            car.Category = reader["Category"].ToString()!;
                            car.PlateNumber = reader["PlateNumber"].ToString()!;
                            car.DailyRate = Convert.ToDecimal(reader["DailyRate"]);
                            car.Status = reader["Status"].ToString()!;
                            list.Add(car);
                        }
                    }
                }
            }
            catch
            {
            }
            return list;
        }

        public static List<Car> GetAvailableCars()
        {
            var list = new List<Car>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT CarId, Brand, Model, Category, PlateNumber, DailyRate, Status FROM Cars WHERE Status = 'Available' ORDER BY Brand ASC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car car = new Car();
                            car.Id = Convert.ToInt32(reader["CarId"]);
                            car.Brand = reader["Brand"].ToString()!;
                            car.Model = reader["Model"].ToString()!;
                            car.Category = reader["Category"].ToString()!;
                            car.PlateNumber = reader["PlateNumber"].ToString()!;
                            car.DailyRate = Convert.ToDecimal(reader["DailyRate"]);
                            car.Status = reader["Status"].ToString()!;
                            list.Add(car);
                        }
                    }
                }
            }
            catch
            {
            }
            return list;
        }

        public static List<Rental> GetRentals()
        {
            var list = new List<Rental>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = @"
SELECT r.RentalId, r.CustomerName, r.CustomerPhone, r.CarId,
       c.Brand + ' ' + c.Model AS CarName,
       r.RentDate, r.ReturnDate, r.TotalDays, r.TotalCost, r.Status
FROM Rentals r
INNER JOIN Cars c ON r.CarId = c.CarId
ORDER BY r.RentalId DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rental rental = new Rental();
                            rental.RentalId = Convert.ToInt32(reader["RentalId"]);
                            rental.CustomerName = reader["CustomerName"].ToString()!;
                            rental.CustomerPhone = reader["CustomerPhone"].ToString()!;
                            rental.CarId = Convert.ToInt32(reader["CarId"]);
                            rental.CarName = reader["CarName"].ToString()!;
                            rental.RentDate = Convert.ToDateTime(reader["RentDate"]);
                            rental.ReturnDate = Convert.ToDateTime(reader["ReturnDate"]);
                            rental.TotalDays = Convert.ToInt32(reader["TotalDays"]);
                            rental.TotalCost = Convert.ToDecimal(reader["TotalCost"]);
                            rental.Status = reader["Status"].ToString()!;
                            list.Add(rental);
                        }
                    }
                }
            }
            catch
            {
            }
            return list;
        }

        public static DashboardStats GetDashboardStats()
        {
            var stats = new DashboardStats();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cars", con))
                    {
                        stats.TotalCars = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE Status = 'Available'", con))
                    {
                        stats.AvailableCars = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cars WHERE Status = 'Rented'", con))
                    {
                        stats.RentedCars = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(TotalCost), 0) FROM Rentals", con))
                    {
                        stats.TotalRevenue = Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
            }
            return stats;
        }

        public static bool AddCar(string brand, string model, string category, string plate, decimal rate, out string error)
        {
            error = "";
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
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Cars (Brand, Model, Category, PlateNumber, DailyRate, Status) VALUES (@Brand, @Model, @Category, @Plate, @Rate, 'Available')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Brand", brand.Trim());
                        cmd.Parameters.AddWithValue("@Model", model.Trim());
                        cmd.Parameters.AddWithValue("@Category", category.Trim());
                        cmd.Parameters.AddWithValue("@Plate", plate.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Rate", rate);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
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
            error = "";

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
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    decimal dailyRate = 0;
                    string carName = "";
                    string status = "";

                    using (SqlCommand selectCmd = new SqlCommand("SELECT Brand + ' ' + Model AS CarName, DailyRate, Status FROM Cars WHERE CarId = @CarId", con))
                    {
                        selectCmd.Parameters.AddWithValue("@CarId", carId);
                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                error = "Selected car does not exist.";
                                return false;
                            }
                            carName = reader["CarName"].ToString()!;
                            dailyRate = Convert.ToDecimal(reader["DailyRate"]);
                            status = reader["Status"].ToString()!;
                        }
                    }

                    if (status != "Available")
                    {
                        error = "Vehicle '" + carName + "' is already rented or not available.";
                        return false;
                    }

                    decimal totalCost = dailyRate * days;
                    DateTime rentDate = DateTime.Today;
                    DateTime returnDate = rentDate.AddDays(days);

                    string insertSql = @"
INSERT INTO Rentals (CustomerName, CustomerPhone, CarId, RentDate, ReturnDate, TotalDays, TotalCost, Status)
VALUES (@Name, @Phone, @CarId, @RentDate, @ReturnDate, @Days, @Cost, 'Active');
SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    int newRentalId;
                    using (SqlCommand insertCmd = new SqlCommand(insertSql, con))
                    {
                        insertCmd.Parameters.AddWithValue("@Name", customerName.Trim());
                        insertCmd.Parameters.AddWithValue("@Phone", customerPhone.Trim());
                        insertCmd.Parameters.AddWithValue("@CarId", carId);
                        insertCmd.Parameters.AddWithValue("@RentDate", rentDate);
                        insertCmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                        insertCmd.Parameters.AddWithValue("@Days", days);
                        insertCmd.Parameters.AddWithValue("@Cost", totalCost);
                        newRentalId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }

                    using (SqlCommand updateCmd = new SqlCommand("UPDATE Cars SET Status = 'Rented' WHERE CarId = @CarId", con))
                    {
                        updateCmd.Parameters.AddWithValue("@CarId", carId);
                        updateCmd.ExecuteNonQuery();
                    }

                    rental = new Rental();
                    rental.RentalId = newRentalId;
                    rental.CustomerName = customerName.Trim();
                    rental.CustomerPhone = customerPhone.Trim();
                    rental.CarId = carId;
                    rental.CarName = carName;
                    rental.RentDate = rentDate;
                    rental.ReturnDate = returnDate;
                    rental.TotalDays = days;
                    rental.TotalCost = totalCost;
                    rental.Status = "Active";

                    return true;
                }
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
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    int carId = 0;
                    string status = "";

                    using (SqlCommand checkCmd = new SqlCommand("SELECT CarId, Status FROM Rentals WHERE RentalId = @RentalId", con))
                    {
                        checkCmd.Parameters.AddWithValue("@RentalId", rentalId);
                        using (SqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                message = "Rental record not found.";
                                return false;
                            }
                            carId = Convert.ToInt32(reader["CarId"]);
                            status = reader["Status"].ToString()!;
                        }
                    }

                    if (status == "Returned")
                    {
                        message = "This rental is already marked as returned.";
                        return false;
                    }

                    using (SqlCommand updateRentCmd = new SqlCommand("UPDATE Rentals SET Status = 'Returned' WHERE RentalId = @RentalId", con))
                    {
                        updateRentCmd.Parameters.AddWithValue("@RentalId", rentalId);
                        updateRentCmd.ExecuteNonQuery();
                    }

                    using (SqlCommand updateCarCmd = new SqlCommand("UPDATE Cars SET Status = 'Available' WHERE CarId = @CarId", con))
                    {
                        updateCarCmd.Parameters.AddWithValue("@CarId", carId);
                        updateCarCmd.ExecuteNonQuery();
                    }

                    message = "Rental #" + rentalId + " returned successfully! Vehicle is now Available.";
                    return true;
                }
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
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    message = "Connected to CarRentalDB successfully!";
                    return true;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}
