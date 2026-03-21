package com.groceries.creategrocerieslistapp_backend.service;

import com.groceries.creategrocerieslistapp_backend.model.Product;
import com.groceries.creategrocerieslistapp_backend.repository.ProductRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ProductService {

    private final ProductRepository productRepository;

    public ProductService(ProductRepository productRepository) {
        this.productRepository = productRepository;
    }

    public Product addProduct(Product product) {
        return productRepository.save(product);
    }

    public List<Product> getUserProducts(Long userId) {
        return productRepository.findByUserId(userId);
    }
}