using System;

public class EventBroker
{
    public static event Action SpellPerformed;

    public static void CallSpellPerformed()
    {
        if(SpellPerformed != null)
        {
            SpellPerformed();
        }
    }
}
