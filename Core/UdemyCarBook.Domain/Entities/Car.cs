using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public int BrandID { get; set; } //marka
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; } //kapak fotoğrafı
        public int Km { get; set; }
        public string Transmission { get; set; } //vites
        public byte Seat { get; set; }           //koltuk
        public byte Luggage { get; set; }        //bagaj
        public string Fuel { get; set; }         //yakıt
        public string BigImageUrl { get; set; }  //büyük görselin yolu

        public List<CarFeature> CarFeatures { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }
        public List<CarPricing> CarPricings { get; set; }
        public List<RentACar> RentACars { get; set; }
        public List<RentACarProcess> RentACarProcesses { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Review> Reviews { get; set; }



    }
}
