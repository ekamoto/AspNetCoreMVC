namespace AspNetCoreMVC.Domain 
{
    public class Product {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public Category Category { get; set; }

        public Product()
        {
            
        }
    }


}