Console.Clear();

double salarioHora = 0;
int horasTrabalhadas = 0, horasExtras = 0;

static double CalculaSalario(double salarioHora, int horasTrabalhadas, int horasExtras)
{
    double salarioBase = salarioHora * horasTrabalhadas;
    double valorHoraExtra =  salarioHora * 1.4;
    double adicionalExtras = valorHoraExtra * horasExtras;
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
        double.TryParse(inputSalarioHora, out salarioHora) &&
        int.TryParse(inputHorasTrabalhadas, out horasTrabalhadas) &&
        int.TryParse(inputHorasExtras, out horasExtras);

    if (entradasValidas && salarioHora > 0 && horasTrabalhadas >= 0 && horasExtras >= 0)
    {
        double salarioTotal = CalculaSalario(salarioHora, horasTrabalhadas, horasExtras);
        Console.WriteLine($"\nSalário final: {salarioTotal:C2}\n");
        break;
    }
    else
    {
        Console.WriteLine("\nAlgum dos valores está inválido. Tente novamente.\n");
    }

}