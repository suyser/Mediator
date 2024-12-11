using System;
using System.Collections.Generic;

namespace ChatSystem
{
    public class User
    {
        public string Name { get; private set; }
        private ChatMediator mediator;
        private List<string> messageHistory;

        public User(string name, ChatMediator mediator)
        {
            Name = name;
            this.mediator = mediator;
            messageHistory = new List<string>();
        }

        // Отправка сообщения через посредника
        public void SendMessage(string receiverName, string message)
        {
            Console.WriteLine($"{Name} отправляет сообщение для {receiverName}: \"{message}\"");
            mediator.SendMessage(Name, receiverName, message);
        }

        // Получение сообщения
        public void ReceiveMessage(string senderName, string message)
        {
            string formattedMessage = $"От {senderName}: {message}";
            Console.WriteLine($"{Name} получил сообщение: \"{formattedMessage}\"");
            messageHistory.Add(formattedMessage);
        }

        // Показ истории сообщений
        public void ShowMessageHistory()
        {
            Console.WriteLine($"\nИстория сообщений пользователя {Name}:");
            if (messageHistory.Count == 0)
            {
                Console.WriteLine("Сообщений пока нет.");
            }
            else
            {
                foreach (var msg in messageHistory)
                {
                    Console.WriteLine(msg);
                }
            }
            Console.WriteLine();
        }
    }
}
