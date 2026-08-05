namespace Session04OOP.Interfaces
{
    internal class BasicPhone : IPhone
    {
        public string Model { get; set; }

        public BasicPhone(string model)
        {
            Model = model;
        }

        public void Call(string number) => Console.WriteLine($"  Calling {number}...");
        public void SendSMS(string message) => Console.WriteLine($"  SMS: {message}");
    }
}
