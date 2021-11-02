namespace Kiosk_DataBase.Models
{
    public class Product
    {
        public int DataBaseId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string Type { get; set; }
        public string Producer { get; set; }
        public string Author { get; set; }
    }
}