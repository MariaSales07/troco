decimal valorcompra, valorpago, valortroco;

Console.WriteLine("--- troco ---\n");

Console.Write("Digite o valor da compra:");
valorcompra = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o valor pago:");
valorpago = Convert.ToDecimal(Console.ReadLine());

valortroco = valorpago - valorcompra;

Console.WriteLine($"\nTroco: {valortroco}:c");


