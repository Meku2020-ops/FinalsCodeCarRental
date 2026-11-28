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
        public int Seaters { get; set; } = 5;
        public decimal DailyRate { get; set; }
        public string Status { get; set; } = "Available";

        public string DisplayName => Brand + " " + Model + " (" + Category + ", " + Seaters + "-Seater) - ₱" + DailyRate.ToString("F2") + "/day [" + Status + "]";
    }

    public class Rental
    {
        public int RentalId { get; set; }
        public string CustomerName { get; set; } = "";
        public string CustomerPhone { get; set; } = "";
        public string CustomerEmail { get; set; } = "";
        public string IdType { get; set; } = "";
        public string CustomerAddress { get; set; } = "";
        public int CarId { get; set; }
        public string CarName { get; set; } = "";
        public DateTime RentDate { get; set; } = DateTime.Now;
        public DateTime ReturnDate { get; set; } = DateTime.Now.AddDays(3);
        public int TotalDays { get; set; } = 3;
        public decimal TotalCost { get; set; }
        public string PickupLocation { get; set; } = "";
        public string PaymentMethod { get; set; } = "";
        public string SpecialRequest { get; set; } = "";
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
            "Server=DESKTOP-FQR1QOV\\SQLEXPRESS;Database=CarRentalDB;Trusted_Connection=True;TrustServerCertificate=True;Connection Timeout=5;";

        public static bool EnsureDatabaseTables(out string message)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    string createCarsSql = @"
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
END;";

                    string migrateCarsSql = @"
IF COL_LENGTH('Cars', 'Seaters') IS NULL
BEGIN
    ALTER TABLE Cars ADD Seaters INT NOT NULL DEFAULT 5;
    EXEC(N'UPDATE Cars SET Seaters = 4 WHERE PlateNumber = ''MST-4040'';');
END;";

                    string createRentalsSql = @"
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
END;";

                    string migrateRentalsSql = @"
IF COL_LENGTH('Rentals', 'CustomerEmail') IS NULL ALTER TABLE Rentals ADD CustomerEmail NVARCHAR(100) NULL;
IF COL_LENGTH('Rentals', 'IdType') IS NULL ALTER TABLE Rentals ADD IdType NVARCHAR(50) NULL;
IF COL_LENGTH('Rentals', 'CustomerAddress') IS NULL ALTER TABLE Rentals ADD CustomerAddress NVARCHAR(200) NULL;
IF COL_LENGTH('Rentals', 'PickupLocation') IS NULL ALTER TABLE Rentals ADD PickupLocation NVARCHAR(100) NULL;
IF COL_LENGTH('Rentals', 'PaymentMethod') IS NULL ALTER TABLE Rentals ADD PaymentMethod NVARCHAR(50) NULL;
IF COL_LENGTH('Rentals', 'SpecialRequest') IS NULL ALTER TABLE Rentals ADD SpecialRequest NVARCHAR(300) NULL;";

                    using (SqlCommand cmd = new SqlCommand(createCarsSql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand(migrateCarsSql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand(createRentalsSql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand(migrateRentalsSql, con))
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
            return ReadCars("SELECT CarId, Brand, Model, Category, PlateNumber, Seaters, DailyRate, Status FROM Cars ORDER BY CarId ASC");
        }

        public static List<Car> GetAvailableCars()
        {
            return ReadCars("SELECT CarId, Brand, Model, Category, PlateNumber, Seaters, DailyRate, Status FROM Cars WHERE Status = 'Available' ORDER BY Brand ASC");
        }

        // Returns ALL cars (available + rented) so users can make advance reservations on non-conflicting dates
        public static List<Car> GetAllCarsForBooking()
        {
            return ReadCars("SELECT CarId, Brand, Model, Category, PlateNumber, Seaters, DailyRate, Status FROM Cars ORDER BY Brand ASC");
        }

        // Checks if a car already has an active/advance booking that overlaps with the requested dates.
        // Returns true if there IS a conflict (car is NOT free for those dates).
        public static bool HasDateConflict(SqlConnection con, int carId, DateTime pickupDate, DateTime returnDate, int excludeRentalId = 0)
        {
            string sql = @"
SELECT COUNT(*) FROM Rentals
WHERE CarId = @CarId
  AND Status IN ('Active', 'Reserved')
  AND RentalId <> @ExcludeId
  AND RentDate < @ReturnDate
  AND ReturnDate > @PickupDate";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@CarId", carId);
                cmd.Parameters.AddWithValue("@ExcludeId", excludeRentalId);
                cmd.Parameters.AddWithValue("@PickupDate", pickupDate.Date);
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate.Date);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private static List<Car> ReadCars(string query)
        {
            var list = new List<Car>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
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
                            car.Seaters = Convert.ToInt32(reader["Seaters"]);
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
SELECT r.RentalId, r.CustomerName, r.CustomerPhone,
       ISNULL(r.CustomerEmail, '') AS CustomerEmail,
       ISNULL(r.IdType, '') AS IdType,
       ISNULL(r.CustomerAddress, '') AS CustomerAddress,
       r.CarId,
       c.Brand + ' ' + c.Model AS CarName,
       r.RentDate, r.ReturnDate, r.TotalDays, r.TotalCost,
       ISNULL(r.PickupLocation, '') AS PickupLocation,
       ISNULL(r.PaymentMethod, '') AS PaymentMethod,
       ISNULL(r.SpecialRequest, '') AS SpecialRequest,
       r.Status
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
                            rental.CustomerEmail = reader["CustomerEmail"].ToString()!;
                            rental.IdType = reader["IdType"].ToString()!;
                            rental.CustomerAddress = reader["CustomerAddress"].ToString()!;
                            rental.CarId = Convert.ToInt32(reader["CarId"]);
                            rental.CarName = reader["CarName"].ToString()!;
                            rental.RentDate = Convert.ToDateTime(reader["RentDate"]);
                            rental.ReturnDate = Convert.ToDateTime(reader["ReturnDate"]);
                            rental.TotalDays = Convert.ToInt32(reader["TotalDays"]);
                            rental.TotalCost = Convert.ToDecimal(reader["TotalCost"]);
                            rental.PickupLocation = reader["PickupLocation"].ToString()!;
                            rental.PaymentMethod = reader["PaymentMethod"].ToString()!;
                            rental.SpecialRequest = reader["SpecialRequest"].ToString()!;
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
            return AddCar(brand, model, category, plate, 5, rate, out error);
        }

        public static bool AddCar(string brand, string model, string category, string plate, int seaters, decimal rate, out string error)
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
            if (seaters < 1 || seaters > 50)
            {
                error = "Seaters must be between 1 and 50.";
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
                    string query = "INSERT INTO Cars (Brand, Model, Category, PlateNumber, Seaters, DailyRate, Status) VALUES (@Brand, @Model, @Category, @Plate, @Seaters, @Rate, 'Available')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Brand", brand.Trim());
                        cmd.Parameters.AddWithValue("@Model", model.Trim());
                        cmd.Parameters.AddWithValue("@Category", category.Trim());
                        cmd.Parameters.AddWithValue("@Plate", plate.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Seaters", seaters);
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
            DateTime pickupDate = DateTime.Today;
            return BookCar(customerName, customerPhone, carId, pickupDate, pickupDate.AddDays(days), out rental, out error);
        }

        public static bool BookCar(string customerName, string customerPhone, int carId, DateTime pickupDate, DateTime returnDate, out Rental? rental, out string error)
        {
            return BookCar(customerName, customerPhone, "", "", "", carId, pickupDate, returnDate, "Main Office (Showroom)", "Cash", "", out rental, out error);
        }

        public static bool BookCar(
            string customerName,
            string customerPhone,
            string customerEmail,
            string idType,
            string customerAddress,
            int carId,
            DateTime pickupDate,
            DateTime returnDate,
            string pickupLocation,
            string paymentMethod,
            string specialRequest,
            out Rental? rental,
            out string error)
        {
            rental = null;
            error = "";

            DateTime rentDate = pickupDate.Date;
            DateTime dueDate = returnDate.Date;
            int days = (dueDate - rentDate).Days;

            if (string.IsNullOrWhiteSpace(customerName))
            {
                error = "Customer name is required.";
                return false;
            }
            if (rentDate < DateTime.Today)
            {
                error = "Pick-up date cannot be in the past.";
                return false;
            }
            if (days < 1)
            {
                error = "Return date must be at least 1 day after the pick-up date.";
                return false;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    decimal dailyRate = 0;
                    string carName = "";

                    using (SqlCommand selectCmd = new SqlCommand("SELECT Brand + ' ' + Model AS CarName, DailyRate FROM Cars WHERE CarId = @CarId", con))
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
                        }
                    }

                    // Check for date conflicts — allows advance booking if dates don't overlap
                    if (HasDateConflict(con, carId, rentDate, dueDate))
                    {
                        error = "'" + carName + "' is already booked or rented for the selected dates.\n\nPlease choose different dates or select another vehicle.";
                        return false;
                    }

                    decimal totalCost = dailyRate * days;

                    // If the pickup date is today, reserve as 'Active'; if it's future, mark as 'Reserved'
                    string reservationStatus = (rentDate == DateTime.Today) ? "Active" : "Reserved";

                    string insertSql = @"
INSERT INTO Rentals (CustomerName, CustomerPhone, CustomerEmail, IdType, CustomerAddress, CarId, RentDate, ReturnDate, TotalDays, TotalCost, PickupLocation, PaymentMethod, SpecialRequest, Status)
VALUES (@Name, @Phone, @Email, @IdType, @Address, @CarId, @RentDate, @ReturnDate, @Days, @Cost, @PickupLocation, @PaymentMethod, @SpecialRequest, @Status);
SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    int newRentalId;
                    using (SqlCommand insertCmd = new SqlCommand(insertSql, con))
                    {
                        insertCmd.Parameters.AddWithValue("@Name", customerName.Trim());
                        insertCmd.Parameters.AddWithValue("@Phone", customerPhone.Trim());
                        insertCmd.Parameters.AddWithValue("@Email", customerEmail.Trim());
                        insertCmd.Parameters.AddWithValue("@IdType", idType.Trim());
                        insertCmd.Parameters.AddWithValue("@Address", customerAddress.Trim());
                        insertCmd.Parameters.AddWithValue("@CarId", carId);
                        insertCmd.Parameters.AddWithValue("@RentDate", rentDate);
                        insertCmd.Parameters.AddWithValue("@ReturnDate", dueDate);
                        insertCmd.Parameters.AddWithValue("@Days", days);
                        insertCmd.Parameters.AddWithValue("@Cost", totalCost);
                        insertCmd.Parameters.AddWithValue("@PickupLocation", pickupLocation.Trim());
                        insertCmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod.Trim());
                        insertCmd.Parameters.AddWithValue("@SpecialRequest", specialRequest.Trim());
                        insertCmd.Parameters.AddWithValue("@Status", reservationStatus);
                        newRentalId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }

                    // Only mark car as 'Rented' in Cars table if this is an immediate booking (today)
                    // For advance/future reservations, the car's Cars.Status stays as-is
                    if (reservationStatus == "Active")
                    {
                        using (SqlCommand updateCmd = new SqlCommand("UPDATE Cars SET Status = 'Rented' WHERE CarId = @CarId", con))
                        {
                            updateCmd.Parameters.AddWithValue("@CarId", carId);
                            updateCmd.ExecuteNonQuery();
                        }
                    }

                    rental = new Rental();
                    rental.RentalId = newRentalId;
                    rental.CustomerName = customerName.Trim();
                    rental.CustomerPhone = customerPhone.Trim();
                    rental.CustomerEmail = customerEmail.Trim();
                    rental.IdType = idType.Trim();
                    rental.CustomerAddress = customerAddress.Trim();
                    rental.CarId = carId;
                    rental.CarName = carName;
                    rental.RentDate = rentDate;
                    rental.ReturnDate = dueDate;
                    rental.TotalDays = days;
                    rental.TotalCost = totalCost;
                    rental.PickupLocation = pickupLocation.Trim();
                    rental.PaymentMethod = paymentMethod.Trim();
                    rental.SpecialRequest = specialRequest.Trim();
                    rental.Status = reservationStatus;

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

                    if (status != "Active")
                    {
                        message = "Only Active rentals can be checked in. Current status: " + status +
                                  "\n\nTo give a returned car to the next Reserved client, use 'Assign to Next Reserved'.";
                        return false;
                    }

                    // Mark this rental as returned
                    using (SqlCommand updateRentCmd = new SqlCommand("UPDATE Rentals SET Status = 'Returned' WHERE RentalId = @RentalId", con))
                    {
                        updateRentCmd.Parameters.AddWithValue("@RentalId", rentalId);
                        updateRentCmd.ExecuteNonQuery();
                    }

                    // Check if there's a future 'Reserved' booking for the same car that starts today or later
                    bool hasFutureReservation = false;
                    using (SqlCommand futureCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Rentals WHERE CarId = @CarId AND Status = 'Reserved' AND RentDate >= @Today", con))
                    {
                        futureCmd.Parameters.AddWithValue("@CarId", carId);
                        futureCmd.Parameters.AddWithValue("@Today", DateTime.Today);
                        hasFutureReservation = Convert.ToInt32(futureCmd.ExecuteScalar()) > 0;
                    }

                    // If the returned car's pickup date is today, activate the next reserved booking
                    int nextReservedId = 0;
                    using (SqlCommand nextCmd = new SqlCommand(
                        "SELECT TOP 1 RentalId FROM Rentals WHERE CarId = @CarId AND Status = 'Reserved' AND RentDate = @Today ORDER BY RentalId ASC", con))
                    {
                        nextCmd.Parameters.AddWithValue("@CarId", carId);
                        nextCmd.Parameters.AddWithValue("@Today", DateTime.Today);
                        object? result = nextCmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            nextReservedId = Convert.ToInt32(result);
                    }

                    if (nextReservedId > 0)
                    {
                        // Activate the next booking that starts today
                        using (SqlCommand activateCmd = new SqlCommand(
                            "UPDATE Rentals SET Status = 'Active' WHERE RentalId = @Id", con))
                        {
                            activateCmd.Parameters.AddWithValue("@Id", nextReservedId);
                            activateCmd.ExecuteNonQuery();
                        }
                        // Keep car as Rented
                        using (SqlCommand updateCarCmd = new SqlCommand("UPDATE Cars SET Status = 'Rented' WHERE CarId = @CarId", con))
                        {
                            updateCarCmd.Parameters.AddWithValue("@CarId", carId);
                            updateCarCmd.ExecuteNonQuery();
                        }
                        message = "Rental #" + rentalId + " returned. Next reservation #" + nextReservedId + " has been automatically activated!";
                    }
                    else
                    {
                        // No booking today — set car to Available
                        using (SqlCommand updateCarCmd = new SqlCommand("UPDATE Cars SET Status = 'Available' WHERE CarId = @CarId", con))
                        {
                            updateCarCmd.Parameters.AddWithValue("@CarId", carId);
                            updateCarCmd.ExecuteNonQuery();
                        }
                        if (hasFutureReservation)
                            message = "Rental #" + rentalId + " returned. Vehicle is now Available (advance reservation pending for a future date).";
                        else
                            message = "Rental #" + rentalId + " returned successfully! Vehicle is now Available.";
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        // Manually activate a 'Reserved' rental — staff confirms car is ready for pickup
        public static bool ActivateReservation(int rentalId, out string message)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    // Get the rental and check its status
                    string status = "";
                    int carId = 0;
                    using (SqlCommand getCmd = new SqlCommand(
                        "SELECT Status, CarId FROM Rentals WHERE RentalId = @RentalId", con))
                    {
                        getCmd.Parameters.AddWithValue("@RentalId", rentalId);
                        using (SqlDataReader reader = getCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                message = "Rental #" + rentalId + " not found.";
                                return false;
                            }
                            status = reader["Status"].ToString()!;
                            carId = Convert.ToInt32(reader["CarId"]);
                        }
                    }

                    // Only allow activating a Reserved rental
                    if (status != "Reserved")
                    {
                        if (status == "Active")
                            message = "This booking is already Active.";
                        else if (status == "Returned")
                            message = "This rental has already been returned and cannot be activated.";
                        else
                            message = "Only Reserved bookings can be activated. Current status: " + status;
                        return false;
                    }

                    // Check if the car is currently free (no Active rental on it)
                    bool carBusy = false;
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Rentals WHERE CarId = @CarId AND Status = 'Active'", con))
                    {
                        checkCmd.Parameters.AddWithValue("@CarId", carId);
                        carBusy = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                    }

                    if (carBusy)
                    {
                        message = "The vehicle still has an active rental in progress. Please process the current return first before activating this reservation.";
                        return false;
                    }

                    // Activate the reservation
                    using (SqlCommand activateCmd = new SqlCommand(
                        "UPDATE Rentals SET Status = 'Active' WHERE RentalId = @RentalId", con))
                    {
                        activateCmd.Parameters.AddWithValue("@RentalId", rentalId);
                        activateCmd.ExecuteNonQuery();
                    }

                    // Mark the car as Rented
                    using (SqlCommand updateCarCmd = new SqlCommand(
                        "UPDATE Cars SET Status = 'Rented' WHERE CarId = @CarId", con))
                    {
                        updateCarCmd.Parameters.AddWithValue("@CarId", carId);
                        updateCarCmd.ExecuteNonQuery();
                    }

                    message = "Reservation #" + rentalId + " is now ACTIVE! Vehicle has been marked as Rented and is ready for pickup.";
                    return true;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        // After a check-in, assign the now-available car to the next Reserved booking for that vehicle
        public static bool AssignReturnedCarToNextReservation(int returnedRentalId, out string message)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    int carId = 0;
                    string status = "";
                    string carName = "";

                    using (SqlCommand getCmd = new SqlCommand(@"
SELECT r.CarId, r.Status, c.Brand + ' ' + c.Model AS CarName
FROM Rentals r
INNER JOIN Cars c ON r.CarId = c.CarId
WHERE r.RentalId = @RentalId", con))
                    {
                        getCmd.Parameters.AddWithValue("@RentalId", returnedRentalId);
                        using (SqlDataReader reader = getCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                message = "Rental #" + returnedRentalId + " not found.";
                                return false;
                            }
                            carId = Convert.ToInt32(reader["CarId"]);
                            status = reader["Status"].ToString()!;
                            carName = reader["CarName"].ToString()!;
                        }
                    }

                    if (status != "Returned")
                    {
                        if (status == "Active")
                            message = "This rental is still Active. Process the return / check-in first so the car becomes Available.";
                        else if (status == "Reserved")
                            message = "This row is already a Reserved booking. Use this button after selecting a Returned rental, or activate this reservation directly.";
                        else
                            message = "Select a Returned rental so the Available car can be given to the next Reserved client. Current status: " + status;
                        return false;
                    }

                    bool carBusy = false;
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Rentals WHERE CarId = @CarId AND Status = 'Active'", con))
                    {
                        checkCmd.Parameters.AddWithValue("@CarId", carId);
                        carBusy = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                    }

                    if (carBusy)
                    {
                        message = "'" + carName + "' still has an Active rental. Process that return first.";
                        return false;
                    }

                    int nextReservedId = 0;
                    string nextCustomer = "";
                    DateTime nextPickup = DateTime.Today;

                    using (SqlCommand nextCmd = new SqlCommand(@"
SELECT TOP 1 RentalId, CustomerName, RentDate
FROM Rentals
WHERE CarId = @CarId AND Status = 'Reserved' AND RentDate >= @Today
ORDER BY RentDate ASC, RentalId ASC", con))
                    {
                        nextCmd.Parameters.AddWithValue("@CarId", carId);
                        nextCmd.Parameters.AddWithValue("@Today", DateTime.Today);
                        using (SqlDataReader reader = nextCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nextReservedId = Convert.ToInt32(reader["RentalId"]);
                                nextCustomer = reader["CustomerName"].ToString()!;
                                nextPickup = Convert.ToDateTime(reader["RentDate"]);
                            }
                        }
                    }

                    if (nextReservedId == 0)
                    {
                        using (SqlCommand availCmd = new SqlCommand(
                            "UPDATE Cars SET Status = 'Available' WHERE CarId = @CarId", con))
                        {
                            availCmd.Parameters.AddWithValue("@CarId", carId);
                            availCmd.ExecuteNonQuery();
                        }
                        message = "'" + carName + "' is Available. There is no upcoming Reserved client waiting for this vehicle.";
                        return false;
                    }

                    using (SqlCommand activateCmd = new SqlCommand(
                        "UPDATE Rentals SET Status = 'Active' WHERE RentalId = @Id", con))
                    {
                        activateCmd.Parameters.AddWithValue("@Id", nextReservedId);
                        activateCmd.ExecuteNonQuery();
                    }

                    using (SqlCommand updateCarCmd = new SqlCommand(
                        "UPDATE Cars SET Status = 'Rented' WHERE CarId = @CarId", con))
                    {
                        updateCarCmd.Parameters.AddWithValue("@CarId", carId);
                        updateCarCmd.ExecuteNonQuery();
                    }

                    message = "'" + carName + "' from returned rental #" + returnedRentalId +
                              " is now assigned to Reserved client " + nextCustomer +
                              " (reservation #" + nextReservedId + ", pickup " + nextPickup.ToString("yyyy-MM-dd") +
                              "). Booking is now Active and the vehicle is Rented.";
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
