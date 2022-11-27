// See https://aka.ms/new-console-template for more information
using Calculator;

Presenter presenter = new Presenter(new ConsoleUI(), new MathModel());
presenter.Run();
