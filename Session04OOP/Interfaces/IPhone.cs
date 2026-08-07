namespace Session04OOP.Interfaces
{
    internal interface IPhone
    {
        void Call(string number);
        void SendSMS(string message);
        // Explicit Implementation 
        void process();

        // Default interface method: has a body, so implementing classes don't have to define it.
        void LogProcess()
        {
            Console.WriteLine("Log Process");
        }
    }
}
