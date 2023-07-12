using System;

class Reception
{
    private bool _rsvp;
    private string _register; //email info


    public Reception()
    {
         _eventType = "Event type: Reception";
    }

   

    public override void addToReception() //include email for rsvp
    {
        fullDetails();
        Console.WriteLine($"Email: {_register}");
        
    }

}