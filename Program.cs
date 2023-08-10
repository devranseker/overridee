using OverrideApp;
using OverrideApp3;

namespace OverrideApp
{
    //vehicle=araç
    class VehicleManager
    {
        //ovirrede olarak kullanmak istediğimiz kodu virtual olarak tanımlıyoruz.
        public virtual void vehicleMove()
        {
            Console.WriteLine("Taşıt hareket halinde");
        }
    }
}

namespace OverrideApp3
{
    class CarManager : VehicleManager
    {
       
          public override void vehicleMove()
        {
            Console.WriteLine("Araba hareket halinde");
        }
    }
}


namespace OverrideApp
{
    class BicycleManager : VehicleManager
    {

        public override void vehicleMove()
        {
            Console.WriteLine("Bisiklet hareket halinde");
        }
    }

    namespace OverrideApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                VehicleManager vehicle = new CarManager();
                vehicle.vehicleMove();
                Console.Read();
            }
        }
    }
}