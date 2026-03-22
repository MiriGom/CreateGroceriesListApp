package com.groceries.creategrocerieslistapp_backend.service;

import com.groceries.creategrocerieslistapp_backend.model.Product;
import org.springframework.stereotype.Service;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

@Service
public class SimulationService {

    // Path to COBOL executable
    private static final String COBOL_EXE = "C:\\Users\\miria\\OneDrive\\Desktop\\first-app\\CreateGroceriesListApp\\cobol-engine\\product-total.exe";

    /**
     * Calculate total cost using COBOL program
     */
    public double calculateTotal(List<Product> products) {
        try {
            // Build argument list: first argument = number of products
            List<String> command = new ArrayList<>();
            command.add(COBOL_EXE);
            command.add(String.valueOf(products.size()));

            // Each product: add quantity and price in cents
            for (Product p : products) {
                command.add(String.valueOf(p.getQuantity()));
                command.add(String.valueOf((int) Math.round(p.getPrice() * 100)));
            }

            // Start COBOL process
            ProcessBuilder pb = new ProcessBuilder(command);
            pb.redirectErrorStream(true);
            Process process = pb.start();

            // Read output (total in cents)
            BufferedReader reader = new BufferedReader(new InputStreamReader(process.getInputStream()));
            String output = reader.readLine();

            int exitCode = process.waitFor();
            if (exitCode != 0) {
                throw new RuntimeException("COBOL process failed with exit code: " + exitCode);
            }

            // Convert cents to dollars
            return Double.parseDouble(output) / 100.0;

        } catch (Exception e) {
            e.printStackTrace();
            return 0.0; // fallback if COBOL fails
        }
    }
}