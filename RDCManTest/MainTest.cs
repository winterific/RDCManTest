using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RDCManTest
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void Decrypt()
        {
            var settings = new RdcMan.EncryptionSettings();
            // TODO: Place your password into this string.
            var encryptedPassword = "";
            var clearPassword = RdcMan.Encryption.DecryptString(encryptedPassword, settings);
            Console.WriteLine(clearPassword);
        }
    }
}
