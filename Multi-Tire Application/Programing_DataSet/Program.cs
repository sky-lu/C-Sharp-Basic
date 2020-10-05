using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Programing_DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            //What is a DataSet ?
            //DataSet:A class in the ADO.Net Object Model
            //         The major component in ADO.Net Object Model
            //DataSet object: An in-memory representation of data downloaded from a data source
            //                 (e.g a table in a database)
            //DataSet object: Disconnected data
            //               A collection(set) of DataTables
            //DataTable object: 


            //Question 2
            //Declare and create an object of type DataSet and name the object as CollegeDS.
            //Display the name of the DataSet object on the screen.
            DataSet dsCollege = new DataSet("CollegeDS");
            //DataSet dsCollege = new DataSet();
            //dsCollege.DataSetName = "CollegeDS";
            Console.WriteLine("\n\n\tThe name of the DataSet object : " + dsCollege.DataSetName);
            //Question 3
            //Declare and create 3 DataTable objects and name the objects as Students, Courses,
            //and StudentCourses respectively.
            DataTable dtStudents = new DataTable("Students");
            DataTable dtCourses = new DataTable("Courses");
            DataTable dtStudentCourses = new DataTable("StudentsCourses");




            //Question 4
            //Add the three DataTable objects(Question 3) to the DataSet object
            dsCollege.Tables.Add(dtStudents);
            dsCollege.Tables.Add(dtCourses);
            dsCollege.Tables.Add(dtStudentCourses);

            //Question 5
            //Write a code segment to display the number of DataTable objects
            //and all the names of the DataTable objects.
            Console.WriteLine("\n\n\tThe number of the DataTable objects : " + dsCollege.Tables.Count);
            Console.WriteLine("\n\t" + dtStudents.TableName);
            Console.WriteLine("\n\t" + dtCourses.TableName);
            Console.WriteLine("\n\t" + dtStudentCourses.TableName);



            //Question 6
            //Write a code segment to define DataColumn objects for the DataTable object Students
            //, name the DataColumn objects as StudentId, FirstName and LastName respectively
            //and specify the Data Type for each column.Set the DataColumn object StudentId as
            //primary key.
            dtStudents.Columns.Add("StudentId", typeof(Int32));
            dtStudents.Columns.Add("FirstName", typeof(string));
            //dtStudents.Columns.Add("FirstName", System.Type.GetType("System.String"));
            dtStudents.Columns.Add("LastName", typeof(string));
            dtStudents.PrimaryKey = new DataColumn[] { dtStudents.Columns["StudentId"] };

            foreach (DataColumn item in dtStudents.Columns)
            {
                Console.WriteLine("\n\t" + item.ColumnName + "\t\t" + item.DataType);
            }

            //Question 7
            //Write a code segment to populate the DataTable Students with the following data:
            //            StudentId FirstName LastName
            //1111111 John Abbot
            //2222222 Mary Green
            //3333333 Thomas Moore
            DataRow dr1 = dtStudents.NewRow();
            dr1["StudentId"] = 1111111;
            dr1["FirstName"] = "John";
            dr1["LastName"] = "Abbot";
            dtStudents.Rows.Add(dr1);

            DataRow dr2 = dtStudents.NewRow();
            dr2["StudentId"] = 2222222;
            dr2["FirstName"] = "Mary";
            dr2["LastName"] = "Green";
            dtStudents.Rows.Add(dr2);
           
            DataRow dr3 = dtStudents.NewRow();
            dr3["StudentId"] = 3333333;
            dr3["FirstName"] = "Thomas";
            dr3["LastName"] = "Moore";
            dtStudents.Rows.Add(dr3);
            //dtStudents.Rows.Add(1111111, "John", "Abbot");

            foreach (DataRow dr in dtStudents.Rows)
            {
                Console.WriteLine("\n\t\t" + dr["StudentId"] + "\t\t" + dr["FirstName"] + "\t\t" + dr["LastName"]);
            }

            //Question 8
            //Write a code segment to define DataColumn objects for the DataTable object Courses
            //, name the DataColumn objects as CourseCode, CourseTitle and TotalHour respectively
            //and specify the Data Type for each column.Set the DataColumn object CourseCode as
            //primary key.
            dtCourses.Columns.Add("CourseCode", typeof(string));
            dtCourses.Columns.Add("CourseTitle", typeof(string));
            dtCourses.Columns.Add("TotalHour", typeof(Int32));
            dtCourses.PrimaryKey = new DataColumn[] { dtCourses.Columns["CourseCode"] };
            foreach (DataColumn dc in dtCourses.Columns)
            {
                Console.WriteLine("\n\t" + dc.ColumnName + "\t\t" + dc.DataType);
            }

            //Question 9
            //Write a code segment to populate the DataTable Courses with the following data:
            //            CourseCode CourseTitle TotalHour
            //420 - P16 - AS Structured Programming 90
            //420 - P25 - AS Introduction to Object Programing 75
            //420 - P34 - AS Advanced Object Programming 60
            //420 - P46 - AS Event Programming 90
            //420 - P55 - AS Internet Programming I 75
            dtCourses.Rows.Add("420 - P16 - AS", "Structured Programming", 90);
            dtCourses.Rows.Add("420 - P25 - AS", "Introduction to Object Programing", 75);
            dtCourses.Rows.Add("420 - P34 - AS", "Advanced Object Programming", 60);
            dtCourses.Rows.Add("420 - P46 - AS", "Event Programming", 90);
            dtCourses.Rows.Add("420 - P55 - AS", "Internet Programming I", 75);
            foreach (DataRow dr in dtCourses.Rows)
            {
                Console.WriteLine("\n\t\t" + dr["CourseCode"] + "\t\t" + dr["CourseTitle"] + "\t\t" + dr["TotalHour"]);
            }

            //Question 10
            //Write a code segment to define DataColumn objects for the DataTable object
            //StudentCourses, name the DataColumn objects as StudentId and CourseCode,
            //respectively and specify the Data Type for each column.Set the DataColumn objects
            //StudentId and CourseCode as primary key
            //Hints: Take a look at Constraints collection and the ForeignKeyConstraint class.
            dtStudentCourses.Columns.Add("StudentId", typeof(Int32)); 
            dtStudentCourses.Columns.Add("CourseCode", typeof(string));

            dtStudentCourses.PrimaryKey = new DataColumn[] {dtStudentCourses.Columns["StudentId"],dtStudentCourses.Columns["CourseCode"] };
            //relationships
            DataRelation drSToSC = new DataRelation("SToSC", dtStudents.Columns["StudentId"], dtStudentCourses.Columns["StudentId"]);
            DataRelation drCToSC = new DataRelation("CToSC", dtCourses.Columns["CourseCode"], dtStudentCourses.Columns["CourseCode"]);
            dsCollege.Relations.Add(drSToSC);
            dsCollege.Relations.Add(drCToSC);
            //ForeignKeyConstraint fkeyConstraint1 = new ForeignKeyConstraint(dtStudents.Columns["StudentId"], dtStudentCourses.Columns["StudentId"]);
            //ForeignKeyConstraint fkeyConstraint2 = new ForeignKeyConstraint(dtCourses.Columns["CourseCode"], dtStudentCourses.Columns["CourseCode"]);
             
            //dtStudentCourses.Constraints.Add(fkeyConstraint1);
            //dtStudentCourses.Constraints.Add(fkeyConstraint2);
            Console.WriteLine("\n\n" + "=========================================================================================");

            foreach (DataColumn dc in dtStudentCourses.Columns)
            {
                Console.WriteLine("\n\t" + dc.ColumnName + "\t\t" + dc.DataType);
            }
            //Question 11
            //Write a code segment to populate the DataTable StudentCourses with the following
            //data:
            //            StudentId CourseCode
            //1111111 420 - P16 - AS
            //2222222 420 - P16 - AS
            //1111111 420 - P25 - AS
            //2222222 420 - P25 - AS
            //3333333 420 - P34 - AS
            //3333333 420 - P55 - AS

            dtStudentCourses.Rows.Add(1111111, "420 - P16 - AS");
            dtStudentCourses.Rows.Add(2222222, "420 - P16 - AS");
            dtStudentCourses.Rows.Add(1111111, "420 - P25 - AS");
            dtStudentCourses.Rows.Add(2222222, "420 - P25 - AS");
            dtStudentCourses.Rows.Add(3333333, "420 - P34 - AS");
            dtStudentCourses.Rows.Add(3333333, "420 - P55 - AS");
            Console.WriteLine("\n\n\n");

            foreach (DataRow dr in dtStudentCourses.Rows)
            {
                Console.WriteLine("\n\t" + dr["StudentId"] + "\t\t" + dr["CourseCode"]);
            }

            //Question 12
            //Write a code segment to display all the courses registered by a given student.
            //For example: List all the courses for the student John Abbot.
            // StudentId = 1111111
            // in Rows (Collection, Find(key)
            ////string expression = "FirstName = 'John' and LastName = 'Abbot'";
            ////DataRow[] foundRows = dtStudents.Select(expression);
            ////for(int i=0; i < foundRows.Length; i++)
            ////{
            ////    Int32 stId = Convert.ToInt32(foundRows[i][0]);
            ////    string expression1 = $"StudentId = {stId}";
            ////    DataRow[] foundRows1 = dtStudentCourses.Select(expression1);
            ////    for (int j=0; j < foundRows1.Length; j++)
            ////    {
            ////        string courseCode = foundRows1[j][1].ToString();
            ////        string expression2 = $"CourseCode = '{courseCode}'";
            ////        DataRow[] foundRows2 = dtCourses.Select(expression2);
            ////        foreach (DataRow dr in foundRows2)
            ////        {
            ////            Console.WriteLine("\n\n\n\t" + dr["CourseCode"] + "\t\t" + dr["CourseTitle"] + "\t\t" + dr["TotalHour"]);
            ////        }
            ////    }

            ////}

            DataRow drStudent = dtStudents.Rows.Find(1111111);
            Console.WriteLine("\n\n\t\t\t\tCourse List");
            Console.WriteLine("\n\n\t\t" + "Student : " + drStudent["StudentId"] + "," + drStudent["FirstName"] + "," + drStudent["LastName"]);
            Console.WriteLine("\n\n\n\tCourse Code" + "\t\tCourse Title" + "\t\tTotal Hour");

            foreach (DataRow dr in dtStudentCourses.Rows)
            {
                if (Convert.ToInt32(dr["StudentId"]) == 1111111)
                {
                    DataRow drCourse = dtCourses.Rows.Find(dr["CourseCode"]);
                    Console.WriteLine("\n\t " + drCourse["CourseCode"] + "\t\t " + drCourse["CourseTitle"] + "\t\t " + drCourse["TotalHour"]);
                }
            }

            
            
            
            
            
            
            Console.WriteLine("\n\n\tPress any key to exit the program....");
            Console.ReadKey();

        }
    }
}
