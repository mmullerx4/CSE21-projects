using System;

class Reception
{
    private bool _rsvp;
    private string _register; //email info

   public override void standardDetails()
    { 

    }

    public override void fullDetails() //include email for rsvp
    {
        Console.WriteLine($"Email: {_register}");
        
    }

    public override void shortDesc()
    {
        
    }
}