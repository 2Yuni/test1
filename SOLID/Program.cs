namespace SOLID
{

    // Не надо так
    public class Wife
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        public void CleanUp()
        {
            // do something
        }
        public void Cook()
        {
            // do something
        }

        public bool Love()
        {
            return true;
        }
    }
    // Так надо
    public class WifeCorrect
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        public bool Love()
        {
            return true;
        }
    }

    public class WifeCleanUp
    {
        public void CleanUp()
        {
            // do something
        }
    }

    public class WifeCook
    {
        public void Cook()
        {
            // do something
        }
    }
}