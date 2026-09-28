Console.WriteLine("INICIO EF DBF");


var context = new ConsoleApp_12B_26C2_EF_DBF.Models.Ort26c212bContext();

var consultaMaterias = from mate in context.Courses
                       select mate;

foreach (var moniargento in consultaMaterias)
{
    Console.WriteLine($"Materia: {moniargento.CourseName}");
}