namespace WebApiAdvance.Entities.Dtos.Products
{
    public class GetProductDto
    {
        public string Name { get; set; }
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
