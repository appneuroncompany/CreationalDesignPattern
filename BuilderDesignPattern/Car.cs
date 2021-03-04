using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    [Serializable]
    public class Car
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int airbackCount;

        public int AirbackCount
        {
            get { return airbackCount; }
            set { airbackCount = value; }
        }

        private string style;

        public string Style
        {
            get { return style; }
            set { style = value; }
        }

        private int engineCapacity;

        public int EngineCapacity
        {
            get { return engineCapacity; }
            set { engineCapacity = value; }
        }
        private bool isItOpenTop;

        public bool IsItOpenTop
        {
            get { return isItOpenTop; }
            set { isItOpenTop = value; }
        }

        private bool hasRadio;

        public bool HasRadio
        {
            get { return hasRadio; }
            set { hasRadio = value; }
        }

        private bool hasNavigator;

        public bool HasNavigator
        {
            get { return hasNavigator; }
            set { hasNavigator = value; }
        }

        public Car()
        {

        }


    }
}
