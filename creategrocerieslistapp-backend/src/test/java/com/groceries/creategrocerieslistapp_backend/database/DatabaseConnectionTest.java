package com.groceries.creategrocerieslistapp_backend;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;

@SpringBootTest
class DatabaseConnectionTest {

	@Test
    void testDatabaseConnection() {
    String url = System.getenv("DB_URL");
    String username = System.getenv("DB_USER");
    String password = System.getenv("DB_PASSWORD");

    try (Connection conn = DriverManager.getConnection(url, username, password)) {
        if (conn != null && !conn.isClosed()) {
            System.out.println("✅ Successfully connected to the database!");
        } else {
            System.out.println("❌ Failed to connect to the database.");
        }
    } catch (SQLException e) {
        System.err.println("❌ Error connecting to DB: " + e.getMessage());
    }
}

}

