class OrderProcessor:
    def process_order(self, customer_name, items, apply_discount):
        total_price = 0

        for item in items:
            if item == "ItemA":
                total_price += 100
            elif item == "ItemB":
                total_price += 200
            elif item == "ItemC":
                total_price += 300
            else:
                total_price += 50

        if apply_discount:
            total_price *= 0.9 

        print(f"Order for {customer_name}:")
        for item in items:
            print(f"- {item}")
        print(f"Total price: {total_price}")

        self.send_email_receipt(customer_name, total_price)

    def send_email_receipt(self, customer_name, total_price):
        print(f"Sending email to {customer_name} with total price of {total_price}")


if __name__ == "__main__":
    processor = OrderProcessor()

    items = ["ItemA", "ItemB", "ItemX"] 
    processor.process_order("John Doe", items, True)
