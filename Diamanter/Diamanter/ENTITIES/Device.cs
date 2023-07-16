namespace Diamanter.ENTITIES
{
    internal abstract class Device
    {
        public double SerialNumber { get; set; }

        //método abstrato que irá ser sobrescrito
        public abstract void ProcessDoc(string document);

    }
}
