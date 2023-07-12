using System;

class Reception : Event
{
    private string _register; //email info


    public Reception(string eventTitle, string eventDesc, string eventDate, string eventTime, Address eventAddress) : base(eventTitle, eventDesc, eventDate, eventTime, eventAddress)
    {
         _eventType = "Event type: Reception";
         _register = "Please RSVP at ReceptionEvent@mail.com"; //will display with fullDescription()
    }


    public void fullDescription() //include email for rsvp
    {
        fullDetails();
        Console.WriteLine($"Email: {_register}");    
    }
}