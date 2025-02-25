class OrderProcessor:
    # The following method contains several responsibilities: creating the order, calculating price, applying discount, and printing a receipt.
    def process_order(self, customer_name, items, apply_discount):
        total_price = 0

        # Calculate price
        for item in items:
            if item == "ItemA":
                total_price += 100
            elif item == "ItemB":
                total_price += 200
            elif item == "ItemC":
                total_price += 300
            else:
                total_price += 50

        # Apply discount
        if apply_discount:
            total_price *= 0.9  # 10% discount

        # Print receipt (also hard-coded business logic inside)
        print(f"Order for {customer_name}:")
        for item in items:
            print(f"- {item}")
        print(f"Total price: {total_price}")

        # Sending email (hard-coded)
        self.send_email_receipt(customer_name, total_price)

    # Hard-coded method for sending emails, tightly coupled with the logic of order processing
    def send_email_receipt(self, customer_name, total_price):
        print(f"Sending email to {customer_name} with total price of {total_price}")


if __name__ == "__main__":
    processor = OrderProcessor()

    # Processing an order
    items = ["ItemA", "ItemB", "ItemX"]  # "ItemX" is an invalid item
    processor.process_order("John Doe", items, True)
