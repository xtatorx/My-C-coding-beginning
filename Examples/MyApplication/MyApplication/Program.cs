namespace MyApplication
{


    class Things_To_Do
    {

        string color = "Color is Red";
        string fruit = "Fruit is Apple";
        string day = "Day is Thursday";
        string college = "College is ECPI";

        static void Main(string[] args)
        {
            Things_To_Do c = new Things_To_Do();
            Things_To_Do f = new Things_To_Do();
            Things_To_Do d = new Things_To_Do();
            Things_To_Do co = new Things_To_Do();

            Console.WriteLine(c.color);
            Console.WriteLine(f.fruit);
            Console.WriteLine(d.day);
            Console.WriteLine(co.college);




        }



    }
}
