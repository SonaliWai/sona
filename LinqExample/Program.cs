















//// See https://aka.ms/new-console-template for more information

var States = FakeData.GetState();
var Talulkas=FakeData.GetTalukas();
var districts=FakeData.GetDistricts();
var Standards = FakeData.GetStandard();
var students=FakeData.GetStudents();

//eg.1
//var innerJoin3 = from Student in students
//                 join stand in Standards
//                 on Student.StandardID equals stand.StandardID
//                 join district in districts
//                 on Student.DistrictId equals district.DistrictId
//                 join State in States
//                 on Student.StateId equals State.StateId
//                 join taluka in Talulkas
//                 on Student.TalukaId equals taluka.TalukaId
//                 //where Student.StudentName.EndsWith('z')
//                 //where stand.StandardName.Contains('D')


//                 select new
//                 {
//                     StudentName = Student.StudentName,
//                     StandardName = stand.StandardName,
//                     StateName = State.StateName,
//                     TalukaName = taluka.TalukaName

//                 };

//foreach (var Student in innerJoin3)
//{
//    Console.WriteLine(Student.StudentName + "," + Student.StandardName + " , " + Student.StateName+"," + Student.TalukaName);
//    Console.WriteLine("----------------------------------------------------");
//}



//eg .2
//var groupedBy = from stud in students
//                group stud by stud.TalukaId;

//foreach (var taluka in groupedBy)
//{
//    Console.WriteLine("Talika Id : {0}", taluka.Key);

//    foreach (Student stud in taluka)
//        Console.WriteLine("Student name :" + stud.StudentName);
//    Console.WriteLine("");
//}



//eg.1.Display the Count of students TalukaWise
//var innerJoin = from taluka in Talulkas
//                 join Student in students
//                 on taluka.TalukaId equals Student.TalukaId
//                 into studGroup

//                 select new
//                 {
//                     Students = studGroup,
//                     talukaName = taluka.TalukaName,
//                     Count = studGroup.Count()
//                 };

//foreach (var taluka in innerJoin)
//{
//    Console.WriteLine(taluka.Count);
//    Console.WriteLine(" ");
//    Console.WriteLine("Taluka Name:{0}", taluka.talukaName);

//    foreach (var student in taluka.Students)
//        Console.WriteLine("Student Name:" + student.StudentName);
//    Console.WriteLine("");
//}


//eg.2 Display State Name where max number of student came from
//var groupjoin = (from state in States
//                 join student in students
//                 on state.StateId equals student.StateId
//                 into studentGroup
//                 orderby state.StateId
//                 select new
//                 {
//                     students = studentGroup,
//                     StateName = state.StateName,
//                     Count = studentGroup.Count()
//                 }).LastOrDefault();
//Console.WriteLine(groupjoin.Count);
//Console.WriteLine("StateName:" + groupjoin.StateName);


//eg.3.Display district Name where min number of students came from
//var groupjoin = (from district in districts
//                 join student in students
//                 on district.DistrictId equals student.DistrictId
//                 into studentGroup
//                 orderby district.DistrictId
//                 select new
//                 {
//                     students = studentGroup,
//                     DistrictName = district.DistrictName,
//                     count = studentGroup.Count()
//                 }).LastOrDefault();
//Console.WriteLine(groupjoin.count);
//Console.WriteLine("DistrictName:" + groupjoin.DistrictName);


//eg.2 salim-logic
//var data2 = from stud in students
//join taluka in Talulkas
//on stud.TalukaId equals taluka.TalukaId
//group taluka by taluka
//into g
//select new
//       {
//           TalukaName = g.Key.TalukaName,
//           TotalCount = g.Count()
//       };

//var maxcount = data2.Max(s => s.TotalCount);
//var data3 = data2.Where(s => s.TotalCount == maxcount);
//Console.WriteLine("Taluka Name"); foreach (var index in data3)
//{
//    Console.WriteLine(index.TalukaName + " ||" + index.TotalCount);
//}



//eg.4.Display First 10 students Information using First Assignment
//var innerJoin3 = (from Student in students
//                  join stand in Standards
//                  on Student.StandardID equals stand.StandardID
//                  join district in districts
//                  on Student.DistrictId equals district.DistrictId
//                  join State in States
//                  on Student.StateId equals State.StateId
//                  join taluka in Talulkas
//                  on Student.TalukaId equals taluka.TalukaId
//                  //where Student.StudentName.EndsWith('z')
//                  //where stand.StandardName.Contains('D')


//                  select new
//                  {
//                      StudentName = Student.StudentName,
//                      StandardName = stand.StandardName,
//                      StateName = State.StateName,
//                      TalukaName = taluka.TalukaName

//                  }).Take(10);

//foreach (var Student in innerJoin3)
//{
//    Console.WriteLine(Student.StudentName + "," + Student.StandardName + " , " + Student.StateName + "," + Student.TalukaName);
//    Console.WriteLine("----------------------------------------------------");
//}


//eg.5.Display Last 10 students Information using First Assignment
//var innerJoin3 = (from Student in students
//                  join stand in Standards
//                  on Student.StandardID equals stand.StandardID
//                  join district in districts
//                  on Student.DistrictId equals district.DistrictId
//                  join State in States
//                  on Student.StateId equals State.StateId
//                  join taluka in Talulkas
//                  on Student.TalukaId equals taluka.TalukaId
//                  //where Student.StudentName.EndsWith('z')
//                  //where stand.StandardName.Contains('D')


//                  select new
//                  {
//                      StudentName = Student.StudentName,
//                      StandardName = stand.StandardName,
//                      StateName = State.StateName,
//                      TalukaName = taluka.TalukaName

//                  }).TakeLast(10);

//foreach (var Student in innerJoin3)
//{
//    Console.WriteLine(Student.StudentName + "," + Student.StandardName + " , " + Student.StateName + "," + Student.TalukaName);
//    Console.WriteLine("----------------------------------------------------");
//}



//eg.10.Display Student Information whose have the same districts and state name

var studData = from s in students
               join dist in districts
               on s.DistrictId equals dist.DistrictId
               join state in States
               on s.StateId equals state.StateId
               group s by new { dist.DistrictName, state.StateName };
   foreach (var item in studData)
{
    var districtName = item.Key.DistrictName;
    var stateName = item.Key.StateName;
    foreach (var Idata in item)
    {
        Console.WriteLine(Idata.StudentName + "||" + districtName + " || " + stateName);
    }
}




//var groupJoin = Talulkas.GroupJoin(Talulkas,  //inner sequence
//                                std => std.StandardID, //outerKeySelector 
//                                s => s.StandardID,     //innerKeySelector
//                                (std, studentsGroup) => new // resultSelector 
//                                {
//                                    Students = studentsGroup,
//                                    StandarFulldName = std.talukaName
//                                });

//foreach (var item in groupJoin)
//{
//    Console.WriteLine(item.StandarFulldName);

//    foreach (var stud in item.Students)
//        Console.WriteLine(stud.talukaName);
//}
//1.Display Student Information



//Console.WriteLine("Hello, World!");
//string[] names = { "Bill", "StAve", "James", "Mohan" };

//// LINQ Query 

////foreach(string name in names)
////{
////    if(name.StartsWith("moh"))
////            Console.WriteLine(name); //James,Mohan
////}

////var myLinqQuery = names.Where(n => n.StartsWith("Moh"));

////var myLinqQuery2 = from name in names
////                   where name.Contains('a')
////                   select name;
///*
// * 
// * 
// * 
// * 
// * 
// * 
// */ 


//var mylinqquery3 = names.groupby(x => x.contains(''));

//foreach (var index in mylinqquery3)
//{

//    foreach (var data in index)
//    {
//        console.writeline(data);
//    }
//    console.writeline();
//}


//// query execution
//foreach (var name in mylinqquery3)
//    console.write(name + " ");


////var myLinqQuery3 = names.GroupBy(x => x.Contains('a'));

////foreach(var index in myLinqQuery3)
////{

////   foreach(var Data in index)
////    {
////        Console.WriteLine(Data);
////    }
////   Console.WriteLine();
////}


////// Query execution
////foreach (var name in myLinqQuery3)
////    Console.Write(name + " ");




//////Joins


//IList<string> strList1 = new List<string>() {
//    "One",
//    "Two",
//    "Three",
//    "Four"
//};

//IList<string> strList2 = new List<string>() {
//    "One",
//    "Two",
//    "Five",
//    "Six"
//};

//var innerJoin = strList1.Join(strList2,
//                      str1 => str1,
//                      str2 => str2,
//                      (str1, str2) => str1);



//IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
//    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
//    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
//    new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
//    new Student() { StudentID = 5, StudentName = "Ron"  }
//};

//IList<Standard> standardList = new List<Standard>() {
//    new Standard(){ StandardID = 1, StandardName="Standard A"},
//    new Standard(){ StandardID = 2, StandardName="Standard B"},
//    new Standard(){ StandardID = 3, StandardName="Standard C"}
//};

////var innerJoin2 = studentList.Join(// outer sequence 
////                      standardList,  // inner sequence 
////                      student => student.StandardID,    // outerKeySelector
////                      standard => standard.StandardID,  // innerKeySelector
////                      (student, standard) => new  // result selector
////                      {
////                          StudentName = student.StudentName,
////                          StandardName = standard.StandardName
////                      });

////foreach (var standard in innerJoin2)
////{
////    Console.WriteLine(standard.StudentName + "  " + standard.StandardName);
////}




//var innerJoin3 = from student in studentList
//                 join stand in standardList
//                 on student.StandardID equals stand.StandardID
//                 select new
//                 {
//                     StudentName = student.StudentName,
//                     StandardName= stand.StandardName,
//                 };

//foreach(var student in innerJoin3)
//{
//    Console.WriteLine(student.StudentName +","+student.StandardName);
//}



