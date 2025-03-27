using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace DiaasCarApp
{
    class Car
    {
        // Egenskaber

        private string _brand;

        private string _model;

        private int _year;

        private string _color;

        private bool _isEngineOn;

        private string _licensePlate;
        private int _odometer;

        private FuelType _fuelType;

        private DateTime _firstRegistrationDate;

        private GearType _gearType;

        private double _kmPerLiter;

        private List<Trip> _trips;

        private Engine _engine; //den viser sammenhæng mellem DCD og implementering

        private Wheel[] _wheels; //den viser sammenhæng mellem DCD og implementering

        // Konstruktør

        public Car(string brand, string model, int year, string color, string licensePlate, FuelType fuelType, DateTime firstRegistrationDate, GearType gearType, double kmPerLiter)

        {

            _brand = brand;

            _model = model;

            _year = year;

            _color = color;

            _licensePlate = licensePlate;

            _fuelType = fuelType;

            _firstRegistrationDate = firstRegistrationDate;

            _gearType = gearType;

            _kmPerLiter = kmPerLiter;

            _isEngineOn = false;

            _odometer = 0;

            _trips = new List<Trip>();

            _engine = new Engine(150); // Eksempel på hestekræfter

            _wheels = new Wheel[4];

            for (int i = 0; i < 4; i++)

            {

                _wheels[i] = new Wheel(18); // Eksempel på hjulstørrelse

            }

        }


        // Metoder

        public void StartEngine()

        {

            if (_isEngineOn)

            {

                throw new InvalidOperationException("Engine is already running.");

            }

            _isEngineOn = true;

        }


        public void StopEngine()

        {

            if (!_isEngineOn)

            {

                throw new InvalidOperationException("Engine is already stopped.");

            }

            _isEngineOn = false;

        }


        public void Drive(Trip trip)

        {

            if (!_isEngineOn)

            {

                //throw new InvalidOperationException("Engine is not running. Cannot drive."); StartEngine();

            }

            _trips.Add(trip);

            _odometer += (int)trip.Distance;

        }


        public string GetCarDetails()

        {

            return $"Brand: {_brand}\nModel: {_model}\nYear: {_year}\nColor: {_color}\nLicense Plate: {_licensePlate}\n" +

            $"Fuel Type: {_fuelType}\nFirst Registration Date: {_firstRegistrationDate.ToShortDateString()}\n" +

            $"Gear Type: {_gearType}\nKm per Liter: {_kmPerLiter}\nOdometer: {_odometer} km";

        }


        public List<Trip> GetAllTrips()

        {

            return new List<Trip>(_trips); // Returner en kopi for at undgå ekstern manipulation

        }
    }
}
