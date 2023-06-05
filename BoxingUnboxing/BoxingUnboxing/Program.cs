//uma variavel do tipo object aceita qualquer tipo de valor, porém esse valor será alocado no heap, que ocasionará em uma utilização de memória
//esse prócesso se chama boxing
int x = 10;
Object value = x; 

//por outro lado temos o unboxing, que seria pegar esse valor do heap e coloca-lo no stack
//precisamos fazer um casting para deixar explicito o tipo de dado que será passado
int y = (int)value;