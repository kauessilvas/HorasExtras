Console.Clear();

decimal salarioHora = 0;
int horasTrabalhadas = 0, horasExtras = 0;

static decimal CalculaSalario(decimal salarioHora, int horasTrabalhadas, int horasExtras)
{
    decimal salarioBase = salarioHora * horasTrabalhadas;
    decimal valorHoraExtra =  salarioHora * 1.4m;
    decimal adicionalExtras = valorHoraExtra * horasExtras;
    return salarioBase + adicionalExtras;
}

Console.WriteLine("==== Calcula Salário ====");

while (true)
{
    Console.Write("Digite o salário por hora: ");
    string inputSalarioHora = Console.ReadLine()!;

    Console.Write("Digite o total de horas trabalhadas: ");
    string inputHorasTrabalhadas = Console.ReadLine()!;

    Console.Write("Digite o total de horas extras trabalhadas: ");
    string inputHorasExtras = Console.ReadLine()!;

    bool entradasValidas =
        decimal.TryParse(inputSalarioHora, out salarioHora) &&
        int.TryParse(inputHorasTrabalhadas, out horasTrabalhadas) &&
        int.TryParse(inputHorasExtras, out horasExtras);

    if (entradasValidas && salarioHora > 0 && horasTrabalhadas >= 0 && horasExtras >= 0)
    {
        decimal salarioTotal = CalculaSalario(salarioHora, horasTrabalhadas, horasExtras);
        Console.WriteLine($"\nSalário final: {salarioTotal:C2}\n");
        break;
    }
    else
    {
        Console.WriteLine("\nAlgum dos valores está inválido. Tente novamente.\n");
    }
}