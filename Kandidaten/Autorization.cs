using System;
using System.Collections.Generic;
using System.Text;

namespace Kandidaten
{

    public class AutorizationException : Exception
    {
        public AutorizationException() { }

        public AutorizationException(string message) : base(message) { }
    }

    public static class Autorization
    {
        public static bool isAutorization { get; private set; }

        private static string username_ = "admin";
        private static string password_ = "admin";

        public static void Login(string username, string password)
        {
            if (username != username_ || password != password_)
            {
                throw new AutorizationException("Wrong username or password");
            }
            isAutorization = true;
        }

        public static void Logout()
        {
            isAutorization = false;
        }
    }
}
