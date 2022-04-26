
using System.Text;

namespace RazorClassLibrary1
{
    public partial class Base64Converter
    {

        public string NonBase64Body { get; set; }
        public string Base64Body { get; set; }

        private void ConvertToBase64()
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(NonBase64Body);
            Base64Body = Convert.ToBase64String(plainTextBytes);
        }

        private void ConvertFromBase64()
        {
            var base64EncodedBytes = Convert.FromBase64String(Base64Body);
            NonBase64Body = Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
