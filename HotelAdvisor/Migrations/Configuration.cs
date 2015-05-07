namespace HotelAdvisor.Migrations
{
    using HotelAdvisor.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HotelAdvisor.Models.HotelAdvisorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HotelAdvisor.Models.HotelAdvisorContext context)
        {
            // get image byte array
            string parkImage = "\\Content\\HotelImages\\hotel-park-novi-sad.jpg";
            string centarImage = "\\Content\\HotelImages\\hotel-centar-izgled-spolja.jpg";
            string putnikImage = "\\Content\\HotelImages\\hotel-putnik_508f9bac6af3f.jpg";
            string panoramaImage = "\\Content\\HotelImages\\hotel-panorama_508f98d5d1faf.jpg";
            string fontanaImage = "\\Content\\HotelImages\\69_1233757047_noviiiiiii.jpg";
            string dashImage = "\\Content\\HotelImages\\6.jpg";


            var hotels = new List<Hotel>
            {
                new Hotel{Name = "Hotel Park", Description = "Hotel Park se nalazi u Novom Sadu, na ivici velikog parka u mirnom okru�enju",Address = "Novosadskog sajma", HouseNumber = 35, City="Novi Sad",  IsActive = true, Image = parkImage},
                new Hotel{Name = "Hotel Centar", Description = "Hotel Centar nalazi se blizu Srpskog narodnog pozori�ta u centru Novog Sada. Nudi svetle i prostrane sme�tajne jedinice.",Address = "Uspenska", HouseNumber = 1, City="Novi Sad",  IsActive = true, Image = centarImage},
                new Hotel{Name = "Hotel Putnik", Description = "Hotel Park se nalazi u Novom Sadu, na ivici velikog parka u mirnom okru�enju",Address = "Ognjanovica", HouseNumber = 24, City="Novi Sad",  IsActive = true, Image = putnikImage},
                new Hotel{Name = "Hotel Panorama", Description = "Hotel Panorama nalazi se u centru Novog Sada i do njega se lako sti�e, bez obzira odakle dolazite.",Address = "Futoska", HouseNumber = 1, City="Novi Sad",  IsActive = true, Image = panoramaImage},
                new Hotel{Name = "Fontana", Description = "Ovaj hotel se nalazi na svega 100 metara od pe�a�ke zone u starom gradskom jezgru Novog Sada i nudi besplatan be�i�ni internet i besplatan podzemni parking.",Address = "Nikole Pasica", HouseNumber = 27, City="Novi Sad",  IsActive = true, Image = fontanaImage},
                new Hotel{Name = "Dash Star", Description = "Hotel Dash Star se nalazi u blizini centra grada i Novosadskog sajma. U ponudi su elegantne klimatizovane sobe sa besplatnim be�i�nim internetom",Address = "Vrsacka", HouseNumber = 11, City="Novi Sad",  IsActive = false, Image = dashImage}
            };

            hotels.ForEach(h => context.Hotels.Add(h));
            context.SaveChanges();
        }
    }
}
