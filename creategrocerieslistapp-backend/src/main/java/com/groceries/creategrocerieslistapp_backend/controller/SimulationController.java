package com.groceries.creategrocerieslistapp_backend.controller;

import com.groceries.creategrocerieslistapp_backend.model.Product;
import com.groceries.creategrocerieslistapp_backend.service.SimulationService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/calculate")
public class SimulationController {

    @Autowired
    private SimulationService simulationService;

    @PostMapping("/total")
    public double calculateTotal(@RequestBody List<Product> products) {
        if (products == null || products.isEmpty()) {
            return 0.0;
        }

        // Call SimulationService to compute total via COBOL
        return simulationService.calculateTotal(products);
    }
}