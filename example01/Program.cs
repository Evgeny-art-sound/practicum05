// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
double inputCoordinate(string text)
{
	Console.Write($"Введите {text}: ");
	double coodinate = double.Parse(Console.ReadLine() ?? "");
	return (coodinate);
}
// После упрощения аравнения x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1
Console.Clear();
Console.WriteLine("Точка пересечения двух прямых заданных уравнением ");
double k1 = inputCoordinate("k1");
double b1 = inputCoordinate("b1");
double k2 = inputCoordinate("k2");
double b2 = inputCoordinate("b2");
Console.WriteLine($"Координаты точки пересечения для k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} равны х = {((b2 - b1) / (k1 - k2))} и y = {(k2 * ((b2 - b1) / (k1 - k2)) + b2)} ");
