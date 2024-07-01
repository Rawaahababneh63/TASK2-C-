using System;
using System.CodeDom;
using System.Diagnostics;
using System.Reflection;

namespace task5
{
    public class Cars
    {
        public int Year { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public string Model { get; set; }
        public double PalletNo { get; set; }
        public string Color { get; set; }



        public Cars()
        {

            this.Year = 2020;
            this.Price = "50000$";
            this.Model = "Mustang";
            this.PalletNo = 211114;
            this.Color = "Black";
            this.Type = "Toyota";

        }
        public Cars(string type, string model, string color, string price, double palletNo, int year)
        {
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;

        }

        public string StartEngine()
        {

            return "The engine car is now running.";
        }

        public string StopEngine()
        {

            return "The engine car has been stopped.";
        }
        public string InformationCar()
        {
            return ($"The information Car: Type:{Type},Model: {Model} ,Color:{Color} ,Price :{Price},Year :{Year},Pallet :{PalletNo}");

        }



    }

    public class BMW : Cars
    {
        public BMW(string Type, string Model, string Color, string Price, double PalletNo, int Year)
        : base(Type, Model, Color, Price, PalletNo, Year)
        {


        }
    }

}
