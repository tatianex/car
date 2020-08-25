using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            CarA carA = new CarA();
            // var carC = new CarA();
            // tipo nome = chama o construtor da classe.
            // então é criado o objeto CarC
            carA.ImplementAccelerator();
            carA.ImplementBrake();
            carA.FoldableSeat();

            CarB carB = new CarB();
            carB.ImplementAccelerator();
            carB.ImplementBrake();
            carB.RoofTopExtendable();
            Console.ReadLine();
        }
    }

    public interface IProduct
    {
        void ImplementBrand();
        void ImplementColor();
    }

    public interface ICar
    {
        void ImplementBrake();
        void ImplementAccelerator();
    }

    public class Car : ICar, IProduct
    {
        public DateTime manufacturingDate;
        public string bodyType;
        public float fuelCapacity;
        public void ImplementBrake()
        {
            Console.WriteLine("Inside Base Class Implement Brake");
        }
        public void ImplementAccelerator()
        {
            Console.WriteLine("Inside Base Class Implement Accelerator ");
        }
        public void ImplementBrand()
        {
            Console.WriteLine("Inside Base Class Implement Brand ");
        }
        public void ImplementColor()
        {
            Console.WriteLine("Inside Base Class Implement Color ");
        }
    }

    public class CarA : Car 
    {
        public CarA()
        {
            this.bodyType = string.Empty;
            this.manufacturingDate = DateTime.MinValue;
            this.fuelCapacity = 0.0F;
        }
        public CarA(DateTime manufacturingDate, string bodyType, float fuelCapacity)
        {
            this.bodyType = bodyType;
            this.manufacturingDate = manufacturingDate;
            this.fuelCapacity = fuelCapacity;
            Console.WriteLine("Inside Car A Constructor");
        }
        public void FoldableSeat()
        {
            Console.WriteLine("Inside Car A Foldable Seat");
        }
    }

    public class CarB : Car
    {
        public CarB()
        {
            this.bodyType = string.Empty;
            this.manufacturingDate = DateTime.MinValue;
            this.fuelCapacity = 0.0F;
        }
        public CarB(DateTime manufacturingDate, string bodyType, float
        fuelCapacity)
        {
            this.bodyType = bodyType;
            this.manufacturingDate = manufacturingDate;
            this.fuelCapacity = fuelCapacity;
            Console.WriteLine("Inside Car B Constructor");
        }
        public void RoofTopExtendable()
        {
            Console.WriteLine("Inside Car B Roof Top Extendable");
        }
    }
}
