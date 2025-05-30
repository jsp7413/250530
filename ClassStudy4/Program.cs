using System;

namespace space
{
    class ClassStudy
    {
        static void Main()
        {
            Car carl = new Car();

        }

        public class Vehicle
        {
            public string Brand { get; set; }

            public void Honk()
            {
                Console.WriteLine("경적");
            }
        }


        // 자동차 클래스 : 부모(베이스)클래스의 기능을
        public class Car : Vehicle
        {
            public string Model
            {
                get; set;
            }

            public Car{string brand, string model)
                {
                base.Brand = brand;
                this.Model = model;
                }

            public void Accelerate()
            {
                Console.WriteLine("Accelerating");
            }
    }

    public class 산업용로봇
    {
        public string 모델명 {  get; set; } 
        public string 제조사 {  get; set; } 
        public string 전원 {  get; set; } 

        public 산업용로봇
    }
}