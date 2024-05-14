void PrintOrderDetails(string sellerName, int orderId, 
    string productName, int quantity = 1, int quantityLeft = 1)
{
    Console.WriteLine("Seller: " + sellerName);
    Console.WriteLine("Order ID: " + orderId);
    Console.WriteLine("Product: " + productName);
    Console.WriteLine("Quantity: " + quantity);
    Console.WriteLine("Quantity Left: " + quantityLeft);
}




PrintOrderDetails("Apple", 1, "Orange", 1, 1);


PrintOrderDetails(sellerName: "Apple", orderId: 1, productName: "Apple",
    quantity: 2, quantityLeft: 5);


PrintOrderDetails(sellerName: "Apple", orderId: 1, productName: "Apple", 
    quantityLeft: 10);

PrintOrderDetails(orderId: 1, productName: "Apple", sellerName: "Apple");