// За да се пише 2.23 с точка (а не 2,23 със запетая)
Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

Controller controller = new Controller();
controller.Run();
