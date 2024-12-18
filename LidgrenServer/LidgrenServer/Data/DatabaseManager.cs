using System.Collections.Generic;
using System.Linq;
using LidgrenServer.Models;
using Microsoft.EntityFrameworkCore;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    private AppDbContext _dbContext;

    private void Awake()
    {
        _dbContext = new AppDbContext();
        _dbContext.Database.EnsureCreated(); // Tạo DB nếu chưa tồn tại
        Debug.Log("Database initialized!");
    }

    // User operations
    public void AddUser(User user)
    {
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        Debug.Log($"User {user.Username} added.");
    }

    public User GetUserById(int id)
    {
        return _dbContext.Users.Find(id);
    }

    public List<User> GetAllUsers()
    {
        return _dbContext.Users.ToList();
    }

    // Character operations
    public void AddCharacter(Character character)
    {
        _dbContext.Characters.Add(character);
        _dbContext.SaveChanges();
        Debug.Log($"Character {character.Name} added.");
    }

    public Character GetCharacterById(int id)
    {
        return _dbContext.Characters.Find(id);
    }

    public List<Character> GetAllCharacters()
    {
        return _dbContext.Characters.ToList();
    }

    // Item operations
    public void AddItem(Item item)
    {
        _dbContext.Items.Add(item);
        _dbContext.SaveChanges();
        Debug.Log($"Item {item.Name} added.");
    }

    public List<Item> GetAllItems()
    {
        return _dbContext.Items.ToList();
    }

    // Equipment operations
    public void AddEquipment(Equipment equipment)
    {
        _dbContext.Equipments.Add(equipment);
        _dbContext.SaveChanges();
        Debug.Log($"Equipment {equipment.Name} added.");
    }

    public List<Equipment> GetAllEquipments()
    {
        return _dbContext.Equipments.ToList();
    }

    // Cleanup
    private void OnApplicationQuit()
    {
        _dbContext.Dispose();
        Debug.Log("Database connection closed.");
    }
}
