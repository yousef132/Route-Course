namespace Store.Data.Entities
{
    public class Product:BaseEntity<int>
    {
        public string Description {  get; set; }

        public double Pirce { get; set; }   


        public string PictureUrl { get; set; }


        public ProductBrand Brand { get; set; }

        public int BrandId { get; set; }    


        public ProductType Type { get; set; }

        public int TypeId { get; set; } 





    }
}
