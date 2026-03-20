package com.groceries.creategrocerieslistapp_backend.controller;

import com.groceries.creategrocerieslistapp_backend.model.User;
import com.groceries.creategrocerieslistapp_backend.service.UserService;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/users")
public class UserController {

    private final UserService userService;

    public UserController(UserService userService) {
        this.userService = userService;
    }

    @PostMapping("/register")
    public String register(@RequestBody User user) {
        userService.registerUser(user);
        return "User saved successfully!";
    }

    // New GET endpoint to fetch all users
    @GetMapping("/all")
    public List<User> getAllUsers() {
        return userService.getAllUsers();
    }
}