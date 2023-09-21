using System;

public static class Bob
{
    public static string Response(string statement)
    {
        bool isQuestion = statement.Contains("?");
        bool isYelling = statement == statement.ToUpper();
        bool isSilence = true;
        char[] stArr = statement.ToCharArray();

        foreach (char ch in stArr) 
        {
            if (Char.IsLetter(ch))
            {
               isSilence = false; 
            }
        }

        if ( isSilence )
        {
            return "Fine. Be that way!";
        } 
    
        else if ( isYelling && isQuestion  )
        {
            return "Calm down, I know what I'm doing!";
        }
        else if ( isQuestion )
        {
            return "Sure.";
        }
        else if ( isYelling  )
        {
            return "Whoa, chill out!";
        }    
        else 
        {
            return "Whatever.";
        }
    }
}