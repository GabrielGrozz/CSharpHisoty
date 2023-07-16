/* o problrma do diamante se resume em, duas subclasses que se baseiam na mesma superclasse, porém queremos fazer uma classe que possua os métodos das duas subclasses
 * disso deriva o problema do diamante, ´pq uma sublaclasse não pode receber duas superclasses*/

using Diamanter.ENTITIES;

Device meuScanner = new Scanner() { SerialNumber = 1281};

Device meuPrinter = new Printer() { SerialNumber = 8543};

meuPrinter.ProcessDoc("minecraft");