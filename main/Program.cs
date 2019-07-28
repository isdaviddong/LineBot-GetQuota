using System;
using isRock.LineBot.Extensions;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Channel Access Token : ");
            var CAT = Console.ReadLine();
            isRock.LineBot.Bot b = new isRock.LineBot.Bot(CAT);

            var msg = "";

            msg += $"\n\n Get the target limit for additional messages : \n{b.GetTheTargetLimitForAdditionalMessages().value}";
            msg += $"\n\n Get number of messages sent this month : \n{b.GetNumberOfMessagesSentThisMonth().totalUsage}";

            msg += $"\n\n Get number of sent reply messages : \n{b.GetNumberOfSentReplyMessages(DateTime.UtcNow.AddDays(-1)).ToJson()}";
            msg += $"\n\n Get number of sent push messages : \n{b.GetNumberOfSentPushMessages(DateTime.UtcNow.AddDays(-1)).ToJson()}";
            msg += $"\n\n Get number of sent multicast  messages : \n{b.GetNumberOfSentMulticastMessages(DateTime.UtcNow.AddDays(-1)).ToJson()}";
            msg += $"\n\n Get number of sent broadcast  messages : \n{b.GetNumberOfSentBroadcastMessages(DateTime.UtcNow.AddDays(-1)).ToJson()}";

            msg += $"\n\n Get number of message deliveries : \n{b.GetNumberOfMessageDeliveries(DateTime.UtcNow.AddDays(-1)).ToJson()}";
            msg += $"\n\n Get number of followers : \n{b.GetNumberOfFollowers(DateTime.UtcNow.AddDays(-1)).ToJson()}";
            msg += $"\n\n Get friend demographics : \n{b.GetFriendDemographics().ToJson()}";

            Console.WriteLine(msg);
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
    }
}
