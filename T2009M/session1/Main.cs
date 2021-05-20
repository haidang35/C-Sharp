namespace T2009M.session1
{
    internal class Main
    {
        public static void CreateProduct(string[] args)
        {
            Product prod = new Product(1, "Iphone", 2000, 5, "image1", "SmartPhone");
            prod.GetInfo();
            prod.NotificationQuantity();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.DeleteImageInGallery();
            prod.GetInfo();
          
        }
    }
}