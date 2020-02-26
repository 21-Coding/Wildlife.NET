namespace Wildlife.Model
{
    public class Animal
    {
        private string _name;
        private string _type;
        private string _dateArrived;
        private bool _inOrOut;
        private bool _feeding; 
        private string _gender; 
        public Animal(string name, string type, string dateArrived, bool inOrOut, bool feeding, string gender)

        {

        _name = name;
        _type = type; 
        _dateArrived = dateArrived;
        _inOrOut = inOrOut;
        _feeding = feeding; 
        _gender = gender;

        }

        public string GetAnimalName()
        {
            return _name;
        }

        public string GetAnimalType()
        {
            return _type;
        }

        public string GetDateArrived()
        {
            return _dateArrived;
        }

        public bool GetInOrOut()
        {
            return _inOrOut;
        }

        public bool GetFeeding()
        {
            return _feeding;
        }
    }
}