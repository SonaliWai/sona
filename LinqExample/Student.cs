
// See https://aka.ms/new-console-template for more information

// LINQ Query 









// Query execution




//Joins
//public static void GetStudents(object selectedStudentList)
//{
//    using RegistarDbContext db = new RegistarDbContext();
//    var query = db.tblCourses
//        .SelectMany(s => s.tblStudents)
//        .ToList();



//    query.Add(selectedStudentList);
//    db.SaveChanges();

//}







public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int StandardID { get; set; }
    public int StateId{get; set; }

    public int DistrictId { get; set; }

    public int TalukaId { get; set; }   

}