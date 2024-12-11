using System;
using System.Collections.Generic;

namespace ChatSystem
{
    public class ChatMediator
    {
        private List<User> users;

        public ChatMediator()
        {
            users = new List<User>();
        }

        // Добавление пользователя в чат
        public void AddUser(User user)
        {
            users.Add(user);
            Console.WriteLine($"{user.Name} присоединился к чату.");
        }

        // Удаление пользователя из чата
        public void RemoveUser(User user)
        {
            if (users.Contains(user))
            {
                users.Remove(user);
                Console.WriteLine($"{user.Name} покинул чат.");
            }
        }

        // Отправка сообщения от одного пользователя к другому
        public void SendMessage(string senderName, string receiverName, string message)
        {
            User receiver = users.Find(u => u.Name == receiverName);
            if (receiver != null)
            {
                receiver.ReceiveMessage(senderName, message);
            }
            else
            {
                Console.WriteLine($"Пользователь {receiverName} не найден или покинул чат.");
            }
        }
    }
}
