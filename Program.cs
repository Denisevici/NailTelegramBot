﻿using Microsoft.VisualBasic;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace NailTelegramBot
{
    internal class Program
    {
        static void Main()
        {
            var botClient = new TelegramBotClient("6356956562:AAE9c3LbqBndtBL11EOIRTb9xYn55ksczGg");
            botClient.StartReceiving(Update, Error);
            Console.WriteLine("READY TO WORK");
            while (true) { }
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