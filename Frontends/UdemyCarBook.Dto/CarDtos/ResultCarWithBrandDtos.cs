using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CarDtos
{
    public class ResultCarWithBrandDtos
    {
        public int CarID { get; set; }
        public int BrandID { get; set; } //marka
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; } //kapak fotoğrafı
        public int Km { get; set; }
        public string Transmission { get; set; } //vites
        public byte Seat { get; set; }           //koltuk
        public byte Luggage { get; set; }        //bagaj
        public string Fuel { get; set; }         //yakıt
        public string BigImageUrl { get; set; }  //büyük görselin yolu
    }
}
