using Telegram.Bot;
using Telegram.Bot.Types;

namespace NailTelegramBot
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                var botClient = new TelegramBotClient(Environment.GetEnvironmentVariable("BOT_TOKEN"));
                botClient.StartReceiving(Update, Error);
                
                Console.WriteLine("READY TO WORK");
                while (true) { }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            if (update.Message.Text == "привет")
            {
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "пока");
            }
        }

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
    }
}