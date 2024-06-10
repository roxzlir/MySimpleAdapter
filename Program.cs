namespace MySimpleAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IXmlHandler xmlService = new XmlService();
            IJsonHandler jsonHandler = new XmlToJsonAdapter(xmlService);

            Console.WriteLine(jsonHandler.GetJsonData());
        }
    }
}
