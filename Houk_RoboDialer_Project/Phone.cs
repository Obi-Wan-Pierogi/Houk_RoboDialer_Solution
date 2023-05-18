namespace Houk_RoboDialer_Project
{
    // base abstract class to prevent instantiation
    public abstract class Phone
    {
        private string _company;
        private string _phoneNumber;
        private int _phoneType;

        // base constructor with 3 arguments that stores the data 
        protected Phone(string company, string phoneNumber, int phoneType)
        {
            _company = company;
            _phoneNumber = phoneNumber;
            _phoneType = phoneType;
        }

        // base virtual Dial() method to be overridden in derived classes
        public virtual string Dial()
        {
            return "Dialing phone number" + _phoneNumber;
        }

        // getters for private data
        public string Company
        {
            get { return _company; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public int PhoneType
        {
            get { return _phoneType; }
        }
    }
}
