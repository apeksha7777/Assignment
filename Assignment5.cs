using System;

namespace Assignment5
{
    //qn1
    //class Student
    //{
    //    int admnNo;
    //    string sName;
    //    float eng;
    //    float math;
    //    float science;
    //    float total;
    //    float cTotal()
    //    {
    //        return this.eng + this.math + this.science;
    //    }

    //    public void takeData(int adNo,string name,float engM,float mathM,float scienceM)
    //    {
    //        this.admnNo = adNo;
    //        this.sName = name;
    //        this.eng = engM;
    //        this.math = mathM;
    //        this.science = scienceM;
    //        this.total=this.cTotal();

    //    }

    //    public void showData()
    //    {
    //        Console.WriteLine("Admin number: {0}", this.admnNo);
    //        Console.WriteLine("s Name: {0}", this.sName);
    //        Console.WriteLine("English marks: {0}", this.eng);
    //        Console.WriteLine("Math marks: {0}", this.math);
    //        Console.WriteLine("science marks: {0}", this.science);
    //        Console.WriteLine("total: {0}", this.total);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Student s = new Student();
    //        s.takeData(1,"Alice",(float)80.6,79,(float)56.3);
    //        s.showData();
    //    }

    //}

    //qn2
    //class Batsman
    //{
    //    int bCode;
    //    string bName;
    //    int innings;
    //    int notOuts;
    //    int runs;
    //    double batavg;

    //    double calcavg()
    //    {
    //        double batavg = this.runs / (this.innings - this.notOuts);
    //        return batavg;

    //    }

    //    public void readData(int bcode, string bname, int inn, int no, int run)
    //    {
    //        this.bCode = bcode;
    //        this.bName = bname;
    //        this.innings= inn;
    //        this.notOuts = no;
    //        this.runs = run;
    //        this.batavg = this.calcavg();

    //    }

    //    public void displayData()
    //    {
    //        Console.WriteLine("b code: {0}", this.bCode);
    //        Console.WriteLine("b Name: {0}", this.bName);
    //        Console.WriteLine("innings: {0}", this.innings);
    //        Console.WriteLine("Not outs: {0}", this.notOuts);
    //        Console.WriteLine("runs: {0}", this.runs);
    //        Console.WriteLine("batavg: {0}", this.batavg);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Batsman b = new Batsman();
    //        b.readData(1, "Alice", 4,3,40);
    //        b.displayData();
    //    }

    //}

    ////qn3
    //class Test
    //{
    //    int TCode;
    //    string desc;
    //    int noCandidates;
    //    int centerReq;


    //    int calcntr()
    //    {
    //        return Convert.ToInt32(((float)this.noCandidates / 100 + 1));

    //    }

    //    public void schedule()
    //    {
    //        Console.Write("Enter test code:");
    //        this.TCode = int.Parse(Console.ReadLine());
    //        Console.Write("Enter description:");
    //        this.desc = Console.ReadLine();
    //        Console.Write("Enter number of candidates:");
    //        this.noCandidates = int.Parse(Console.ReadLine());
    //        this.centerReq = this.calcntr();
    //    }

    //    public void dispTest()
    //    {
    //        Console.WriteLine("Test code:{0}",this.TCode);
    //        Console.WriteLine("Description:{0}",this.desc);
    //        Console.WriteLine("number of candidates:{0}",this.noCandidates);
    //        Console.WriteLine("number of center req:{0}", this.centerReq);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Test t = new Test();
    //        t.schedule();
    //        t.dispTest();
    //    }

    //}

    ////qn4
    //class Flight
    //{
    //    int number;
    //    string destination;
    //    float distance;
    //    float fuel;


    //    float calFuel()
    //    {
    //        if(this.distance<=1000)
    //        {
    //            return 500;
    //        }
    //        else if(this.distance>1000&&this.distance<=2000)
    //        {
    //            return 1100;
    //        }
    //        else
    //        {
    //            return 2200;
    //        }

    //    }

    //    public void feedInfo()
    //    {
    //        Console.Write("Enter flight number:");
    //        this.number = int.Parse(Console.ReadLine());
    //        Console.Write("Enter destination:");
    //        this.destination = Console.ReadLine();
    //        Console.Write("Enter distance:");
    //        this.distance = float.Parse(Console.ReadLine());
    //        this.fuel = this.calFuel();
    //    }

    //    public void showInfo()
    //    {
    //        Console.WriteLine("\nTest flight number:{0}", this.number);
    //        Console.WriteLine("Destination:{0}", this.destination);
    //        Console.WriteLine("distance:{0}", this.distance);
    //        Console.WriteLine("fuel:{0}", this.fuel);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Flight f = new Flight();
    //        f.feedInfo();
    //        f.showInfo();
    //    }

    //}

    //qn5
    class Report
    {
        int adno;
        string name;
        float[] marks=new float[5];
        float average;


        float getAvg()
        {
            float sum=0;
            for(int i=0;i<5;i++)
            {
                sum += this.marks[i];
            }
            return sum / 5;

        }

        public void readInfo()
        {
            Console.Write("Enter ad number: ");
            this.adno = int.Parse(Console.ReadLine());
            Console.Write("Enter name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter marks of five subjects:");
            for(int i=0;i<5;i++)
            {
                this.marks[i] =float.Parse( Console.ReadLine());
            }
            this.average = this.getAvg();
        }

        public void dispInfo()
        {
            Console.WriteLine("\nAd number:{0}", this.adno);
            Console.WriteLine("Name:{0}", this.name);
            Console.WriteLine("Marks");
            for(int i=0;i<5;i++)
            {
                Console.Write(this.marks[i]+" ");
            }
           
            Console.WriteLine("\naverage:{0}", this.average);
        }
        static void Main(string[] args)
        {
            Report r = new Report();
            r.readInfo();
            r.dispInfo();
        }

    }

}
