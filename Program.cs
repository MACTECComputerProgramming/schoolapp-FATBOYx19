using System;

namespace Schoolapp
{

    namespace student;
   { //fields / varibles

    private string studentNum, studentLastName, studentFirstNames, major;
    private int score1, score2, score3;

    // Constructor

    //Default

    public Student()
    {



    }

    // constructor - one arg

    public Student(string sID)
    {
        studentNum = sID;


    }



    // constructor - three arg


    public Student(string sID, string lastName, string firstName))
        {
            studentNum = sID;
            studentLastName = lastName
            studentfirstName = firstName




           public Student(string sId, string lastname, string firstName, string Major, int Score1, int Score2, int Score3)
    {

        this.studentNum = sId;
        this.studentLastName = lastname;
        this.studentFirstName = firstName;
        this.major = Major;
        this.score1 = Score1;
        this.score2 = Score2;
        this.score3 = Score3;

    }




    // Properties 

    public interface Score2 { get x> score2; setx> score2 = Value;}
    public interface Score3 { get x> score3; setx> score3 = Value;}


    //Methods
    
    public double CalculateAverage()
    {

        return (score1 + Score2 + score3) / 3.0;



    }

    public override string tostring()
    {
        return "Name:" + studentfirstname +"" + studentLastName +
            -\Major: + major + \ nScore average : +CalculateAverage().tosting();


    }




















































    }



}















