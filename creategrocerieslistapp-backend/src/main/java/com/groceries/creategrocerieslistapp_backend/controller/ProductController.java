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
    public Product addProduct(@RequestBody Product product) {
        return productService.addProduct(product);
    }

    @GetMapping("/user/{userId}")
    public List<Product> getUserProducts(@PathVariable Long userId) {
        return productService.getUserProducts(userId);
    }
}