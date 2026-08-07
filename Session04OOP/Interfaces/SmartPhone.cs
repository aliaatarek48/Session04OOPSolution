namespace Session04OOP.Interfaces
{
    // A class inherits from ONLY ONE base class,
    // but it can implement MANY interfaces at the same time.
    // A SmartPhone acts as a phone AND as a camera.
    internal class SmartPhone : IPhone, ICamera
    {
        public string Model { get; set; }

        public SmartPhone(string model)
        {
            Model = model;
        }

        // IPhone part of the contract
        public void Call(string number) => Console.WriteLine($"  Calling {number}...");
        public void SendSMS(string message) => Console.WriteLine($"  SMS: {message}");

        // ICamera part of the contract
        public void TakePhoto() => Console.WriteLine("  Taking a photo...");
        public void RecordVideo() => Console.WriteLine("  Recording a video...");

        // Explicit Implementation 
        void IPhone.process()
        {
            Console.WriteLine("IPhone Processing...");
        }

        void ICamera.Process()
        {
            Console.WriteLine("ICamera Processing...");
        }
    }
}
