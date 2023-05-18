namespace Houk_RoboDialer_Project
{
    internal class CellPhone : Phone
    {
        // derived constructor with 3 arguments that stores the data in the base class
        public CellPhone(string company, string phoneNumber, int phoneType) : base(company, phoneNumber, phoneType)
        {

        }

        // overridden method Dial() runs if phoneType is 2, else returns an error
        public override string Dial()
        {
            if (PhoneType == 2)
            {
                return Company + " is being dialed using 1+" + PhoneNumber + "...";
            }
            else
            {
                return "Error in phone type";
            }
        }
    }
}
