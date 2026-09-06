using Microsoft.AspNetCore.Mvc;

namespace ThvLesson03.Models
{
    public class ThvProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new ThvProduct()
            {
                productId = "P001",
                productName = "Lenovo",
                quantity = 100,
                price = 1200
            };
            ViewBag.productVB = product;
            ViewData["productVB"] = product;
            return View();
        }
        public IActionResult GetAllProducts()
        {
            // tạo mock data
            List<ThvProduct> products = new List<ThvProduct>
            {
                new ThvProduct { productId = "TVC001", productName = "Áo thun nam cổ tròn", quantity = 150, price = 129000m },
                new ThvProduct { productId = "TVC002", productName = "Quần jean nữ ống suông", quantity = 80, price = 349000m },
                new ThvProduct { productId = "TVC003", productName = "Giày sneaker trắng", quantity = 45, price = 599000m },
                new ThvProduct { productId = "TVC004", productName = "Balo laptop chống nước", quantity = 60, price = 459000m },
                new ThvProduct { productId = "TVC005", productName = "Tai nghe bluetooth không dây", quantity = 200, price = 289000m },
                new ThvProduct { productId = "TVC006", productName = "Đồng hồ đeo tay thể thao", quantity = 35, price = 750000m },
                new ThvProduct { productId = "TVC007", productName = "Ví da nam cao cấp", quantity = 90, price = 199000m },
                new ThvProduct { productId = "TVC008", productName = "Mũ lưỡi trai thời trang", quantity = 120, price = 99000m },
                new ThvProduct { productId = "TVC009", productName = "Bình giữ nhiệt 500ml", quantity = 75, price = 159000m },
                new ThvProduct { productId = "TVC010", productName = "Kính mát nam UV400", quantity = 55, price = 249000m }
            };

            // lưu vào đối tượng viewdata để chuyển lên view
            ViewData["products"] = products;
            return View("Products");
        }

    }
}
