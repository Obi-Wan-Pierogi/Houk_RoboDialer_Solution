namespace Houk_RoboDialer_Project
{
    internal class HomePhone : Phone
    {
        // derived constructor with 3 arguments that stores the data in the base class
        public HomePhone(string company, string phoneNumber, int phoneType) : base(company, phoneNumber, phoneType)
        {

        }

        // overridden method Dial() runs if phoneType is 1, else returns an error
        public override string Dial()
        {
            if (PhoneType == 1)
            {
                return Company + " is being dialed using " + PhoneNumber + "...";
            }
            else
            {
                return "Error in phone type";
            }
        }
    }
}
