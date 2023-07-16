namespace Diamanter.ENTITIES
{
    internal class Printer : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Processig document: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine(document);
        }
    }
}
