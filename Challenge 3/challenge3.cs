using System;
using System.Collections.Generic;

class OrderProcessor {
    public void ProcessOrder(string customerName, List<string> items, bool applyDiscount) {
        double totalPrice = 0;

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

        if (applyDiscount) {
            totalPrice *= 0.9;  
        }

        Console.WriteLine($"Order for {customerName}:");
        foreach (string item in items) {
            Console.WriteLine($"- {item}");
        }

        Console.WriteLine($"Total price: {totalPrice}");

        SendEmailReceipt(customerName, totalPrice);
    }


    private void SendEmailReceipt(string customerName, double totalPrice) {
        Console.WriteLine($"Sending email to {customerName} with total price of {totalPrice}");
    }
}

class Program {
    static void Main(string[] args) {
        OrderProcessor processor = new OrderProcessor();

        List<string> items = new List<string> { "ItemA", "ItemB", "ItemX" }; 
        processor.ProcessOrder("John Doe", items, true);
    }
}