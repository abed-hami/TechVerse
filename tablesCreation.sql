use TechVerse

-- Table to store user information
CREATE TABLE Users (
    id INT PRIMARY KEY IDENTITY(1,1),
    firstName VARCHAR(100) NOT NULL,
    lastName VARCHAR(100) NOT NULL,
    email VARCHAR(500) UNIQUE NOT NULL,  -- Ensure emails are unique
    password VARCHAR(500) NOT NULL,
    location VARCHAR(500) NOT NULL,
    dateOfBirth DATE NOT NULL,
    balance INT DEFAULT 0 NOT NULL,  -- Set default balance to 0
    points INT DEFAULT 0 NOT NULL    -- Set default points to 0
);

-- Table to store product categories
CREATE TABLE Categories (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(200) NOT NULL
);

-- Table to store coupon details
CREATE TABLE Coupons (
    id INT PRIMARY KEY IDENTITY(1,1),
    code VARCHAR(200) NOT NULL,
    type VARCHAR(200) NOT NULL,
    value INT NOT NULL,
    expireyDate DATETIME NOT NULL,
    minOrder INT NOT NULL,
    status VARCHAR(100) DEFAULT 'active' NOT NULL  -- Default status could be 'active'
);

-- Table to store gift card details
CREATE TABLE GiftCards (
    id INT PRIMARY KEY IDENTITY(1,1),
    code VARCHAR(200) NOT NULL,
    value INT NOT NULL,
    expireyDate DATETIME NOT NULL,
    status VARCHAR(100) DEFAULT 'active' NOT NULL  -- Default status could be 'active'
);

-- Table to store products
CREATE TABLE Products (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(300) NOT NULL,
    brand VARCHAR(300) NOT NULL,
    description VARCHAR(300) NOT NULL,
    img VARCHAR(1000) NOT NULL,
    basePrice INT NOT NULL,
    label VARCHAR(300) NOT NULL,
    quantity INT NOT NULL,
    categoryId INT NOT NULL,
    FOREIGN KEY (categoryId) REFERENCES Categories(id) ON DELETE Cascade
);

-- Table to store product variants (e.g., color, size)
CREATE TABLE Product_Variants (
    id INT PRIMARY KEY IDENTITY(1,1),
    color VARCHAR(300) NOT NULL,
    colorValue VARCHAR(200) NOT NULL,
    quantity INT NOT NULL,
    attribute VARCHAR(300) NOT NULL,
    attributeValue VARCHAR(300) NOT NULL,
    code VARCHAR(200) NOT NULL,
    img VARCHAR(1000) NOT NULL,
    productId INT NOT NULL,
    FOREIGN KEY (productId) REFERENCES Products(id) ON DELETE CASCADE
);

-- Table to store user's cart information
CREATE TABLE Carts (
    id INT PRIMARY KEY IDENTITY(1,1),
    status VARCHAR(200) NOT NULL,
    userId INT NOT NULL,
    FOREIGN KEY (userId) REFERENCES Users(id) ON DELETE CASCADE
);

-- Table to store items in the cart
CREATE TABLE CartItems (
    id INT PRIMARY KEY IDENTITY(1,1),
    cartId INT NOT NULL,
    productId INT NOT NULL,
    quantity INT NOT NULL,
    totalPrice INT NOT NULL,
    FOREIGN KEY (cartId) REFERENCES Carts(id) ON DELETE CASCADE,
    FOREIGN KEY (productId) REFERENCES Products(id)
);

-- Table to store orders
CREATE TABLE Orders (
    id INT PRIMARY KEY IDENTITY(1,1),
    userId INT NOT NULL,
    date DATE NOT NULL,
    address VARCHAR(500) NOT NULL,
    status VARCHAR(200) DEFAULT 'pending' NOT NULL,  -- Default order status is 'pending'
    couponId INT,
    FOREIGN KEY (userId) REFERENCES Users(id) ON DELETE CASCADE,
    FOREIGN KEY (couponId) REFERENCES Coupons(id)
);

-- Table to store items in each order
CREATE TABLE OrderItems (
    id INT PRIMARY KEY IDENTITY(1,1),
    orderId INT NOT NULL,
    productId INT NOT NULL,
    quantity INT NOT NULL,
    unitPrice INT NOT NULL,
    totalPrice INT NOT NULL,
    FOREIGN KEY (orderId) REFERENCES Orders(id) ON DELETE CASCADE,
    FOREIGN KEY (productId) REFERENCES Products(id)
);

-- Table to store payment details
CREATE TABLE Payments (
    id INT PRIMARY KEY IDENTITY(1,1),
    userId INT NOT NULL,
    orderId INT NOT NULL,
    amount INT NOT NULL,
    paymentMethod VARCHAR(300) NOT NULL,
    date DATETIME NOT NULL,
    status VARCHAR(200) NOT NULL,
    FOREIGN KEY (userId) REFERENCES Users(id) ON DELETE CASCADE,
    FOREIGN KEY (orderId) REFERENCES Orders(id) 
);
