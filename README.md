# Desafio-Programacao

Caso o Projeto aberto no Visual Studio, de um duplo click no Database encontrado na pasta App_Data do View, copiando o **Caminho da Conexão**
em propriedade colando na Classe Conexao localizado no Repository.
Para realizar a execução basta selecionaro arquivo View localizano local a seguir *Desafio-Programacao\Desafio\View\bin\Debug* ou precionando 
o botão F5 no Visual Studio.

***Tela Principal***
     A tela dispoem de duas opções, sendo elas: Cadastro e Consulta. Cada uma com subseções sendo as de Cadastro: Pessoa, Sala de Evento, Espaço de Café; 
As opções de Consulta são: Pessoa, Sala de Evento e a de Espaço de Café.

***Tela de Cadastro/Edição de Pessoa***
     A tela dispoem de um botão para *Salvar* que tem dupla funcionalidade, ele serve tanto para fazer o Cadastro de uma nova pessoa quanto para fazer a 
Edição de uma pessoa. Antes de poder fazer a edição de uma pessoa deve-se dar um duplo click no registro a ser editado. O que faz com que o botão de 
salvar saiba se é para fazer a edição o o encremento de um novo registro é o campo ID que fica invisivel na tela, que caso o ID esteja como 0 sera feito 
o incremento de um novo registro caso seja diferente de 0 sera feita a edição do registro selecionado. A tela dispoem também de um botão para *Desativar* 
uma pessoa, que fara com que o registro não seja mais mostrado na lista de Pessoas pórem ainda estara guardada no banco de dados.
A tela possui um campo para informar a data de nascimento e outra para informar o nome da mãe pois caso haja duas pessoas com o mesmo nome pode ser feita
a checagem pelo nome da mãe.

***Tela de Cadastro/Edição de Sala de Evento***
     A tela dispoem de um botão para *Salvar* que tem dupla funcionalidade, ele serve tanto para fazer o Cadastro de uma nova sala de evento quanto para 
fazer a Edição de uma sala. Para que se possa fazer a edição de uma das salas é necessario primeiro selecionar o registro a ser editado na tabela dando 
um duplo click sobre o registro desejado. A ação que faz com que o botão *Salvar* diferencie se o evento deve ser de Alterar ou de Inserir é o label do 
Id que, caso seja igual a 0, o botão identifica que deve ser incrementada uma nova sala; caso seja diferente de 0 ele fara a alteração de uma sala.
A tela dispoem também de um botão para *Desativar* uma sala de eventos, que fara com que o registro não seja mais mostrado na lista de Salas, pórem ainda 
estara guardada no banco de dados.
