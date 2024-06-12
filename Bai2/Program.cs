using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    
namespace Bai2
{

    public class ShopLab6
    {
        public int id;
        public int shop_id;
        public string name;
        public string location;

        public ShopLab6(int id, int shop_id, string name, string location)
        {
            this.id = id;
            this.shop_id = shop_id;
            this.name = name;
            this.location = location;
        }
    }

    public class PhoneLab6
    {
        public int id;
        public string name;
        public int shop_id;
        public int price;
        public int des;

        public PhoneLab6(int id, string name, int shop_id, int price, int des)
        {
            this.id = id;
            this.name = name;
            this.shop_id = shop_id;
            this.price = price;
            this.des = des;
        }
    }

    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<ShopLab6> listShop = new List<ShopLab6>();
            listShop.Add(new ShopLab6(1, 1, "Nâu", "HN"));
            listShop.Add(new ShopLab6(2, 2, "Sóc", "HCM"));
            listShop.Add(new ShopLab6(3, 3, "Dê", "DN"));
            listShop.Add(new ShopLab6(4, 4, "Ngựa", "QN"));

            List<PhoneLab6> listPhone = new List<PhoneLab6>();
            listPhone.Add(new PhoneLab6(1, "Phone1", 1, 1000, 1));
            listPhone.Add(new PhoneLab6(2, "Phone2", 2, 2000, 2));
            listPhone.Add(new PhoneLab6(3, "Phone3", 3, 3000, 3));
            listPhone.Add(new PhoneLab6(4, "Phone4", 1, 4000, 4));

           //a) 
            var query = from shop in listShop
                        join phone in listPhone on shop.id equals phone.shop_id
                        select new { ShopName = shop.name, PhoneName = phone.name };

            foreach (var result in query)
            {
                Console.WriteLine($"Shop Name: {result.ShopName}, Phone Name: {result.PhoneName}");
            }
            Console.WriteLine("---------------");

            //b) sử dụng GroupJoin 
            var result2 = listShop.GroupJoin(listPhone, shop => shop.id, phone => phone.shop_id, (shop, phones) => new
            {
                ShopName = shop.name,
                Phones = phones.Select(x => new { PhoneName = x.name, PhonePrice = x.price })
            });
            
            foreach (var item in result2)
            {
                Console.WriteLine($"Shop Name: {item.ShopName}");
                foreach (var phone in item.Phones)
                {
                    Console.WriteLine($"Phone Name: {phone.PhoneName}, Phone Price: {phone.PhonePrice}");
                    Console.WriteLine("--------------");
                }
            }
            
            






        }
    }
}

   