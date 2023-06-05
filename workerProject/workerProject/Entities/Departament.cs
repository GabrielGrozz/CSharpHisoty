namespace workerProject.Entities
{
    internal class Departament
    {
        //definindo a váriavel onde irá ficar armazenado o nome do departamento
        public string Name { get; set; }

        //construtor para caso seja instanciado sem valor
        public Departament()
        {
        }

        //construtor para caso seja instanciado com o nome parametrado
        public Departament(string name)
        {
            Name = name;
        }
    }
}
