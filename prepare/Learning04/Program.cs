// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         var assignmentOne = new Assignment("Jade Miller", "C# Inheritance");
//         var writingassignmentOne = new WritingAssignment("Bruce Lee", "Mixed Martial Arts", "Mixed Martial Arts: a Fighting Stlye");
//         var mathassignmentOne = new MathAssignment("Harry Pooter", "No Math at Hogwarts", "Page 394", "1-7");

//         Console.WriteLine(assignmentOne.GetSummary());
//         Console.WriteLine(writingassignmentOne.GetSummary());
//         Console.WriteLine(mathassignmentOne.GetSummary());
//     }

// class Assignment {
//     protected string _studentName;
//     protected string _topic;

//     //constructor
//     public Assignment(string studentName, string topic) {
//         _studentName = studentName;
//         _topic = topic;
//     }  
// }

//    class WritingAssignment: Assignment {
//         protected string _title;

//         //constructor
//         public WritingAssignment(string studentName, string topic, string title): base(studentName, topic){
//             _title = title;
//         }
//         public GetWritingInformation() {

//         }
//     }
//    class MathAssignment: Assignment {
//         protected string _textbookSection;
//         protected string _problems;

//         //constructor
//         public MathAssignment(string studentName, string topic, string textbookSection, string problems): base(studentName, topic){
//             _textbookSection = textbookSection;
//             _problems = problems;
//         }
//         public GetHomeworkList() {

//         }
//    }    
// }