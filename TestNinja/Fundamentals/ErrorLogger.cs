
using System;

namespace TestNinja.Fundamentals
{
    public class ErrorLogger
    {
        public string LastError { get; set; }

        public event EventHandler<Guid> ErrorLogged; 
        
        public void Log(string error)
        {
            // check for null
            // check for an empty string
            // check string has white space
            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();
                
            LastError = error; 
            
            // Write the log to a storage
            // ...

            // April 9, 2022
            // Methods that Raise an Event
            ErrorLogged?.Invoke(this, Guid.NewGuid());
        }
    }
}