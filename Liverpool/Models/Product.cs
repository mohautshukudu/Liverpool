namespace Liverpool.Models
{
    public class Product
    {
        private int id { get; set; }
        private string name { get; set; }
        private string img { get; set; }
        private double price { get; set; }
        private int stock { get; set; }
        private int stars { get; set; }
        private string gender { get; set; }
        private string featured { get; set; }

        public Product(int id, string name, string img, double price, int stock, int stars, string gender, string featured)
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
    }
}
