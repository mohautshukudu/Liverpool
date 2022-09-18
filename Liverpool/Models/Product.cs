namespace Liverpool.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
        public int stars { get; set; }
        public string gender { get; set; }
        public bool featured { get; set; }

        public Product(int id, string name, string img, double price, int stock, int stars, string gender, bool featured)
        {
            this.id = id;
            this.name = name;
            this.img = img;
            this.price = price;
            this.stock = stock;
            this.stars = stars;
            this.gender = gender;
            this.featured = featured;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetImg()
        {
            return img;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetStock()
        {
            return stock;
        }

        public int GetStars()
        {
            return stars;
        }

        public string GetGender()
        {
            return gender;
        }

        public bool GetFeatured()
        {
            return featured;
        }

        public string SendPage()
        {
            return "Product" + id;
        }
    }
    
}
