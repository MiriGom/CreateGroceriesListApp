package com.groceries.creategrocerieslistapp_backend.repository;

import com.groceries.creategrocerieslistapp_backend.model.Product;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.support.GeneratedKeyHolder;
import org.springframework.jdbc.support.KeyHolder;
import org.springframework.stereotype.Repository;

import java.sql.PreparedStatement;
import java.sql.Statement;
import java.sql.Timestamp;

@Repository
public class ProductRepository {

    private final JdbcTemplate jdbcTemplate;

    public ProductRepository(JdbcTemplate jdbcTemplate) {
        this.jdbcTemplate = jdbcTemplate;
    }

    public void save(Product product) {
        if (product.getCreatedAt() == null) {
            product.setCreatedAt(java.time.LocalDateTime.now());
        }

        String sql = "INSERT INTO products (user_id, name, quantity, price, created_at) VALUES (?, ?, ?, ?, ?)";

        KeyHolder keyHolder = new GeneratedKeyHolder();

        jdbcTemplate.update(connection -> {
            PreparedStatement ps = connection.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
            ps.setLong(1, product.getUserId());
            ps.setString(2, product.getName());
            ps.setInt(3, product.getQuantity());
            ps.setDouble(4, product.getPrice());
            ps.setTimestamp(5, Timestamp.valueOf(product.getCreatedAt()));
            return ps;
        }, keyHolder);

        product.setId(keyHolder.getKey().longValue());
    }
}