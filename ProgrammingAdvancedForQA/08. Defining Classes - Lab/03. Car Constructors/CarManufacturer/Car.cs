﻿using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }

        public string Make 
        {
            get { return make; }
            set { make = value; }
        }
        public string Model 
        {
            get { return model; }
            set { model = value; }
        }
        public int Year 
        {
            get { return year; }
            set { year = value; }
        }
        public double FuelQuantity 
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption 
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            var fuelNeeded = distance * FuelConsumption;

            if (fuelQuantity - fuelNeeded >= 0) fuelQuantity -= fuelNeeded;
            else Console.WriteLine("Not enough fuel to perform this trip!");
        }

        public string WhoAmI()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Year: {Year}");
            sb.AppendLine($"Fuel: {fuelQuantity:F2}");

            return sb.ToString().TrimEnd();
        }
    }
}
