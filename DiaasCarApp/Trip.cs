using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaasCarApp
{
    class Trip
    {
        // Egenskaber

        public double Distance { get; private set; }

        public DateTime TripDate { get; private set; }

        public DateTime StartTime { get; private set; }

        public DateTime EndTime { get; private set; }


        // Konstruktør

        public Trip(double distance, DateTime tripDate, DateTime startTime, DateTime endTime)

        {

            if (distance < 0)

            {

                throw new ArgumentException("Distance cannot be negative.");

            }

            if (endTime <= startTime)

            {

                throw new ArgumentException("End time must be after start time.");

            }


            Distance = distance;

            TripDate = tripDate;

            StartTime = startTime;

            EndTime = endTime;

        }


        // Metoder

        public TimeSpan CalculateDuration()

        {

            return EndTime - StartTime;

        }


        public double CalculateFuelUsed(double kmPerLiter)

        {

            if (kmPerLiter <= 0)

            {

                throw new DivideByZeroException("kmPerLiter must be greater than zero.");

            }

            return Distance / kmPerLiter;

        }


        public double CalculateTripPrice(double kmPerLiter, double literPrice)

        {

            double fuelUsed = CalculateFuelUsed(kmPerLiter);

            return fuelUsed * literPrice;

        }


        public string GetTripDetails()

        {

            return $"Trip Date: {TripDate.ToShortDateString()}\nDistance: {Distance} km\n" +

            $"Start Time: {StartTime.ToShortTimeString()}\nEnd Time: {EndTime.ToShortTimeString()}\n" +

            $"Duration: {CalculateDuration()}";

        }

    }


    // Understøttende klasser og enumerationer

    public enum FuelType

    {

        Petrol,

        Diesel,

        Electric,

        Hybrid

    }


    public enum GearType

    {

        Manual,

        Automatic

    }


    public class Engine

    {

        public int HorsePower { get; private set; }


        public Engine(int horsePower)

        {

            HorsePower = horsePower;

        }

    }


    public class Wheel

    {

        public int Size { get; private set; }


        public Wheel(int size)

        {

            Size = size;

        }

    }
}
