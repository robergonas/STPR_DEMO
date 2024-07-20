
namespace STPR_UI.Modelo
{
    public class utilitarioBL
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public bool VerificarClave(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

        //public static byte[] GenerarClaveAleatoria()
        //{
        //    using (var rng = new RNGCryptoServiceProvider())
        //    {
        //        byte[] clave = new byte[32];
        //        rng.GetBytes(clave);
        //        return clave;
        //    }
        //}
        //public static byte[] GenerarIVAleatorio()
        //{
        //    using (var rng = new RNGCryptoServiceProvider())
        //    {
        //        byte[] iv = new byte[16];
        //        rng.GetBytes(iv);
        //        return iv;
        //    }
        //}
        //public static string EncriptarCadena(string textoPlano, byte[] clave, byte[] iv)
        //{
        //    using (Aes aes = Aes.Create())
        //    {
        //        aes.Key = clave;
        //        aes.IV = iv;
        //        ICryptoTransform encriptador = aes.CreateEncryptor(aes.Key, aes.IV);

        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, encriptador, CryptoStreamMode.Write))
        //            {
        //                using (StreamWriter sw = new StreamWriter(cs))
        //                {
        //                    sw.Write(textoPlano);
        //                }
        //            }
        //            return Convert.ToBase64String(ms.ToArray());
        //        }
        //    }
        //}
        //public static string DesencriptarCadena(string textoCifrado, byte[] clave, byte[] iv)
        //{
        //    using (Aes aes = Aes.Create())
        //    {
        //        aes.Key = clave;
        //        aes.IV = iv;
        //        ICryptoTransform desencriptador = aes.CreateDecryptor(aes.Key, aes.IV);

        //        using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(textoCifrado)))
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, desencriptador, CryptoStreamMode.Read))
        //            {
        //                using (StreamReader sr = new StreamReader(cs))
        //                {
        //                    return sr.ReadToEnd();
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
