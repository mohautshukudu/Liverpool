namespace Liverpool.Models
{
    public class productsCatalogue
    {
        string[] featuredProducts = { "2;Womens' Shirt;dj7778a_10-copy.jpg;399;0;4;Men;1",
            "3;Mens' Shorts;a15612_1.jpg;500;0;5;Men;1",
            "4;Womens' Trousers;a21un13_1252_copy.jpg;500;0;0;Women;1",
            "5;Mohamed Salah Collectable;a13911_01_copy_1.jpg;800;0;5;All;1",
            "6;LFC Rome 1984 Medal;a21co04_1_copy.jpg;800;0;4;All;1",
            "9;LFC Signed 22-23 Virgil Van Dijk & Matip Framed Shirt;a16341.jpg;4000;0;4;All;1",
            "10;LFC Signed Virgil Framed Boot;a16359.jpg;3500;0;4;All;1",};

        string[] allProduts = { "1;Mens' Shirt;dm1835-377-1183-crop.jpg;399;0;4;Men;0",
            "2;Womens' Shirt;dj7778a_10-copy.jpg;399;0;4;Men;1",
            "3;Mens' Shorts;a15612_1.jpg;500;0;5;Men;1",
            "4;Womens' Trousers;a21un13_1252_copy.jpg;500;0;0;Women;1",
            "5;Mohamed Salah Collectable;a13911_01_copy_1.jpg;800;0;5;All;1",
            "6;LFC Rome 1984 Medal;a21co04_1_copy.jpg;800;0;4;All;1",
            "7;LFC Signed Squad 21-22 Boxed Away Shirt;a16236.jpg;3000;0;5;All;0",
            "8;LFC Signed 22-23 Thiago Boxed Shirt;a16320.jpg;3000;0;5;All;0",
            "9;LFC Signed 22-23 Virgil Van Dijk & Matip Framed Shirt;a16341.jpg;4000;0;4;All;1",
            "10;LFC Signed Virgil Framed Boot;a16359.jpg;3500;0;4;All;1"};

        Product product1 = new Product(1, "Mens' Shirt", "~/resourcesdm1835-377-1183-crop.jpg", 399, 0, 4, "Men", false);
        Product product2 = new Product(2, "Womens' Shirt", "~/resourcesdj7778a_10-copy.jpg", 399, 0, 4, "Men", true);
        Product product3 = new Product(3, "Mens' Shorts", "~/resourcesa15612_1.jpg", 500, 0, 5, "Men", true);
        Product product4 = new Product(4, "Womens' Trousers", "~/resourcesa21un13_1252_copy.jpg", 500, 0, 0, "Women", true);
        Product product5 = new Product(5, "Mohamed Salah Collectable", "~/resourcesa13911_01_copy_1.jpg", 800, 0, 5, "All", true);
        Product product6 = new Product(6, "LFC Rome 1984 Medal", "~/resourcesa21co04_1_copy.jpg", 800, 0,4, "All", true);
        Product product7 = new Product(7, "LFC Signed Squad 21-22 Boxed Away Shirt", "~/resourcesa16236.jpg", 3000, 0, 5, "All", false);
        Product product8 = new Product(8, "LFC Signed 22-23 Thiago Boxed Shirt", "~/resourcesa16320.jpg", 3000, 0, 5, "All", false);
        Product product9 = new Product(9, "LFC Signed 22-23 Virgil Van Dijk & Matip Framed Shirt", "~/resourcesa16341.jpg", 4000, 0, 4, "All", true);
        Product product10 = new Product(10, "LFC Signed Virgil Framed Boot", "~/resourcesa16359.jpg", 3500, 0, 4, "All", true);

    /*This is a list of all memorabilias for site*/
    List<Product> products = new List<Product>
    {
    new Product (1, "Mens' Shirt", "./resources/dm1835-377-1183-crop.jpg", 399, 0, 4, "Men", false),
    new Product (2, "Womens' Shirt", "./resources/dj7778a_10-copy.jpg", 399, 0, 4, "Men", false),
    new Product (3, "Mens' Shorts", "./resources/a15612_1.jpg", 500, 0, 5, "Men", false),
    new Product (4, "Womens' Trousers", "./resources/a21un13_1252_copy.jpg", 500, 0, 0, "Women", false),
    new Product (5, "Mohamed Salah Collectable", "./resources/a13911_01_copy_1.jpg", 800, 0, 5, "All", true),
    new Product (6, "LFC Rome 1984 Medal", "./resources/a21co04_1_copy.jpg", 800, 0,4, "All", true),
    new Product (7, "LFC Signed Squad 21-22 Boxed Away Shirt", "./resources/a16236.jpg", 3000, 0, 5, "All", true),
    new Product (8, "LFC Signed 22-23 Thiago Boxed Shirt", "./resources/a16320.jpg", 3000, 0, 5, "All", true),
    new Product (9, "LFC Signed 22-23 Virgil Van Dijk & Matip Framed Shirt", "./resources/a16341.jpg", 4000, 0, 4, "All", true),
    new Product (10, "LFC Signed Virgil Framed Boot", "./resources/a16359.jpg", 3500, 0, 4, "All", true)
    };
    }
}
