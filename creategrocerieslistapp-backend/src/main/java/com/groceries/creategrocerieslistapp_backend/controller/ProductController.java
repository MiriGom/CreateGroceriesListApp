package com.groceries.creategrocerieslistapp_backend.controller;

import com.groceries.creategrocerieslistapp_backend.model.Product;
import com.groceries.creategrocerieslistapp_backend.service.ProductService;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/products")
public class ProductController {

    private final ProductService productService;

    public ProductController(ProductService productService) {
        this.productService = productService;
    }

    @PostMapping("/add")
    public String addProduct(@RequestBody Product product) {
        productService.addProduct(product);
        return "Product added successfully!";
    }

    // New endpoint to get products for a specific user
    @GetMapping("/user/{userId}")
    public List<Product> getProductsByUser(@PathVariable Long userId) {
        return productService.getProductsByUserId(userId);
    }
}