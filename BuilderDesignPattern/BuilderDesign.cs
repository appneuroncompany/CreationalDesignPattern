using Newtonsoft.Json;
using System;

namespace BuilderDesignPattern
{

    /// <summary>
    /// Builder Design Pattern adı üzerinde bir inşaatçı görev üstlenen yaklaşım sergilemektedir. 
    /// Projemiz inşa süresindeyken oluşturacağımız bazı nesnelerin üretimleri oldukça maliyetli olabilir, zamanla bu nesnelerin yapısı değişebilir yahut güncellenebilir. 
    /// İşte bu tarz inşa durumlarında Builder D.P. ile ilgili nesneler genişletilebilir bir hale getirilmekte ve en önemlisi kod karmaşalığı minimize edilmektedir.
    /// Bu patterni classların parametrelerinin birçoğu isteğe bağlı ise, ve birçoğu aynı türde ise önerilmektedir.
    /// </summary>
    public class BuilderDesign
    {

        public static void TestBuilderDesignPattern()
        {
            Car SportCar = CarBuilder.SportCharBulder("2015", 6262, "Ferrari-F12").Build();
            Car JeepCar = CarBuilder.JeepCharBulder("2019", 3500, "Jeep Wrangler").SetAirbackCount(6).SethasNavigator(true).SethasRadio(false).Build();
            string sportCar = JsonConvert.SerializeObject(SportCar);
            string jeepCar = JsonConvert.SerializeObject(JeepCar);

            Console.WriteLine(jeepCar);
            Console.WriteLine("/////////////////////////////////////////////");
            Console.WriteLine(sportCar);

        }

    }
}
