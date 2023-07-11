using FileProject.ENTITIES;

string sourcePath = @"C:\dev\source.csv";
string outputPath = @"C:\dev\summary.csv";


FileStream fs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);

//IREMOS ARMAZENAR CADA LINHA EM UM INDEX DO ARRAY
//EU DEMOREI MTO TEMPO PARA SABER QUE SE PASSARMOS O FILE.READALLLINES EM UM ARRAY ELE IRIA ARMAZENAR CADA LINHA EM UM INDEX
//MEU DEUS QUANTO ESTRESSE PARA DESCOBRIR ISSO, MINHA VIDA FICOU 80% MAIS FÁCIL COM ISSO, OBRIGADO DJALMA KRL PORRA
string[] itemContent = File.ReadAllLines(sourcePath);

for (int i = 0; i < itemContent.Length; i++)
{
    string[] itemData = itemContent[1].Split(",");

    string itemName = itemData[0];
    double itemValue = double.Parse(itemData[1]);
    int itemQuantity = int.Parse(itemData[2]);

    IEnumerable<string> item = new List<string>() {itemName, itemValue.ToString(), itemQuantity.ToString()};
    //Order order = new Order(itemName, itemValue, itemQuantity);


    using (StreamWriter streamWriter = new StreamWriter(outputPath))
    {

        File.AppendText()
            streamWriter.WriteLine($"{itemName},{itemValue * itemQuantity}");
        
    }
}

