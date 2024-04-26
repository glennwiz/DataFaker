# Customer Data Generator

## Overview

This project uses a tool called Bogus to create fake customer data. It's perfect for when you need a bunch of sample customer information for testing your application without using real data from actual people.

## Getting Started

### Prerequisites

You need to have .NET installed on your computer to run this project. If you don't have it, you can download it from the [official .NET website](https://dotnet.microsoft.com/download).

### Installation

1. **Clone this repository** to your local machine. If you're not sure how to do this, here's a quick guide on [cloning a GitHub repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository).

2. **Navigate to the project directory** on your computer through your command line or terminal.

3. **Run the application** by typing `dotnet run` in the terminal within the project directory. This command will compile and execute the code.

## How It Works

The code in this project creates 100 fake entries for customers. Each entry includes details like:

- **Customer ID**: A unique identifier for each customer.
- **Name and Contact Info**: Includes first name, last name, full name, email, and phone number.
- **QrCode**: A simulated QR code value and an expiry date.

The fake data is generated completely at random by Bogus, which means every time you run the application, the data will look different. This is great for testing different scenarios in your applications.

### Example Output

Here's what the output might look like:

```json
[
  {
    "CustomerClient": {
      "CustomerId": "1a2b3c4d5e6f7g8h9i0j",
      "CustomerGroups": [],
      "FirstName": "John",
      "LastName": "Doe",
      "FullName": "John Doe",
      "Email": "john.doe@example.com",
      "Phone": "123-456-7890",
      "LastOrder": null,
      "QrCode": {
        "Value": "STU_V2_1a2b3c4d5e6f7g8h9i0j___1234567890000_abc123def456ghi789jkl0",
        "Expiry": 1234567890000
      },
      "CustomerClientCards": [],
      "CustomerLoyaltyPrograms": [],
      "RewardPrograms": []
    }
  }
  // 99 more entries...
]
