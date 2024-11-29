using ZH_2.Enums;

namespace ZH_2;

internal class Program
{
    public static void Main(string[] args)
    {
        Dataset dataset = new Dataset();
        int selected = 0;

        static void PrintMenu()
        {
            Console.WriteLine("1. Load data file");
            Console.WriteLine("2. Get average monthly revenue");
            Console.WriteLine("3. List non-paying users");
            Console.WriteLine("4. Show distribution of devices");
            Console.WriteLine("5. Exit");
            Console.Write("\nYour choice: ");
        }

        do
        {
            Console.Clear();
            PrintMenu();
            selected = (int)char.GetNumericValue(Console.ReadKey().KeyChar);

            switch (selected)
            {
                case 1:
                {
                    Console.Write("\nFilename: ");
                    string fileName = Console.ReadLine()!;
                    dataset = new Dataset(fileName);
                    break;
                }

                case 2:
                {
                    Console.Write("\nSubscription type: ");
                    SubscriptionType subType = Enum.Parse<SubscriptionType>(Console.ReadLine()!);
                    Console.WriteLine(dataset.AverageMonthlyRevenue(subType));
                    break;
                }

                case 3:
                {
                    Console.Write("\nDeadline: ");
                    int deadline = int.Parse(Console.ReadLine()!);
                    User[] nonPayers = dataset.CollectNonPayers(deadline);

                    foreach (User nonPayer in nonPayers)
                    {
                        Console.WriteLine(nonPayer.DataAsText());
                    }

                    break;
                }

                case 4:
                {
                    Console.Write("\nDevice type: ");
                    DeviceType deviceType = Enum.Parse<DeviceType>(Console.ReadLine()!);
                    Console.WriteLine(dataset.DistributionOfDeviceType(deviceType));
                    break;
                }

                case 5:
                {
                    continue;
                }

                default:
                {
                    Console.WriteLine("\nHibás menüpontot választottál!");
                    break;
                }
            }

            Console.ReadKey();
        } while (selected != 5);

        Console.WriteLine("\nA program kilépett.");
    }
}
