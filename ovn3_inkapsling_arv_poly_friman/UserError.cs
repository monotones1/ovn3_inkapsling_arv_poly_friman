using System;
using System.Collections.Generic;
using System.Text;

namespace ovn3_inkapsling_arv_poly_friman
{
    abstract class UserError
    {
        public virtual string UEMessage()
        {
            return "Unspecified error";
        }
    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!"; 
        }
    }
    class TrumpIsStupidError : UserError
    {
        public override string UEMessage()
        {
            return "You voted for Donald Trump. Guru meditation error";
        }
    }
    class DownTheRabbitHoleError : UserError
    {
        public override string UEMessage()
        {
            return "You went down the rabbit hole error.";
        }
    }
    class BadStepError : UserError
    {
        public override string UEMessage()
        {
            return "You took a bad step while dancing error";
        }
    }
}
