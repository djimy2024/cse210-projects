 // A code template for the category of things known as Person. The
    // responsibility of a Person is to hold and display personal information.
    public class Person
    {
        Person person = new Person();
        person._givenName = "Joseph";
        person._familyName = "Smith";
        person.ShowWesternName();
        person.ShowEasternName();

        person1 = new Person();
        person1._givenName = "Emma";
        person1._familyName = "Smith";
        person1.ShowWesternName();

        person2 = new Person();
        person2._givenName = "Joseph";
        person2._familyName = "Smith";
        person2.ShowWesternName();

        int height;
        string color;
    
        // The C# convention is to start member variables with an underscore _
        public string _givenName = "";
        public string _familyName = "";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Person()
        {
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }

        // A method that displays the person's full name as used in western 
        // countries or <given name family name>.
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }

        public class Blind
        {

            Blind kitchen = new Blind();
            kitchen._width = 60;
            kitchen._height = 48;
            kitchen._color = "white";
            public double _width;
            public double _height;
            public string _color;

            Console.WriteLine(kitchen._width);

            public double GetArea()
           {
            return _width * _height;
            double materialAmount = kitchen.GetArea();
            }
}
        }

        public class House
    {
        House johnsonHome = new House();
        johnsonHome._owner = "Johnson Family";
        johnsonHome._kitchen._width = 60;
        johnsonHome._kitchen = new Blind();
        johnsonHome._livingRoom = new Bind();
        public string _owner = "";
        johnsonHome._blinds.Add(kitchen);
        double amount = johnsonHome._blinds[0].GetArea();
        public Blind _kitchen = new Blind();
        public Blind _livingRoom = new Blind();
        public string _owner;
        public Blind _kitchen;
        public Blind _livingRoom;

        foreach (Blind b in johnsonHome._blinds)
        {
           double amount = b.GetArea();
        }
    }
    
    