using Ex06_EntityFramework.Models;

namespace Ex06_EntityFramework.Interfaces
{


    public interface IWarehouseService
    {
        // Method to fetch all warehouses
        List<Warehouse> getAllWarehouses();
    }


    public interface IArticleService
    {
        // Method to add new article
        Article add(Article article);

        // Method to update the stock quantity of an Article
        Article updateArticleStock(int itemId, int quantity);

        // Method to fetch all Articles that are below given stock
        List<Article> getArticlesBelowStock(int stock);

        // Method to get total sales for each Article
        Dictionary<Article, int> getTotalSalesPerArticle();
    }

    public interface IOrderService
    {
        // Method to add new Order
        Order add(Order order);

        // Method to delete an order
        void deleteOrder(int orderId);

        // Method to fetch all orders made by a specific customer
        List<Order> getAllOrdersByCustomer(int customerId);

        // Method to get average order value
        double getAverageOrderValue();
    }
}
