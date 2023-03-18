/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int xA, yA, zA, xB, yB, zB;
double distance;

Console.Write("Введите координату х точки A: ");
int.TryParse(Console.ReadLine()!, out xA);
Console.Write("Введите координату y точки A: ");
int.TryParse(Console.ReadLine()!, out yA);
Console.Write("Введите координату z точки A: ");
int.TryParse(Console.ReadLine()!, out zA);
Console.Write("Введите координату х точки B: ");
int.TryParse(Console.ReadLine()!, out xB);
Console.Write("Введите координату y точки B: ");
int.TryParse(Console.ReadLine()!, out yB);
Console.Write("Введите координату z точки B: ");
int.TryParse(Console.ReadLine()!, out zB);

distance = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
Console.Write($"Расстояние между точкой A ({xA}, {yA}, {zA}) и точкой B ({xB}, {yB}, {zB}) в 3D пространстве равно {String.Format("{0:0.00}", distance)}");