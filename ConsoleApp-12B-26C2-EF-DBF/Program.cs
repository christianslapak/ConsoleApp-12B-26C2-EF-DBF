using ConsoleApp_12B_26C2_EF_DBF.Models;

Console.WriteLine("INICIO EF DBF");


var context = new ConsoleApp_12B_26C2_EF_DBF.Models.Ort26c212bContext();

var consultaMaterias = from mate in context.Courses
                       select mate;

foreach (var moniargento in consultaMaterias)
{
    Console.WriteLine($"Materia: {moniargento.CourseName}");
}



context.Courses.Add(new Course()
{
    CourseName = "Materia Nueva",
    TeacherId = 4
});
context.SaveChanges();


var consultaMaterias2 = from mate in context.Courses
                       select mate;

foreach (var moniargento in consultaMaterias)
{
    Console.WriteLine($"Materia: {moniargento.CourseName}");
}


