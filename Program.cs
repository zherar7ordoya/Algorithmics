﻿using Algorithmics.CompositePattern;
using Algorithmics.DependencyInjection;
using Algorithmics.Kaprekar6174;

using Spectre.Console;


var examples = new List<(string Title, Action Example)>
{
    ("Patrón composite", CompositePattern.Run),
    ("Inyección de dependencias", DependencyInjection.Run),
    ("Número de Kaprekar (6174)", Kaprekar6174.Run),
    ("Salir", () => Environment.Exit(0))
};

while (true)
{
    AnsiConsole.Write(new Rule("[yellow]ALGORITMIA[/]").RuleStyle("yellow"));

    var selection = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("\n[cyan]Seleccione un ejemplo:[/]")
            .HighlightStyle("lime")
            .AddChoices([.. examples.ConvertAll(e => e.Title)]));
    
    var (Title, Example) = examples.Find(e => e.Title == selection);
    Example();

    AnsiConsole.MarkupLine("\n[cyan](Presione cualquier tecla para volver...)[/]");
    Console.ReadKey(true);
    Console.Clear();
}
