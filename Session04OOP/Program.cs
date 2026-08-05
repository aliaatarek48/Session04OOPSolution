namespace Session04OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Abstract Class 
            //// Shape s = new Shape("Red");   //  Compiler Error you cannot create it directly

            //Circle circle = new Circle("Red", 5);
            //Rectangle rectangle = new Rectangle("Blue", 4, 6);

            //circle.Display();       // Area 78.54 , Perimeter 31.42
            //rectangle.Display();    // Area 24.00 , Perimeter 20.00

            //circle.Describe();      // "I am a circle..."  (overridden)
            //rectangle.Describe();   // "I am a shape..."   (base/virtual, not overridden)


            //// One base - type reference(Shape) object.
            //Shape[] shapes =
            // {
            //    new Circle("Red", 5),
            //    new Rectangle("Blue", 10, 15),
            //    new Circle("Green", 2),
            //}
            // ;

            //double totalArea = 0;
            //foreach (Shape shape in shapes)
            //{
            //    Console.WriteLine($"{shape.GetType().Name} -> Area = {shape.Area():F2}"); // RunTime Polymorphism 
            //    totalArea += shape.Area();
            //}
            //Console.WriteLine($"Total Area = {totalArea:F2}");
            #endregion

            #region Interface 
            //// A basic phone signs ONE contract: IPhone. It can only call / SMS.
            //BasicPhone basic = new BasicPhone("Nokia 105");
            //basic.Call("012-345-6789");
            //basic.SendSMS("Hello");

            //// An interface reference can point to any implementer:
            //IPhone phone = basic;
            //phone.Call("012-000-1111");

            //SmartPhone smart = new SmartPhone("Galaxy S24");

            //smart.Call("012-345-6789");
            //smart.SendSMS("Hi");
            //smart.TakePhoto();
            //smart.RecordVideo();

            //// Use it as a phone:
            //IPhone asPhone = smart;
            //asPhone.Call("012-345-6789");
            //asPhone.SendSMS("Hi");
            //asPhone.TakePhoto(); // invalid
            //asPhone.RecordVideo(); // invalid 

            //// Use the SAME object as a camera:
            //ICamera asCamera = smart;
            //asCamera.TakePhoto();
            //asCamera.RecordVideo();
            #endregion

            #region Abstract Class + Interface TOGETHER
            //Employee[] employees =
            //{
            //    new Manager(1, "Ahmed", 30000),
            //    new Developer(2, "Salma", 20000, 12),
            //    new Intern(3, "Omar", 5000),
            //};

            //foreach (Employee emp in employees)
            //{
            //    emp.GetInfo(); // from abstract class
            //    Console.WriteLine($"   Salary = {emp.CalculateSalary():C}"); // Runtime Polymorphism 

            //    // Ask at runtime: does THIS employee support the bonus capability?
            //    if (emp is IBonus bonusable)
            //        // bonusable.BonusType -> property (WHAT) , CalculateBonus() -> method (HOW MUCH)
            //        Console.WriteLine($"   Bonus  = {bonusable.CalculateBonus():C} ({bonusable.BonusType})");
            //    else
            //        Console.WriteLine("   Bonus  = (not bonus able)");
            //}
            #endregion

        }
    }
}
