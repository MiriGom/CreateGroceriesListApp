package com.groceries.creategrocerieslistapp_backend.database;

import org.junit.jupiter.api.Test;
import java.sql.*;

import static org.junit.jupiter.api.Assertions.assertTrue;

public class QueryExecutionTest {

    @Test
    void testSelectFromGroceriesTable() throws SQLException {
        String url = System.getenv("DB_URL");
        String user = System.getenv("DB_USER");
        String password = System.getenv("DB_PASSWORD");

        try (Connection conn = DriverManager.getConnection(url, user, password);
             Statement stmt = conn.createStatement()) {

            ResultSet rs = stmt.executeQuery("SELECT COUNT(*) FROM groceries");

            assertTrue(rs.next(), "ResultSet should have at least one row");
            int count = rs.getInt(1);
            System.out.println("Rows in groceries table: " + count);
        }
    }
}