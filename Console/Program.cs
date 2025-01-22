﻿using Algorithmics.DependencyInjection;

using Spectre.Console;

AnsiConsole.MarkupLine("\n[lime]ALGORITMOS[/]\n");
AnsiConsole.Write(new Rule("[yellow]Menú Principal[/]").RuleStyle("yellow"));

while (true)
{
    var selection = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("\n[yellow]Seleccione un ejemplo:[/]")
            .PageSize(5)
            .HighlightStyle("lime")
            .AddChoices([
                "Dependency Injection",
                "Exit"]));

    switch (selection)
    {
        case "Dependency Injection":
            DependencyInjection.Run();
            break;
        case "Exit":
            AnsiConsole.MarkupLine("[yellow]¡Gracias por explorar![/]");
            return;
    }

    // Pausa antes de volver al menú principal
    AnsiConsole.MarkupLine("\n[gray](Presiona cualquier tecla para continuar...)[/]");
    Console.ReadKey(true);
}