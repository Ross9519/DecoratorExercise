using DesignPatterns.Decorator.enums;
using DesignPatterns.Decorator.factories;

try
{
	Console.WriteLine("benvenuto\n");

	string cmd = string.Empty;
	do
	{
        Console.WriteLine("------------------");
        Console.WriteLine("Seleziona il tipo di consegna:");
        Console.WriteLine("consegna espressa [e]");
        Console.WriteLine("consegna standard [s]");
        Console.WriteLine("pacchetto regalo [r]");
        Console.WriteLine("consegna in negozio [n]");
        Console.WriteLine("spegni [q]");
        Console.WriteLine("------------------");
		cmd = Console.ReadLine()!.ToLower();
        Console.WriteLine();
		if (cmd.Equals("q"))
			break;
		Console.WriteLine($"Hai selezionato {SelectionDelivery(cmd)}");
        Console.WriteLine();
    } while (true);
    Console.WriteLine("\naddio");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

static string SelectionDelivery(string cmd)
{
	var item = DeliveryFactory.GetDelivery(DeliveryEnum.Store);
    return cmd switch
    {
        "e" => DeliveryFactory.GetDelivery(DeliveryEnum.Express, item).Info(),
        "s" => DeliveryFactory.GetDelivery(DeliveryEnum.Standard, item).Info(),
        "r" => DeliveryFactory.GetDelivery(DeliveryEnum.Gift, item).Info(),
        "n" => item.Info(),
        _ => "un valore non supportato",
    };
}