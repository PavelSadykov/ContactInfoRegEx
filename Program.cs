
using System;
using System.Text.RegularExpressions;
namespace Вопрос_3;
class Contact
{
    public string Phone { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Contact contact = new Contact();

        Console.WriteLine("Введите телефон:");
        string phone = Console.ReadLine();
        if (IsValidPhone(phone))
        {
            contact.Phone = phone;
        }
        else
        {
            Console.WriteLine("Некорректный формат телефона.");
        }

        Console.WriteLine("Введите имя:");
        string name = Console.ReadLine();
        contact.Name = name;

        Console.WriteLine("Введите адрес электронной почты:");
        string email = Console.ReadLine();
        if (IsValidEmail(email))
        {
            contact.Email = email;
        }
        else
        {
            Console.WriteLine("Некорректный формат адреса электронной почты.");
        }

        Console.WriteLine("\nКонтактная информация:");
        Console.WriteLine("Телефон: " + contact.Phone);
        Console.WriteLine("Имя: " + contact.Name);
        Console.WriteLine("Email: " + contact.Email);
    }

    static bool IsValidPhone(string phone)
    {
        // Проверка формата телефона с помощью регулярного выражения
        string pattern = @"^\d{11}$"; // Формат: 11 цифр
        return Regex.IsMatch(phone, pattern);
    }

    static bool IsValidEmail(string email)
    {
        // Проверка формата адреса электронной почты с помощью регулярного выражения
        string pattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"; // Простой формат email
        return Regex.IsMatch(email, pattern);
    }
}
