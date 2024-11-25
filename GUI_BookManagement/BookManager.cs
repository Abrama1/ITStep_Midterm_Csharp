using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace GUI_BookManagement
{
public class BookManager
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> GetAllBooks()
    {
        return books;
    }

    public List<Book> SearchBooks(string title, string author, string year)
    {
            return books.FindAll(b =>
                b.Title.ToLower().Contains(title.ToLower()) ||
                b.Author.ToLower().Contains(author.ToLower()) ||
                b.PublicationYear.ToString().Contains(year)
            );
        }

    public void SaveToFile(string filePath)
    {
        try
        {
            string jsonData = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonData);
        }
        catch (Exception ex)
        {
            throw new Exception("Error saving to file: " + ex.Message);
        }
    }

    public void LoadFromFile(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                books = JsonSerializer.Deserialize<List<Book>>(jsonData) ?? new List<Book>();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error loading from file: " + ex.Message);
        }
    }
}
}
