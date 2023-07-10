using FileProject.ENTITIES;

string sourcePath = @"C:\dev\source.csv";
FileStream fs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
StreamReader sr = new StreamReader(fs);

//IREMOS ARMAZENAR CADA LINHA EM UM INDEX DO ARRAY
//EU DEMOREI MTO TEMPO PARA SABER QUE SE PASSARMOS O FILE.READALLLINES EM UM ARRAY ELE IRIA ARMAZENAR CADA LINHA EM UM INDEX
//MEU DEUS QUANTO ESTRESSE PARA DESCOBRIR ISSO, MINHA VIDA FICOU 80% MAIS FÁCIL COM ISSO, OBRIGADO DJALMA KRL PORRA
string[] item = File.ReadAllLines(sourcePath);

string[] itemData = item[1].Split(",");

string itemName = itemData[0];
double itemValue = double.Parse(itemData[1]);
int itemQuantity = int.Parse(itemData[2]);


Order order = new Order(itemName, itemValue, itemQuantity);


