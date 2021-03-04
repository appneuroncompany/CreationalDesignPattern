using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class CarBuilder
    {
        private  string model;

        private  string style;

        private  int engineCapacity;

        private  string name;


        private  int airbackCount;

        private  bool isItOpenTop;

        private  bool hasRadio;

        private  bool hasNavigator;


        public static CarBuilder SportCharBulder(string model, int engineCapacity, string name)
        {
            CarBuilder carBuilder = new CarBuilder();
            carBuilder.style = "Sport";
            carBuilder.model = model;
            carBuilder.engineCapacity = engineCapacity;
            carBuilder.name = name;

            return carBuilder;

        }

        public static CarBuilder JeepCharBulder(string model, int engineCapacity, string name)
        {
            CarBuilder carBuilder = new CarBuilder();
            carBuilder.style = "Jeep";
            carBuilder.model = model;
            carBuilder.engineCapacity = engineCapacity;
            carBuilder.name = name;

            return carBuilder;
        }

        public Car Build()
        {
            Car car = new Car();
            car.Model = this.model;
            car.Style = this.style;
            car.EngineCapacity = this.engineCapacity;
            car.Name = this.name;
            car.AirbackCount = this.airbackCount;
            car.IsItOpenTop = this.isItOpenTop;
            car.HasRadio = this.hasRadio;
            car.HasNavigator = this.hasNavigator;
            return car;
    }



        public CarBuilder SetAirbackCount(int airbackCount)
        {
            this.airbackCount = airbackCount;
            return this;
        }

        public CarBuilder SetOpenTop(bool isItOpenTop)
        {
            this.isItOpenTop = isItOpenTop;
            return this;
        }
        public CarBuilder SethasRadio(bool hasRadio)
        {
            this.hasRadio = hasRadio;
            return this;
        }
        public CarBuilder SethasNavigator(bool hasNavigator)
        {
            this.hasNavigator = hasNavigator;
            return this;
        }

    }
}
