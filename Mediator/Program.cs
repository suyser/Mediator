using System;

namespace ChatSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание посредника (медиатора)
            ChatMediator mediator = new ChatMediator();

            // Создание пользователей
            User alice = new User("Alice", mediator);
            User bob = new User("Bob", mediator);
            User charlie = new User("Charlie", mediator);

            // Добавление пользователей в чат
            mediator.AddUser(alice);
            mediator.AddUser(bob);
            mediator.AddUser(charlie);

            // Обмен сообщениями
            alice.SendMessage("Bob", "Привет, Боб!");
            bob.SendMessage("Alice", "Привет, Алиса! Как дела?");
            charlie.SendMessage("Alice", "Привет, Алиса! Это Чарли.");
            alice.SendMessage("Charlie", "Привет, Чарли! Рада тебя слышать.");

            // Показ истории сообщений
            alice.ShowMessageHistory();
            bob.ShowMessageHistory();
            charlie.ShowMessageHistory();

            // Выход пользователя из чата
            mediator.RemoveUser(bob);

            // Попытка отправки сообщения Бобу после выхода
            alice.SendMessage("Bob", "Ты здесь?");

            // Завершение программы
            Console.WriteLine("Чат завершен.");
            Console.ReadKey();
        }
    }
}
