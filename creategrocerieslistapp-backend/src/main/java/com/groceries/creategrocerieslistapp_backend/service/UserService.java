package com.groceries.creategrocerieslistapp_backend.service;

import com.groceries.creategrocerieslistapp_backend.model.User;
import com.groceries.creategrocerieslistapp_backend.repository.UserRepository;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Service;
import java.time.LocalDateTime;
import java.util.List;

@Service
public class UserService {

    private final UserRepository userRepository;
    private final JdbcTemplate jdbcTemplate;

    public UserService(UserRepository userRepository, JdbcTemplate jdbcTemplate) {
        this.userRepository = userRepository;
        this.jdbcTemplate = jdbcTemplate;
    }
    public void registerUser(User user) {
        // Set defaults
        user.setRole("USER");
        user.setIsActive(true);
        user.setCreatedAt(LocalDateTime.now());

        // Save to DB
        userRepository.save(user);
    }

    // Get all users
    public List<User> getAllUsers() {
        return jdbcTemplate.query(
                "SELECT * FROM users",
                (rs, rowNum) -> {
                    User user = new User();
                    user.setUsername(rs.getString("username"));
                    user.setEmail(rs.getString("email"));
                    user.setPassword(rs.getString("password"));
                    user.setRole(rs.getString("role"));
                    user.setIsActive(rs.getBoolean("is_active"));
                    user.setCreatedAt(
                            rs.getTimestamp("created_at") != null
                                    ? rs.getTimestamp("created_at").toLocalDateTime()
                                    : null
                    );
                    return user;
                }
        );
    }
}