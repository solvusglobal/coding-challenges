using System;
using System.Collections.Generic;

class OrderProcessor {
    // The following method contains several responsibilities: creating the order, calculating price, applying discount, and printing a receipt.
    public void ProcessOrder(string customerName, List<string> items, bool applyDiscount) {
        double totalPrice = 0;

        // Calculate price
        foreach (string item in items) {
            if (item == "ItemA")
                totalPrice += 100;
            else if (item == "ItemB")
                totalPrice += 200;
            else if (item == "ItemC")
                totalPrice += 300;
            else
                totalPrice += 50;
        }

        // Apply discount
        if (applyDiscount) {
            totalPrice *= 0.9;  // 10% discount
        }

        // Print receipt (also hard-coded business logic inside)
        Console.WriteLine($"Order for {customerName}:");
        foreach (string item in items) {
            Console.WriteLine($"- {item}");
        }

        Console.WriteLine($"Total price: {totalPrice}");

        // Sending email (hard-coded)
        SendEmailReceipt(customerName, totalPrice);
    }

    // Hard-coded method for sending emails, tightly coupled with the logic of order processing
    private void SendEmailReceipt(string customerName, double totalPrice) {
        Console.WriteLine($"Sending email to {customerName} with total price of {totalPrice}");
    }
}

class Program {
    static void Main(string[] args) {
        OrderProcessor processor = new OrderProcessor();

        // Processing an order
        List<string> items = new List<string> { "ItemA", "ItemB", "ItemX" };  // "ItemX" is an invalid item
        processor.ProcessOrder("John Doe", items, true);
    }
}