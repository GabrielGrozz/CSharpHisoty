namespace EqualAndGetHashCode
{
    internal class Product
    {
        public string Name { get; set; }

        public double value { get; set; }

        //quando utilizamos os métodos em classes, precisamos passar uma "regra" para dizermos oque iremo utilizar para dizer
        //que algo é igual a outra coisas, por exemplo podemos dizer que uma classe é igual a outra classe quando o Value das duas for igual

        //precisamo fazer um override para aplicarmos a nossa lógica
        public override bool Equals(object? obj)
        {
            //se o obj que recebermos for diferente de Product, return false
            if (!(obj is Product)) return false;

            //downcast
            Product other = obj as Product;

            //aqui aplicamos a nossa lógica, o parametro que iremos utilizar para dizer que uma classe é igual a outra é o name
            return Name.Equals(other.Name);

        }

        //override do GetHashCode
        public override int GetHashCode()
        {
            //como estamos nos baseando no nome, o GetHashCode irá nos retornar o valor do email
            return Name.GetHashCode();
        }




    }
}
