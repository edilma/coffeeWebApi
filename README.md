# CoffeeShop WebAPI

Welcome to the CoffeeShop WebAPI! This is a RESTful API built using C# .NetCore designed to manage products in a coffee shop. Whether you're fetching details of the products, adding a new item, updating, or deleting them, this API has got you covered.

## API Endpoints Overview

Below is a screenshot from Swagger UI showing the available endpoints in this API:

![Swagger UI Endpoints](https://github.com/edilma/coffeeWebApi/blob/master/images/end_points_coffeWebApi.png?raw=true)

![Swagger UI /Products ](https://github.com/edilma/coffeeWebApi/blob/master/images/Get_endPoint.png?raw=true)

## Table of Contents

- [Getting Started](#getting-started)
- [Endpoints](#endpoints)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

### Prerequisites

- .NET Core SDK
- A preferred IDE or code editor (I like Visual Studio or Visual Studio Code)

### Installation

1. Clone the repository:

```
git clone https://github.com/[Your_GitHub_Username]/CoffeeShopWebAPI.git
```

2. Navigate to the project directory:

```
cd CoffeeShopWebAPI
```

3. Restore the required packages:

```
dotnet restore
```

4. Run the application:

```
dotnet run
```

## Endpoints

**1. Get All Products**

```
[GET] /api/products
```

Returns a list of all available products.

**2. Get Specific Product**

```
[GET] /api/products/{id}
```

Returns a specific product by its ID.

**3. Add New Product**

```
[POST] /api/products
```

Add a new product. Body must contain product details.

**4. Update a Product**

```
[PUT] /api/products/{id}
```

Update details of a product by its ID. Body must contain updated product details.

**5. Delete a Product**

```
[DELETE] /api/products/{id}
```

Remove a specific product by its ID.

**6. Delete Multiple Products**

```
[POST] /api/products/Delete
```

Remove multiple products. Query must contain an array of product IDs. For example: `/api/products/Delete?ids=1&ids=2&ids=3`

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change. Ensure to update tests as appropriate.

## License

This project is licensed under the MIT License - see the LICENSE.md file for details.

---

Happy coding! ☕️

```

```
